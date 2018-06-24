using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient ;
using System.Windows.Forms;
using System.Data;
using System.Collections;


namespace Couture
{
    class MTissu
    {
        //Definition des attributs
        private long idTissu;
        private string nomTissu;
        private string commentaireTissu;
        private float prixAchatTissu;
        private bool decatiTissu;
        private int elasticiteTissu;
        private int densiteTissu;
        private int metrageTissu;
        private int laize;
        private string couleur;
        private string motif;
        private Image photoTissu;
        private string urlPhotoTissu;
        private string nomPhoto;
        private string nomFournisseur;
        private string categorieTissu;
        private string matierePremiere;

        // Mise en place des getters et setters
        public long IdTissu
        {
            get { return this.idTissu;  }
            set { this.idTissu = value; }
        }

        public string NomTissu
        {
            get { return this.nomTissu; }
            set { this.nomTissu = value.Trim().ToLower(); }
        }

        public string CommentaireTissu
        {
            get { return this.commentaireTissu; }
            set { this.commentaireTissu = value; }
        }

        public float PrixAchatTissu
        {
            get { return this.prixAchatTissu; }
            set { this.prixAchatTissu = (float)value; } // on cast pour être sur d'avoir un float
        }

        public bool DecatiTissu
        {
            get { return this.decatiTissu; }
            set { this.decatiTissu = value; }
        }

        public int ElasticiteTissu
        {
            get { return this.elasticiteTissu; }
            set { this.elasticiteTissu = value; }
        }

        public int DensiteTissu
        {
            get { return this.densiteTissu; }
            set { this.densiteTissu = value; }
        }

        public int MetrageTissu
        {
            get { return this.metrageTissu; }
            set { this.metrageTissu = value; }
        }

        public int Laize
        {
            get { return this.laize; }
            set { this.laize = value; }
        }

        public string Couleur
        {
            get { return this.couleur; }
            set { this.couleur = value.Trim().ToLower(); }
        }

        public string Motif
        {
            get { return this.motif; }
            set { this.motif = value; }
        }

        public Image PhotoTissu
        {
            get { return this.photoTissu; }
            set { this.photoTissu = value; }
        }

        public string UrlPhotoTissu
        {
            get { return this.urlPhotoTissu; }
            set { this.urlPhotoTissu = value; }
        }

        public string NomPhoto
        {
            get { return this.nomPhoto; }
            set { this.nomPhoto = value; }
        }

        public string NomFournisseur
        {
            get { return this.nomFournisseur; }
            set { this.nomFournisseur = value.Trim().ToLower(); }
        }

        public string CategorieTissu
        {
            get { return this.categorieTissu; }
            set { this.categorieTissu = value.Trim().ToLower(); }
        }

        public string MatierePremiere
        {
            get { return this.matierePremiere; }
            set { this.matierePremiere = value.Trim().ToLower(); }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nomTissu"></param>
        public MTissu(String unNom, string unCommentaire, float unPrixAchat, bool unDecatissage,
            int uneElasticite, int uneDensite, int unMetrage, int uneLaize, string uneCouleur, string unMotif,
            string uneUrlPhoto, /* string unNomPhoto ,*/ string unNomFournisseur, string uneCategorieTissu, string uneMatierePremiere)

        {
            this.NomTissu = unNom;
            this.CommentaireTissu = unCommentaire;
            this.PrixAchatTissu = unPrixAchat;
            this.DecatiTissu = unDecatissage;
            this.ElasticiteTissu = uneElasticite;
            this.DensiteTissu = uneDensite;
            this.MetrageTissu = unMetrage;
            this.Laize = uneLaize;
            this.Couleur = uneCouleur;
            this.Motif = unMotif;
            this.UrlPhotoTissu = uneUrlPhoto;
            //this.NomPhoto = unNomPhoto;
            this.NomFournisseur = unNomFournisseur;
            this.CategorieTissu = uneCategorieTissu;
            this.MatierePremiere = uneMatierePremiere;


        }

        /// <summary>
        /// Créer un constructeur vide
        /// </summary>
        public MTissu ()
        {

        }

        /// <summary>
        /// Contrôle si une occurence portant le même nom que le tissu saisi est déjà
        /// présente dans la BDD
        /// </summary>
        /// <param name="leTissu"></param>
        /// <returns></returns>
        public static bool controlExistanceTissuRecord(MTissu leTissu)
        {
            MySqlCommand cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();
            Boolean codeRetour = true; // A priori
           // int result;
            cmd.CommandText = "SELECT COUNT(*) FROM tissu WHERE nomTissu = @nomTissu"; // cmd.Parameters.Add("@motifTissu", SqlDbType.VarChar).Value = leTissu.Motif;
            cmd.Parameters.AddWithValue("@nomTissu", leTissu.NomTissu);
            //  string toto = cmd.ExecuteScalar().ToString();
            // result = int.Parse(toto);
            //  result = Convert.ToInt32(cmd.ExecuteScalar());
           // Int32 result = (Int32)cmd.ExecuteScalar();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int result = reader.GetInt16(0);
            reader.Close();

            if (result > 0) // Il existe une occurence dans la BDD
            {
                MessageBox.Show("Un tissu avec ce nom existe déjà, veuillez vérifier votre stock (Liste des Tissus).");
                codeRetour = false;
            }
            return codeRetour;
        }

        /// <summary>
        /// Insere la couleur saisie dans table couleur
        /// Puis recuperer l'id de la couleur 
        /// </summary>
        /// <param name="leTissu"></param>
        /// <param name="dernierIdTissu"></param>
        public static long getInsertedIdCouleur(MTissu leTissu)
        {

            long idCouleurInseree;
            MySqlCommand cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();
            cmd.CommandText = "INSERT INTO couleur (nomCouleur) VALUES (@nomCouleur)";
            cmd.Parameters.AddWithValue("@nomCouleur", leTissu.Couleur);
            cmd.ExecuteNonQuery();
            idCouleurInseree = cmd.LastInsertedId;

            return idCouleurInseree;


        }

        /// <summary>
        /// Recuperer l'id de la couleur selectionnée dans la cbxCouleur

        /// </summary>
        /// <param name="leTissu"></param>
        /// <param name="dernierIdTissu"></param>
        public static long getSelectedIdCouleur(MTissu leTissu)
        {
            long idCouleurSelectionnee;
            MySqlCommand cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();
            cmd.CommandText = "SELECT idCouleur FROM couleur WHERE nomCouleur = @couleurTissu;";

            cmd.Parameters.AddWithValue("@couleurTissu", leTissu.Couleur);
            MySqlDataReader readerIdCouleur = cmd.ExecuteReader();
            readerIdCouleur.Read();
            idCouleurSelectionnee = readerIdCouleur.GetInt64(0);
            readerIdCouleur.Close();

            return idCouleurSelectionnee;

        }

        /// <summary>
        /// Dans un premier temps, insère le motif saisi dans table motif
        /// Puis recuperer l'id du motif
        /// </summary>
        /// <param name="leTissu"></param>
        /// <param name="dernierIdTissu"></param>
        public static long getInsertedIdMotif(MTissu leTissu)
        {
            long idMotifInsere;
            MySqlCommand cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();
            //On insère dans la table motif le motif inscrit par l'utilisateur;
            cmd.CommandText = "INSERT INTO motif (lblMotif) VALUES (@lblMotif)";
            cmd.Parameters.AddWithValue("@lblMotif", leTissu.Motif);
            cmd.ExecuteNonQuery();
            idMotifInsere = cmd.LastInsertedId;

            return idMotifInsere;
        }

        /// <summary>
        /// Recuperer l'id du motif selectionné 
        /// </summary>
        /// <param name="leTissu"></param>
        /// <param name="dernierIdTissu"></param>
        public static long getSelectedIdMotif(MTissu leTissu)
        {
            long idMotifSelectionne;
            MySqlCommand cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();
            cmd.CommandText = "SELECT idMotif FROM motif WHERE lblMotif = @motifTissu;";

            cmd.Parameters.AddWithValue("@couleurTissu", leTissu.Motif);
            MySqlDataReader readerIdMotif = cmd.ExecuteReader();
            readerIdMotif.Read();
            idMotifSelectionne = readerIdMotif.GetInt64(0);
            readerIdMotif.Close();

            return idMotifSelectionne;
        }

        /// <summary>
        /// Insere en BDD dans la table tissu et les autres tables
        /// 
        /// </summary>
        /// <param name="leTissu"></param>
        /// <returns></returns>
        public static void insertTissu(MTissu leTissu, long idCouleur, long idMotif)
        {
            int result;
            long dernierIdTissu;
            long idCategorieSelectionnee;
            long idMateriauSelectionne ;
            long idLaize;
            long idFournisseur = 0;
            MySqlCommand cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();

            //Récupérer l'id de la categorie sélectionnée dans la combobox 
            cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();
            cmd.CommandText = "SELECT idTechnique FROM categorietissus WHERE lblCategorieTissu = @categorieTissu;";

            cmd.Parameters.AddWithValue("@categorieTissu", leTissu.CategorieTissu);
            MySqlDataReader readerIdTechnique = cmd.ExecuteReader();
            readerIdTechnique.Read();
            idCategorieSelectionnee = readerIdTechnique.GetInt64(0);
            readerIdTechnique.Close();

            //Récupérer l'id du materiau selectionné
            cmd.CommandText = "SELECT idMateriau FROM materiau WHERE lblMateriau = @materiau;";

            cmd.Parameters.AddWithValue("@materiau", leTissu.MatierePremiere);
            MySqlDataReader readerIdMateriau = cmd.ExecuteReader();
            readerIdMateriau.Read();
            idMateriauSelectionne = readerIdMateriau.GetInt64(0);
            readerIdMateriau.Close();

            //// //Récupérer l'id de la laize sélectionnée
            cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();
            cmd.CommandText = "SELECT idLaize FROM laize WHERE largeurLaize = @largeurLaize;";
            cmd.Parameters.AddWithValue("@largeurLaize", leTissu.Laize);
            MySqlDataReader readerIdLaize = cmd.ExecuteReader();
            readerIdLaize.Read();
            idLaize = readerIdLaize.GetInt64(0);
            readerIdLaize.Close();

            //// Insérer dans Fournisseur la provenance Verifier que ce nom de fournisseur n'est pas présent dans la base de données
            cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM fournisseur WHERE nomFournisseur = @nomFournisseur"; 
            cmd.Parameters.AddWithValue("@nomFournisseur", leTissu.NomFournisseur);
            MySqlDataReader readerVerifProvenance = cmd.ExecuteReader();
            readerVerifProvenance.Read();
            result = readerVerifProvenance.GetInt16(0);
            readerVerifProvenance.Close();
            

            if (result == 0)
            {
                cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();
                cmd.CommandText = "INSERT INTO fournisseur (nomFournisseur) VALUES (@provenancetissu);";
                cmd.Parameters.AddWithValue("@provenancetissu", leTissu.NomFournisseur);
                cmd.ExecuteNonQuery();
                idFournisseur = cmd.LastInsertedId;
            }
            else if (result > 0) //Existe déjà dans la base de données, récupérer l'id de ce fournisseur
            {
                cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();
                cmd.CommandText = "SELECT idFournisseur FROM fournisseur WHERE nomFournisseur = @nomFournisseur;";

                cmd.Parameters.AddWithValue("@nomFournisseur", leTissu.NomFournisseur);
                MySqlDataReader readerIdFournisseur = cmd.ExecuteReader();
                readerIdFournisseur.Read();
                idFournisseur = readerIdFournisseur.GetInt64(0);
                readerIdFournisseur.Close();
            }


            //On insere dans la table Tissu une nouvel enregistrement

            cmd.CommandText = "INSERT INTO tissu" +
                "(nomTissu, prixAchatTissu, commentaireTissu, decatiTissu, densiteTissu," +
                " elasticiteTissu, metrageTissu, idCouleur, idLaize, idTechnique, idFournisseur, idMotif, idMateriau)  " +
                "VALUES (@nomTissu,@prixAchatTissu,@commentaireTissu,@decatiTissu,@densiteTissu,@elasticiteTissu,@metrageTissu," +
                " @idCouleur, @idLaize, @idTechnique, @idFournisseur, @idMotif, @idMateriau);";




            cmd.Parameters.AddWithValue("@nomTissu", leTissu.NomTissu.Trim());
            cmd.Parameters.AddWithValue("@prixAchatTissu", leTissu.PrixAchatTissu);
            cmd.Parameters.AddWithValue("@commentaireTissu", leTissu.CommentaireTissu);
            cmd.Parameters.AddWithValue("@decatiTissu", leTissu.DecatiTissu);
            cmd.Parameters.AddWithValue("@densiteTissu", leTissu.DensiteTissu);
            cmd.Parameters.AddWithValue("@elasticiteTissu", leTissu.ElasticiteTissu);
            cmd.Parameters.AddWithValue("@metrageTissu", leTissu.MetrageTissu);
            cmd.Parameters.AddWithValue("@couleurTissu", idCouleur);
            cmd.Parameters.AddWithValue("@idLaize", idLaize);
            cmd.Parameters.AddWithValue("@idTechnique", idCategorieSelectionnee);
            cmd.Parameters.AddWithValue("@idFournisseur", idFournisseur);
            cmd.Parameters.AddWithValue("@idMotif", idMotif);
            cmd.Parameters.AddWithValue("@idMateriau", idMateriauSelectionne);


            cmd.ExecuteNonQuery();
            dernierIdTissu = cmd.LastInsertedId;
        }

        

        public static DataTable getDonneesTissus()
        {
            /// générer et retourner une datatable
            /// qui liste les noms, couleur, motif ' categorie de tous les tissus de la table tissus
            DataTable dtTissus = new DataTable();

            //Ajouter des colonnes à la datatable
            dtTissus.Columns.Add(new DataColumn("Nom du Tissu", typeof(String)));
            dtTissus.Columns.Add(new DataColumn("Tissu lavé", typeof(Boolean)));
            dtTissus.Columns.Add(new DataColumn("Couleur", typeof(String)));
            dtTissus.Columns.Add(new DataColumn("Motif", typeof(String)));
            dtTissus.Columns.Add(new DataColumn("Catégorie", typeof(String)));

            //Déclaration des variables stockant les données des id lus par les datareader
            long idTissu = 0;
            long idLaize = 0;

            int i; //variable d'itération


            //Récupérer les données de la table tissus
            MySqlCommand cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();
            cmd.CommandText = "SELECT idTissu,nomTissu, decatiTissu, idLaize FROM tissu";
            MySqlDataReader readerTableTissu = cmd.ExecuteReader();
            ArrayList arrayTissu = new ArrayList();

            while (readerTableTissu.Read())
            {
                // créer une référence d'objet MTissu
                MTissu nouveauTissu = new MTissu();

                idTissu = readerTableTissu.GetInt64(0);
                nouveauTissu.NomTissu = readerTableTissu.GetString(1);
                nouveauTissu.DecatiTissu = readerTableTissu.GetBoolean(2);
                idLaize = readerTableTissu.GetInt64(3);
                // affecter les données de l'objet MTissu :
                // variables simples, ou propriétés ce qui déclenche alors
                // le code des méthodes set
                nouveauTissu.idTissu = idTissu;



                arrayTissu.Add(nouveauTissu);

            }
            readerTableTissu.Close();

            for (i = 0; i < arrayTissu.Count; i++)
            {
                MTissu nouveauTissu = (MTissu)arrayTissu[i];
                MySqlCommand cmd2 = ConnexionBDD.GetConnexionBDD().CreateCommand();
                // l'ajouter dans la data table
                DataRow dr;
                dr = dtTissus.NewRow();
                dr[0] = nouveauTissu.NomTissu;
                dr[1] = nouveauTissu.DecatiTissu;
                dtTissus.Rows.Add(dr);

                //Récupérer les données de la table définir_couleur
                cmd2.CommandText = "SELECT nomCouleur FROM couleur WHERE idCouleur IN (SELECT idCouleur FROM definir_couleur WHERE idTissu = @idTissu2)";
                cmd2.Parameters.AddWithValue("@idTissu2", nouveauTissu.idTissu);

                MySqlDataReader readerTableCouleur = cmd2.ExecuteReader();
                if (readerTableCouleur.HasRows)
                {
                    while (readerTableCouleur.Read())
                    {
                        dr[2] = readerTableCouleur.GetString(0);
                    }

                }
                readerTableCouleur.Close();

                //Récupérer les données de la table definir_motif
                cmd2.CommandText = "SELECT lblMotif FROM motif  WHERE idMotif IN (SELECT idMotif FROM definir_motif WHERE idTissu = @idTissu3)";

                cmd2.Parameters.AddWithValue("@idTissu3", nouveauTissu.idTissu);
                MySqlDataReader readerTableDefinirMotif = cmd2.ExecuteReader();
                if (readerTableDefinirMotif.HasRows)
                {
                    while (readerTableDefinirMotif.Read())
                    {
                        dr[3] = readerTableDefinirMotif.GetString(0);
                    }

                }
                readerTableDefinirMotif.Close();

                // technique
                cmd2.CommandText = "SELECT lblCategorieTissu FROM categorieTissus WHERE idTechnique IN (SELECT idTechnique FROM classertissu WHERE idTissu = @idTissu4);";
                cmd2.Parameters.AddWithValue("@idTissu4", nouveauTissu.idTissu);
                MySqlDataReader readerinTableClasserTissu = cmd2.ExecuteReader();
                if (readerinTableClasserTissu.HasRows)
                {
                    while (readerinTableClasserTissu.Read())
                    {
                        dr[4] = readerinTableClasserTissu.GetString(0);
                    }

                }
                readerinTableClasserTissu.Close();

            }

            return dtTissus;
        }


    }


}
