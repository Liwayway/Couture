namespace Couture
{
    partial class frmAjoutProjet
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbpGalerie.SuspendLayout();
            this.tbcProjet.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpGalerie
            // 
            this.tbpGalerie.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbpGalerie.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbpGalerie.Size = new System.Drawing.Size(776, 613);
            // 
            // cbxHome
            // 
            this.cbxHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // cbxAccessoire
            // 
            this.cbxAccessoire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // cbxVetement
            // 
            this.cbxVetement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // tbcProjet
            // 
            this.tbcProjet.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbcProjet.Size = new System.Drawing.Size(784, 648);
            // 
            // textBox1
            // 
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox1.Size = new System.Drawing.Size(760, 116);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(776, 613);
            // 
            // txtNomProjet
            // 
            this.txtNomProjet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // btnAjoutTissu
            // 
            this.btnAjoutTissu.Click += new System.EventHandler(this.btnAjoutTissu_Click);
            // 
            // frmAjoutProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 672);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmAjoutProjet";
            this.Text = " Ajout d\'un nouveau projet";
            this.tbpGalerie.ResumeLayout(false);
            this.tbpGalerie.PerformLayout();
            this.tbcProjet.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
