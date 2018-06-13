using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            Outils.AlimenterCombobox("SELECT codeTechnique, lblCategorieTissu FROM categorietissus;", cbxCategorie, "lblCategorieTissu");
            Outils.AlimenterCombobox("SELECT codeCouleur, nomCouleur FROM couleur;", cbxCouleur, "nomCouleur");
            Outils.AlimenterCombobox("SELECT codeMateriau, lblMateriau FROM materiau;", cbxMatierePrincipale, "lblMateriau");
            Outils.AlimenterCombobox("SELECT codeMotif, lblMotif FROM motif", cbxMotif, "lblMotif");
            Outils.AlimenterCombobox("SELECT codeLaize, largeurLaize FROM laize", cbxLaize, "largeurLaize");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        /*
         public MTissu(String unNom, string unCommentaire, float unPrixAchat, bool unDecatissage, 
            int uneElasticite, int uneDensite, int unMetrage, int uneLaize, string uneCouleur, string unMotif,
            Image unePhoto, string unNomFournisseur, string uneCategorieTissu, string uneMatierePremiere)
            
             nouveauStagiaire = new MStagiaireCIF(
                        
                        Convert.ToInt32(this.txtFongecif.Text),
                        leTypeCIF); 
             
             */

        /// <summary>
        /// Fonction qui permet d'instancier un nouveau tissu
        /// </summary>
        /// <returns></returns>
        private bool instancieTissu()
        {

            MTissu nouveauTissu;

            bool Decati;
            string typeTissu;

            if (this.chkLave.Checked == true)
            {
                Decati = true;
            }
            else if (this.chkLave.Checked == false)
            {
                Decati = false;
            }

            

            nouveauTissu = new MTissu(
                base.txtNom.Text.ToLower(),
                base.txtCommentaire.Text,
                float.Parse(base.txtPrix.Text.Trim()),
                int.Parse(base.txtElasticite.Text.Trim()),
                int.Parse(base.txtDensite.Text.Trim()),
                int.Parse(base.txtMetrage.Text.Trim()),
               




                
                
                )


            return true;
        }
    }
}
