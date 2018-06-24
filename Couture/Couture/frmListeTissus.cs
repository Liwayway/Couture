﻿using System;
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
    public partial class frmListeTissus : Form
    {
        public frmListeTissus()
        {
            InitializeComponent();
            this.afficheTissus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAjoutTissu frmAjout = new frmAjoutTissu();
            // si on sort de la saisie par OK
            if (frmAjout.ShowDialog() == DialogResult.OK)
            {
                // régénèrer l'affichage du dataGridView 
                this.afficheTissus();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListeTissus_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// rétablit la source de données de la dataGridView
        /// et rafraîchit son affichage
        /// </summary>
        private void afficheTissus()
        {
            // déterminer l'origine des données à afficher : 
            // appel de la méthode de la classe MSection 
            // qui alimente et retourne copie de sa 
            // collection de stagiaires sous forme de datatable
            this.grdTissus.DataSource = MTissu.getDonneesTissus();
            // refraîchir l'affichage
            this.grdTissus.Refresh();

        }
    }
}
