using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient ;
namespace Couture
{
    class MTissu
    {
        //Definition des attributs
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
        private string nomFournisseur;
        private string categorieTissu;
        private string matierePremiere;

        // Mise en place des getters et setters

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
            set { this.metrageTissu= value; }
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
        }

        public string NomFournisseur
        {
            get { return this.nomFournisseur; }
            set { this.nomFournisseur = value.Trim().ToLower(); }
        }

        public string CategorieTissu
        {
            get { return this.categorieTissu; }
            set { this.categorieTissu = value.Trim().ToLower() ; }
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
            Image unePhoto, string unNomFournisseur, string uneCategorieTissu, string uneMatierePremiere)

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
            this.PhotoTissu = unePhoto;
            this.NomFournisseur = unNomFournisseur;
            this.CategorieTissu = uneCategorieTissu;
            this.MatierePremiere = uneMatierePremiere;
            

        }

        public static void insertTissu(MTissu leTissu)
        {
            MySqlCommand cmd = ConnexionBDD.GetConnexionBDD().CreateCommand();

            //Insère dans la table tissu les différents attributs
            cmd.CommandText = "INSERT INTO tissu" +
                "(nomTissu,prixAchatTissu,commentaireTissu,DecatiTissu,DensiteTissu,ElasticiteTissu,MetrageTissu, ) " +
                "VALUES(@nomTissu,@prixAchatTissu,@commentaireTissu,@decatiTissu,@elasticiteTissu,@metrageTissu)";
            cmd.Parameters.AddWithValue("@nomTissu", leTissu.NomTissu);
            cmd.Parameters.AddWithValue("@prixAchatTissu", leTissu.PrixAchatTissu);
            cmd.Parameters.AddWithValue("@commentaireTissu", leTissu.CommentaireTissu);
            cmd.Parameters.AddWithValue("@decatiTissu", leTissu.DecatiTissu);
            cmd.Parameters.AddWithValue("@elasticiteTissu", leTissu.ElasticiteTissu);
            cmd.Parameters.AddWithValue("@metrageTissu", leTissu.MetrageTissu);

            //Insère dans la table constituer l'id du tissu
            

            cmd.ExecuteNonQuery();

        
        }


    }
}
