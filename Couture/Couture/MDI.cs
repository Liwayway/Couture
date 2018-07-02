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
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterUnTissuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjoutTissu frmAjout = new frmAjoutTissu();
            // si on sort de la saisie par OK
            if (frmAjout.ShowDialog() == DialogResult.OK)
            {
                // régénèrer l'affichage du dataGridView 

            }
        }

        private void listeDesTissusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeTissus listeTissus = new frmListeTissus();
            listeTissus.Show();

        }

        private void listeDesProjetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeProjets listeProjets = new frmListeProjets();
            listeProjets.Show();
        }

        private void consultationTissuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultationTissu frmConsulter = new frmConsultationTissu();
            frmConsulter.Show();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {

        }

        private void ajouterUnProjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjoutProjet frmAjouterUnProjet = new frmAjoutProjet();
            if (frmAjouterUnProjet.ShowDialog() == DialogResult.OK)
            {
               



            }
        }
    }
}
