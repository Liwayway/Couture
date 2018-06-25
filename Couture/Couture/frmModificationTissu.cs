using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Couture
{
    public partial class frmConsultationModifTissu : Couture.frmTissuParent
    {

        /// <summary>
        /// le stagiaire à afficher / modifier
        /// (on n'affecte pas directement sur le stagiaire fourni
        /// et l'utilisateur pourra abandonner les saisies en cours par bouton Refaire)
        /// </summary>
        private MTissu leTissu;


        public frmConsultationModifTissu(MTissu unTissu)
        {
            InitializeComponent();
            this.leTissu = unTissu;
        }

        private void frmConsultationModifTissu_Load(object sender, EventArgs e)
        {
            
          
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
