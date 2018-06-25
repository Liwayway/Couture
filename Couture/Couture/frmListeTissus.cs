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
            //Si un tissu est pointé dans la datagrid
            if (this.grdTissus.CurrentRow != null)
            {
                //Récupérer l'id du tissu
                long idTissu;
                idTissu = (Int64)this.grdTissus.CurrentRow.Cells[0].Value;
                //Récupérer le nom du tissu
                string nomTissu = (String)this.grdTissus.CurrentRow.Cells[1].Value;

                //Demander confirmation de la suppression
                if (MessageBox.Show("Voulez-vous supprimer ce tissu : \"" + nomTissu + "\" ?", "Suppression",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Faire appel à la méthode suppression de tissu
                    MTissu.DeleteTissu(idTissu);
                    //Réafficher la liste des tissus mise à jour
                    afficheTissus();

                }
            }

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
