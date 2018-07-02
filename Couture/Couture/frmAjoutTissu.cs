using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Couture
{
    public partial class frmAjoutTissu : Couture.frmTissuParent
    {
        public frmAjoutTissu()
        {
            InitializeComponent();
        }

        private void frmAjoutTissu_Load(object sender, EventArgs e)
        {
            Outils.AlimenterCombobox("SELECT lblCategorieTissu FROM categorietissus;", cbxCategorie, "lblCategorieTissu");
            Outils.AlimenterCombobox("SELECT nomCouleur FROM couleur;", cbxCouleur, "nomCouleur");
            Outils.AlimenterCombobox("SELECT lblMateriau FROM materiau;", cbxMatierePrincipale, "lblMateriau");
            Outils.AlimenterCombobox("SELECT lblMotif FROM motif", cbxMotif, "lblMotif");
            Outils.AlimenterCombobox("SELECT largeurLaize FROM laize", cbxLaize, "largeurLaize");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // controle vraissemblance des données saisies sur le form
            if (this.controle())
            {

                //  instancie le bon objet MStagiaire et l'ajoute à la collection de sa section  
                // ==> enrichir pour impacter la BDD
                if (this.instancie())
                {
                    // cas général :
                    // si l'instanciation stagiaire et 
                    // son ajout en collection est OK :
                    // - fermeture de la boite de dialogue par validation
                    this.DialogResult = DialogResult.OK;
                }
            }

        }



        /// <summary>
        /// Fonction qui permet d'instancier un nouveau tissu
        /// </summary>
        /// <returns></returns>



        private void picTissu_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog parcourirPhotoTissu = new OpenFileDialog();
            // image filters  
            parcourirPhotoTissu.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (parcourirPhotoTissu.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                picTissu.Image = new Bitmap(parcourirPhotoTissu.FileName);
                // image file path  
                picTissu.Text = parcourirPhotoTissu.FileName;
                picTissu.SizeMode = PictureBoxSizeMode.StretchImage;
                // créer ton chemin d'accès
                string path = Path.Combine(Environment.CurrentDirectory, "photostissus");
                // Ensuite, tu récupères ton nom de fichier
                string fileName = Path.GetFileName(parcourirPhotoTissu.FileName);
                //copier le fichier
                // de l'emplacement indiqué par l'utilisateur
                // à celui que tu as défini
                File.Copy(parcourirPhotoTissu.FileName, Path.Combine(path, fileName));
                string cheminPhotoCopiee = Path.Combine(path, fileName);
                MessageBox.Show("Le nom de la photo est : " + fileName + " \n et son chemin d'accès est : " +
                    Path.Combine(path, fileName) + ".");
            }
        }

        /// <summary>
        /// Si l'utilisateur saisit le mauvais séparateur de décimal, écrire le bon séparateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            // stoque le séparateur décimal du système 
            char Separateur = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            // dans le cas de l'ecriture d'un séparateur 
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                // Force l'ecriture du bon séparateur 
                e.KeyChar = Separateur;
            }

        }
        /// <summary>
        /// Si l'utilisateur saisit le mauvais séparateur de décimal, écrire le bon séparateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMetrage_KeyPress(object sender, KeyPressEventArgs e)
        {
            // stoque le séparateur décimal du système 
            char Separateur = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            // dans le cas de l'ecriture d'un séparateur 
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                // Force l'ecriture du bon séparateur 
                e.KeyChar = Separateur;
            }

        }

        private Boolean controle()
        {
            // contrôler la vraissemblance des champs saisis
            Boolean code = true; // le code de retour ; OK a priori

            //Controle prix au mètre est une valeur numérique
            //Si non = message d'erreur 
            //Si oui, si un des caracteres est une virgule, remplacer par un point 

            if (!Outils.EstUneValeurNumerique(this.txtPrix.Text))
            {
                // la chaîne reçue n'est pas convertible
                code = false;
                MessageBox.Show("le prix saisi n'est pas une valeur numérique", "ERREUR", MessageBoxButtons.OK);
            }

            //Controle Metrage

            if (!Outils.EstUneValeurNumerique(this.txtMetrage.Text))
            {
                // la chaîne reçue n'est pas convertible
                code = false;
                MessageBox.Show("le métrage saisi n'est pas une valeur numérique", "ERREUR", MessageBoxButtons.OK);
            }


            //Controle Elasticite
            if (this.txtElasticite.Text != "" && !(Outils.EstEntier(this.txtElasticite.Text)))
            {
                code = false;
                MessageBox.Show("Vous devez saisir un entier", "ERREUR", MessageBoxButtons.OK);
                this.txtElasticite.BackColor = Color.Blue;
                this.txtElasticite.Focus();
            }

            //Controle Densite
            if (this.txtDensite.Text != "" && !(Outils.EstEntier(this.txtDensite.Text)))
            {
                code = false;
                MessageBox.Show("Vous devez saisir un entier", "ERREUR", MessageBoxButtons.OK);
                this.txtDensite.BackColor = Color.Blue;
                this.txtDensite.Focus();
            }

            //Controle que le nom du tissu a bien été saisi
            if (this.txtNom.Text == "")
            {
                code = false;
                MessageBox.Show("Le nom du tissu est obligatoire", "ERREUR", MessageBoxButtons.OK);
                this.txtNom.BackColor = Color.Blue;
                this.txtNom.Focus();
            }

            //Controle que les cbxCouleur et cbxMotif ont bien été renseignés

            if (!Outils.CbxVoidControl(this.cbxCouleur))
            {
                MessageBox.Show("Sélectionnez une couleur dans la liste proposée ou saisissez en une");
                cbxCategorie.BackColor = Color.Blue;
                cbxCategorie.Focus();
            }

            if (!Outils.CbxVoidControl(this.cbxMotif))
            {
                MessageBox.Show("Sélectionnez un motif dans la liste proposée ou saisissez en une");
                cbxCategorie.BackColor = Color.Blue;
                cbxCategorie.Focus();
            }

            if (this.cbxLaize.SelectedIndex == -1)
            {
                MessageBox.Show("Sélectionnez une laize pour votre tissu");
                cbxLaize.Focus();
            }

            //Controle qu'un item de la cbxCategorie ait bien été sélectionné

            if (this.cbxCategorie.SelectedIndex == -1)
            {
                MessageBox.Show("Sélectionnez une catégorie dans la liste proposée");
                cbxCategorie.BackColor = Color.Blue;
                cbxCategorie.Focus();
            }

            return code;
        }

        /// <summary>
        /// Fonction qui permet d'instancier un nouveau tissu
        /// </summary>
        /// <returns></returns>
        private bool instancie()
        {
            //Créer une référence d'objet MTissu
            MTissu nouveauTissu;
            

            try
            {



                bool decati;
                if (this.chkLave.Checked == true)
                {
                    decati = true;
                }
                else if (this.chkLave.Checked == false)
                {
                    decati = false;
                }

                //Faire appel à la méthode qui permet de déterminer la valeur à attribuer
                //à la couleur et au motif du tissu qui sera instancié
                //Soit l'item selectionné dans la combobox, soit le texte saisi par l'utilisateur
                string couleur;
                string motif;
                couleur = Outils.AttribuerValeurCbx(base.cbxCouleur);
                motif = Outils.AttribuerValeurCbx(base.cbxMotif);



                nouveauTissu = new MTissu(
                   base.txtNom.Text.ToLower(),
                   (base.txtCommentaire.Text.Trim() == "" ? "Rien à déclarer." : base.txtCommentaire.Text),
                   (base.txtPrix.Text.Trim() == "" ? 0 : float.Parse(base.txtPrix.Text)),
                   chkLave.Checked,
                   (base.txtElasticite.Text.Trim() == "" ? 0 : int.Parse(base.txtElasticite.Text.Trim())),
                   (base.txtDensite.Text.Trim() == "" ? 0 : int.Parse(base.txtDensite.Text.Trim())),
                   (base.txtMetrage.Text.Trim() == "" ? 0 : int.Parse(base.txtMetrage.Text.Trim())),
                   int.Parse(base.cbxLaize.SelectedItem.ToString()),
                   couleur.ToLower().Trim(),
                   motif.ToLower().Trim(),
                   base.picTissu.Text.Trim(), //photourl
                                              //   base.AccessibleDefaultActionDescription; // nomPhoto
                   base.txtProvenance.Text.ToLower(),
                   base.cbxCategorie.SelectedItem.ToString(),
                   base.cbxMatierePrincipale.SelectedItem.ToString().ToLower().Trim());

                //Avant enrichissement dans la BDD verifier que l'occurence n'existe pas
                if (!MTissu.controlExistanceTissuRecord(nouveauTissu))
                {
                    MessageBox.Show("Un tissu avec ce nom existe déjà, veuillez vérifier votre stock (Liste des Tissus).");
                    return false;

                }


                //On définit ces variables qui stockeront les id qui seront réutilisés comme paramètres de la méthode
                //insertTissu
                long idCouleur = 0;
                long idMotif = 0;

                //Définir l'idMotif selon si l'utilisateur saisit un nouveau motif
                //Auquel cas ce motif s'il n'est pas existant dans la combobox sera ajouté
                //Dans la table motif en BDD. L'id de cette insertion sera récupéré
                // Si l'utilisateur sélectionne un motif dans la liste,
                //On récupère directement cet id
                if (this.cbxMotif.SelectedIndex == -1 && this.cbxMotif.Text.Trim() != "") // Si le motif a été saisi
                {
                    idMotif = MTissu.getInsertedIdMotif(nouveauTissu);
                }
                else if (this.cbxMotif.SelectedIndex > -1) //Si le motif a été sélectionné dans la liste
                {
                    idMotif = MTissu.getSelectedIdMotif(nouveauTissu);
                }

                //Choix d'appel de la méthode permettant de definir l'idCouleur utilisée dans insertTissu
                if (this.cbxCouleur.SelectedIndex == -1 && this.cbxCouleur.Text.Trim() != "") //si la couleur a été saisie
                {
                    idCouleur = MTissu.getInsertedIdCouleur(nouveauTissu);
                }

                else if (this.cbxCouleur.SelectedIndex > -1) // si la couleur a été sélectionnée
                {
                    idCouleur = MTissu.getSelectedIdCouleur(nouveauTissu);
                }

                //Insère dans la table Tissu
                MTissu.insertTissu(nouveauTissu, idCouleur, idMotif);

                return true;
            }
            catch (Exception ex)
            {
                nouveauTissu = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de tissu");
                return false;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }

}



