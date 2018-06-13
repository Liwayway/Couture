namespace Couture
{
    partial class frmAjoutTissu
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
            this.tbcAjoutTissu.SuspendLayout();
            this.gbxCommentaire.SuspendLayout();
            this.tbpPrincipal.SuspendLayout();
            this.tbpAvancees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxLaize
            // 
            this.cbxLaize.Location = new System.Drawing.Point(281, 206);
            // 
            // lblLaize
            // 
            this.lblLaize.Size = new System.Drawing.Size(61, 13);
            this.lblLaize.Text = "Laize (cm) :";
            // 
            // textBox2
            // 
            this.txtMetrage.Location = new System.Drawing.Point(534, 170);
            // 
            // lblMetrage
            // 
            this.lblMetrage.Size = new System.Drawing.Size(75, 13);
            this.lblMetrage.Text = "Métrage (cm) :";
            // 
            // btnOK
            // 
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmAjoutTissu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(713, 538);
            this.Name = "frmAjoutTissu";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmAjoutTissu_Load);
            this.tbcAjoutTissu.ResumeLayout(false);
            this.gbxCommentaire.ResumeLayout(false);
            this.gbxCommentaire.PerformLayout();
            this.tbpPrincipal.ResumeLayout(false);
            this.tbpPrincipal.PerformLayout();
            this.tbpAvancees.ResumeLayout(false);
            this.tbpAvancees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
