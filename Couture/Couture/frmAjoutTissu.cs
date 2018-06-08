using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Couture
{
    public partial class frmAjoutTissu : Form
    {
        public frmAjoutTissu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void gbxOption_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnNon_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Permet de faire apparaitre le groupe box des caractéristiques avancées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lklblAvances_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gbxAvances.Visible = true;
            //Déplace les boutons et modifie la hauteur du form
            btnAnnuler.Location = new Point(576, 725);
            btnAjoutProjet.Location = new Point(368, 725);
            btnOK.Location = new Point(465, 725);
            this.Height = 819;
            gbxAvances.Location = new Point(12, 373);
            gbxCommentaire.Location = new Point(12, 543);
        }

        private void txtCommentaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAjoutTissu_Load(object sender, EventArgs e)
        {
            gbxAvances.Visible = false;
            btnAjoutProjet.Location = new Point(358, 554);
            btnOK.Location = new Point(465, 554);
            btnAnnuler.Location = new Point(576, 554);
            this.Height = 650;
        }
    }
}
