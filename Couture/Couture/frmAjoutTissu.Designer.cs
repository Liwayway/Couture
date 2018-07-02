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
            ((System.ComponentModel.ISupportInitialize)(this.picTissu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Size = new System.Drawing.Size(758, 153);
            // 
            // tbpPrincipal
            // 
            this.tbpPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // tbpAvancees
            // 
            this.tbpAvancees.Location = new System.Drawing.Point(4, 34);
            this.tbpAvancees.Size = new System.Drawing.Size(795, 522);
            // 
            // txtMetrage
            // 
            this.txtMetrage.Location = new System.Drawing.Point(664, 192);
            this.txtMetrage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetrage_KeyPress);
            // 
            // txtPrix
            // 
            this.txtPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrix_KeyPress);
            // 
            // picTissu
            // 
            this.picTissu.Click += new System.EventHandler(this.picTissu_Click);
            // 
            // txtElasticite
            // 
            this.txtElasticite.Location = new System.Drawing.Point(522, 54);
            // 
            // txtDensite
            // 
            this.txtDensite.Location = new System.Drawing.Point(522, 92);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnOK
            // 
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmAjoutTissu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(832, 621);
            this.Name = "frmAjoutTissu";
            this.Text = " Ajouter un nouveau tissu";
            this.Load += new System.EventHandler(this.frmAjoutTissu_Load);
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
