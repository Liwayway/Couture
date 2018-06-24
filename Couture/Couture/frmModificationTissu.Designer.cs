namespace Couture
{
    partial class frmModificationTissu
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
            ((System.ComponentModel.ISupportInitialize)(this.picTissu)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpAvancees
            // 
            this.tbpAvancees.BackColor = System.Drawing.Color.Transparent;
            this.tbpAvancees.UseVisualStyleBackColor = false;
            // 
            // frmModificationTissu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(831, 621);
            this.Name = "frmModificationTissu";
            this.tbcAjoutTissu.ResumeLayout(false);
            this.gbxCommentaire.ResumeLayout(false);
            this.gbxCommentaire.PerformLayout();
            this.tbpPrincipal.ResumeLayout(false);
            this.tbpPrincipal.PerformLayout();
            this.tbpAvancees.ResumeLayout(false);
            this.tbpAvancees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTissu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
