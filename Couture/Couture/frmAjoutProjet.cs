using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Couture
{
    public partial class frmAjoutProjet : Couture.frmProjetParent
    {
        public frmAjoutProjet()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAjoutTissu_Click(object sender, EventArgs e)
        {
            frmAssocierTissuProjet frmAjout = new frmAssocierTissuProjet();
            
            // si on sort de la saisie par OK
            if (frmAjout.ShowDialog() == DialogResult.OK)
            {
                // régénèrer l'affichage du dataGridView 
                

            }
        }
    }
}
