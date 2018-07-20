using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Couture
{
    public partial class frmConsultationTissu : Couture.frmTissuParent
    {
        /// <summary>
        /// Le tissu à afficher
        /// </summary>
        private MTissu leTissu;

        public frmConsultationTissu(MTissu unTissu)
        {
            InitializeComponent();
            this.leTissu = unTissu;
        }

        /// <summary>
        /// Fermer sans incidence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmConsultationTissu_Load(object sender, EventArgs e)
        {
            afficheTissu();
        }

        /// <summary>
        /// Affiche dans les différents controle les données du stagiaire chargé dans ce formulaire
        /// </summary>
        private void afficheTissu()
        {
            this.txtNom.Text = leTissu.NomTissu;
            this.txtProvenance.Text = leTissu.NomFournisseur;
            this.txtCommentaire.Text = leTissu.CommentaireTissu;
            this.txtDensite.Text = leTissu.DensiteTissu.ToString();
            this.txtElasticite.Text = leTissu.ElasticiteTissu.ToString();
            this.txtMetrage.Text = leTissu.MetrageTissu.ToString();
            
        }

        private void lblDensite_Click(object sender, EventArgs e)
        {

        }
    }
}
