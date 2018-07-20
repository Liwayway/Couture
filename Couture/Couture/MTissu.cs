using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;


namespace Couture
{
    public class MTissu
    {
        //Definition des attributs
        private long idTissu;
        private long idLaize;
        private long idTechnique;
        private long idCouleur;
        private long idMotif;
        private long idFournisseur;
        private long idMateriau;
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
            get { return this.idTissu; }
            set { this.idTissu = value; }
        }

        public long IdLaize
        {
            get { return this.idLaize; }
            set { this.idLaize = value; }
        }

        public long IdTechnique
        {
            get { return this.idTechnique; }
            set { this.idTechnique = value; }
        }

        public long IdCouleur
        {
            get { return this.idCouleur; }
            set { this.idCouleur = value; }
        }

        public long IdMotif
        {
            get { return this.idMotif; }
            set { this.idMotif = value; }
        }

        public long IdMateriau
        {
            get { return this.idMateriau; }
            set { this.idMateriau = value; }
        }

        public long IdFournisseur
        {
            get { return this.idFournisseur; }
            set { this.idFournisseur = value; }
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
        /// Il sera utilisé notamment par la méthode getDonneesTissus
        /// </summary>
        public MTissu()
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
        /// Insère le motif saisi dans table motif
        /// Retourne l'id du motif qui vient d'être inséré pour le réutiliser dans une autre méthode
        /// </summary>
        /// <param name="leTissu"></param>
        /// <param name="dernierIdTissu"></param>
        public static long getInsertedIdMotif(MTissu leTissu)
        {
            //On définit une variable permettant de stocker l'id du motif
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

            cmd.Parameters.AddWithValue("@motifTissu", leTissu.Motif);
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
            long idMateriauSelectionne;
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

            cmd.CommandText = "INSERT INTO tissu (nomTissu, prixAchatTissu, commentaireTissu, decatiTissu, elasticiteTissu," +
                " densiteTissu, metrageTissu, idCouleur, idLaize, idTechnique, idFournisseur, idMotif, idMateriau)" +
                "VALUES (@nomTissu, @prixAchatTissu, @commentaireTissu, @decatiTissu, @elasticiteTissu, @densiteTissu, @metrageTissu," +
                " @idCouleur, @idLaize, @idTechnique, @idFournisseur, @idMotif, @idMateriau);";




            cmd.Parameters.AddWithValue("@nomTissu", leTissu.NomTissu.Trim());
            cmd.Parameters.AddWithValue("@prixAchatTissu", leTissu.PrixAchatTissu);
            cmd.Parameters.AddWithValue("@commentaireTissu", leTissu.CommentaireTissu);
            cmd.Parameters.AddWithValue("@decatiTissu", leTissu.DecatiTissu);
            cmd.Parameters.AddWithValue("@densiteTissu", leTissu.DensiteTissu);
            cmd.Parameters.AddWithValue("@elasticiteTissu", leTissu.ElasticiteTissu);
            cmd.Parameters.AddWithValue("@metrageTissu", leTissu.MetrageTissu);
            cmd.Parameters.AddWithValue("@idCouleur", idCouleur);
            cmd.Parameters.AddWithValue("@idLaize", idLaize);
            cmd.Parameters.AddWithValue("@idTechnique", idCategorieSelectionnee);
            cmd.Parameters.AddWithValue("@idFournisseur", idFournisseur);
            cmd.Parameters.AddWithValue("@idMotif", idMotif);
            cmd.Parameters.AddWithValue("@idMateriau", idMateriauSelectionne);

            dernierIdTissu = cmd.LastInsertedId;
            cmd.ExecuteNonQuery();
           
        }


        /// <summary>
        /// Récupère les données du tissu stockées dans la base de données
        /// Retourne une dataTable qui sera réutilisée pour afficher la liste des tissus
        /// dans la datagrid de frmListeTissus
        /// </summary>
        /// <returns></returns>
        /// <summary>
        /// Récupère les données du tissu stockées dans la base de données
        /// Retourne une dataTable qui sera réutilisée pour afficher la liste des tissus
        /// dans la datagrid de frmListeTissus
        /// </summary>
        /// <returns></returns>
        public static DataTable getDonneesTissus()
        {
            /// générer et retourner une datatable
            /// qui liste les noms, couleur, motif ' categorie de tous les tissus de la table tissus
            DataTable dtTissus = new DataTable();

            //Ajouter des colonnes à la datatable
            dtTissus.Columns.Add(new DataColumn("Tissu n° ", typeof(Int64)));
            dtTissus.Columns.Add(new DataColumn("Nom du Tissu", typeof(String)));
            dtTissus.Columns.Add(new DataColumn("Tissu lavé", typeof(Boolean)));
            dtTissus.Columns.Add(new DataColumn("Couleur", typeof(String)));
            dtTissus.Columns.Add(new DataColumn("Motif", typeof(String)));
            dtTissus.Columns.Add(new DataColumn("Catégorie", typeof(String)));

            //Déclaration des variables stockant les données des id lus par les datareader
            long idTissu = 0;
            long idLaize = 0;
            long idCouleur = 0;
            long idTechnique = 0;
            long idFournisseur = 0;
            long idMotif = 0;
            long idMateriau = 0;

            int i; //variable d'itération


            //Récupérer les données de la table tissus
            MySqlCommand cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();
            cmd.CommandText = "SELECT * FROM tissu";
            MySqlDataReader readerTableTissu = cmd.ExecuteReader();
            ArrayList arrayTissu = new ArrayList();

            while (readerTableTissu.Read())
            {
                // créer une référence d'objet MTissu
                MTissu nouveauTissu = new MTissu();

                //Affecter les attributs du tissu contenu dans table tissu
                idTissu = readerTableTissu.GetInt64(0);
                nouveauTissu.NomTissu = readerTableTissu.GetString(1);
                nouveauTissu.prixAchatTissu = readerTableTissu.GetFloat(2);
                nouveauTissu.CommentaireTissu = readerTableTissu.GetString(3);
                nouveauTissu.DecatiTissu = readerTableTissu.GetBoolean(4);
                nouveauTissu.ElasticiteTissu = readerTableTissu.GetInt16(5);
                nouveauTissu.DensiteTissu = readerTableTissu.GetInt16(6);
                nouveauTissu.MetrageTissu = readerTableTissu.GetInt16(7);

                //Récupérer les id des attributs dont les noms/labels sont situés dans les autres tables
                
                idLaize = readerTableTissu.GetInt64(9);
                idCouleur = readerTableTissu.GetInt64(8);
                idTechnique = readerTableTissu.GetInt64(10);
                idFournisseur = readerTableTissu.GetInt64(11);
                idMotif = readerTableTissu.GetInt64(12);
                idMateriau = readerTableTissu.GetInt64(13);
                // affecter les données de l'objet MTissu :
                // variables simples, ou propriétés ce qui déclenche alors
                // le code des méthodes set
                nouveauTissu.IdTissu = idTissu;
                nouveauTissu.IdLaize = idLaize;
                nouveauTissu.IdCouleur = idCouleur;
                nouveauTissu.IdTechnique = idTechnique;
                nouveauTissu.IdFournisseur = idFournisseur;
                nouveauTissu.IdMotif = idMotif;
                nouveauTissu.IdMateriau = idMateriau;




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
                dr[0] = nouveauTissu.idTissu;
                dr[1] = nouveauTissu.NomTissu;
                dr[2] = nouveauTissu.DecatiTissu;
                dtTissus.Rows.Add(dr);

                //Récupérer le nom de couleur de la table couleur
                cmd2.CommandText = "SELECT nomCouleur FROM couleur WHERE idCouleur = @idCouleur;";
                cmd2.Parameters.AddWithValue("@idCouleur", nouveauTissu.IdCouleur);

                MySqlDataReader readerTableCouleur = cmd2.ExecuteReader();
                if (readerTableCouleur.HasRows)
                {
                    while (readerTableCouleur.Read())
                    {
                       // nouveauTissu.Couleur = readerTableCouleur.GetString(0);
                        dr[3] = readerTableCouleur.GetString(0);
                    }

                }
                readerTableCouleur.Close();


                //Récupérer la largeurlaize
                cmd2.CommandText = "SELECT largeurlaize FROM laize WHERE idLaize = @idLaize;";
                cmd2.Parameters.AddWithValue("@idLaize", nouveauTissu.IdLaize);
                MySqlDataReader readerTableLaize = cmd2.ExecuteReader();
                if (readerTableLaize.HasRows)
                {
                    while (readerTableLaize.Read())
                    {
                        nouveauTissu.Laize = readerTableLaize.GetInt16(0);

                    }

                }
                readerTableLaize.Close();

                // lblCategorieTissu
                cmd2.CommandText = "SELECT lblCategorieTissu FROM categorietissus WHERE idTechnique = @idTechnique;";
                cmd2.Parameters.AddWithValue("@idTechnique", nouveauTissu.IdTechnique);
                MySqlDataReader readerinTableCategorieTissu = cmd2.ExecuteReader();
                if (readerinTableCategorieTissu.HasRows)
                {
                    while (readerinTableCategorieTissu.Read())
                    {
                        nouveauTissu.CategorieTissu = readerinTableCategorieTissu.GetString(0);
                        dr[5] = nouveauTissu.CategorieTissu;
                    }

                }
                readerinTableCategorieTissu.Close();


                //Recupérer Fournisseur
                cmd2.CommandText = "SELECT nomFournisseur FROM fournisseur WHERE idFournisseur = @idFournisseur;";
                cmd2.Parameters.AddWithValue("@idFournisseur", nouveauTissu.IdFournisseur);
                MySqlDataReader readerInTableFournisseur = cmd2.ExecuteReader();

                if (readerInTableFournisseur.HasRows)
                {
                    while (readerInTableFournisseur.Read())
                    {
                        nouveauTissu.NomFournisseur = readerInTableFournisseur.GetString(0);

                    }

                }
                readerInTableFournisseur.Close();


                //Récupérer les données de la table motif
                cmd2.CommandText = "SELECT lblMotif FROM motif  WHERE idMotif  = @idMotif";

                cmd2.Parameters.AddWithValue("@idMotif", nouveauTissu.IdMotif);
                MySqlDataReader readerTableDefinirMotif = cmd2.ExecuteReader();
                if (readerTableDefinirMotif.HasRows)
                {
                    while (readerTableDefinirMotif.Read())
                    {
                        nouveauTissu.Motif = readerTableDefinirMotif.GetString(0);
                        dr[4] = nouveauTissu.Motif;
                    }

                }
                readerTableDefinirMotif.Close();

                //Récupérer les données de la table materiau
                cmd2.CommandText = "SELECT lblMateriau FROM materiau WHERE idMateriau = @idMateriau;";
                cmd2.Parameters.AddWithValue("@idMateriau", nouveauTissu.IdMateriau);
                MySqlDataReader readerInTableMateriau = cmd.ExecuteReader();
                if (readerInTableMateriau.HasRows)
                {
                    while (readerInTableMateriau.Read())
                    {
                        nouveauTissu.MatierePremiere = readerInTableMateriau.GetString(0);

                    }

                }
                readerInTableMateriau.Close();

            }

            return dtTissus;
        }

        /// <summary>
        /// Suppression du tissu à partir de son identifiant
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteTissu(long id)
        {

            MySqlCommand cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();
            cmd.CommandText = "DELETE FROM tissu WHERE idTissu=@idTissu;";
            cmd.Parameters.AddWithValue("@idTissu", id);
            cmd.ExecuteNonQuery();
            ConnexionBDD.CloseConnection();
        }


        /// <summary>
        /// Renvoit les données d'un tissu de la base de données
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static MTissu GetDonnneesTissuById(long Id)
        {
            //Déclaration des variables stockant les données des id lus par les datareader
            long idFabric = 0;
            long idLaize = 0;
            long idCouleur = 0;
            long idTechnique = 0;
            long idFournisseur = 0;
            long idMotif = 0;
            long idMateriau = 0;


            MTissu nouveauTissu = new MTissu();

            MySqlCommand cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();

            //Verifier que ce tissu existe bien en BDD
            cmd.CommandText = "SELECT COUNT(*) FROM tissu WHERE idTissu = @idTissu";
            cmd.Parameters.AddWithValue("@idTissu", Id);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int result = reader.GetInt16(0);
            reader.Close();

            if (result == 0) //Pas de tissu existant
            {
                throw new Exception("Aucun tissu  pour l'idTissu " + Id.ToString());
            }

            cmd.CommandText = "SELECT * FROM tissu WHERE idTissu = @idTissu;";
            MySqlDataReader readerTableTissu = cmd.ExecuteReader();



            while (readerTableTissu.Read())
            {


                //Affecter les attributs du tissu contenu dans table tissu
                idFabric = readerTableTissu.GetInt64(0);
                nouveauTissu.NomTissu = readerTableTissu.GetString(1);
                nouveauTissu.prixAchatTissu = readerTableTissu.GetFloat(2);
                nouveauTissu.CommentaireTissu = readerTableTissu.GetString(3);
                nouveauTissu.DecatiTissu = readerTableTissu.GetBoolean(4);
                nouveauTissu.ElasticiteTissu = readerTableTissu.GetInt16(5);
                nouveauTissu.DensiteTissu = readerTableTissu.GetInt16(6);
                nouveauTissu.MetrageTissu = readerTableTissu.GetInt16(7);

                //Récupérer les id des attributs dont les noms/labels sont situés dans les autres tables

                idLaize = readerTableTissu.GetInt64(9);
                idCouleur = readerTableTissu.GetInt64(8);
                idTechnique = readerTableTissu.GetInt64(10);
                idFournisseur = readerTableTissu.GetInt64(11);
                idMotif = readerTableTissu.GetInt64(12);
                idMateriau = readerTableTissu.GetInt64(13);
                // affecter les données de l'objet MTissu :
                // variables simples, ou propriétés ce qui déclenche alors
                // le code des méthodes set
                nouveauTissu.IdTissu = idFabric;
                nouveauTissu.IdLaize = idLaize;
                nouveauTissu.IdCouleur = idCouleur;
                nouveauTissu.IdTechnique = idTechnique;
                nouveauTissu.IdFournisseur = idFournisseur;
                nouveauTissu.IdMotif = idMotif;
                nouveauTissu.IdMateriau = idMateriau;


            }
            readerTableTissu.Close();

            //Rechercher la largeurlaize et affecter l'attribut
            cmd.CommandText = "SELECT largeurlaize FROM laize WHERE idLaize = @idLaize;";
            cmd.Parameters.AddWithValue("@idLaize", nouveauTissu.IdLaize);
            MySqlDataReader readerLaize = cmd.ExecuteReader();
            readerLaize.Read();
            nouveauTissu.Laize = readerLaize.GetInt16(0);
            readerLaize.Close();


            //Rechercher la couleur du tissu et affecter l'attribut couleur de l'objet nouveauTissu
            cmd.CommandText = "SELECT nomCouleur FROM couleur WHERE idCouleur = @idCouleur;";
            cmd.Parameters.AddWithValue("@idCouleur", nouveauTissu.IdCouleur);
            MySqlDataReader readerCouleur = cmd.ExecuteReader();
            readerCouleur.Read();
            nouveauTissu.Couleur = readerCouleur.GetString(0);
            readerCouleur.Close();

            //Rechercher le motif du tissu 
            cmd.CommandText = "SELECT lblMotif FROM motif WHERE idMotif = @idMotif;";
            cmd.Parameters.AddWithValue("@idMotif", nouveauTissu.IdMotif);
            MySqlDataReader readerMotif = cmd.ExecuteReader();
            readerMotif.Read();
            nouveauTissu.Motif = readerMotif.GetString(0);
            readerMotif.Close();

            //Rechercher la catégorie du tissu
            cmd.CommandText = "SELECT lblCategorieTissu FROM categorietissus WHERE idTechnique = @idTechnique;";
            cmd.Parameters.AddWithValue("@idTechnique", nouveauTissu.IdTechnique);
            MySqlDataReader readerCategorie = cmd.ExecuteReader();
            readerCategorie.Read();
            nouveauTissu.CategorieTissu = readerCategorie.GetString(0);
            readerCategorie.Close();

            //Rechercher le nom du fournisseur
            cmd.CommandText = "SELECT nomFournisseur FROM fournisseur WHERE idFournisseur = @idFournisseur;";
            cmd.Parameters.AddWithValue("@idFournisseur", nouveauTissu.IdFournisseur);
            MySqlDataReader readerFournisseur = cmd.ExecuteReader();
            readerFournisseur.Read();
            nouveauTissu.NomFournisseur = readerFournisseur.GetString(0);
            readerFournisseur.Close();

            //Rechercher le materiau
            cmd.CommandText = "SELECT lblMateriau FROM materiau WHERE idMateriau = @idMateriau;";
            cmd.Parameters.AddWithValue("@idMateriau", nouveauTissu.IdMateriau);
            MySqlDataReader readerMateriau = cmd.ExecuteReader();
            readerMateriau.Read();
            nouveauTissu.MatierePremiere = readerMateriau.GetString(0);
            readerMateriau.Close();

            return nouveauTissu;


        }


    }


}
