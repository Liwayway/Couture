namespace Couture
{
    partial class frmConsultationTissu
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
            this.tbpListeProjets = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAjoutProjet = new System.Windows.Forms.Button();
            this.tbcAjoutTissu.SuspendLayout();
            this.gbxCommentaire.SuspendLayout();
            this.tbpPrincipal.SuspendLayout();
            this.tbpAvancees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbpListeProjets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcAjoutTissu
            // 
            this.tbcAjoutTissu.Controls.Add(this.tbpListeProjets);
            this.tbcAjoutTissu.Controls.SetChildIndex(this.tbpListeProjets, 0);
            this.tbcAjoutTissu.Controls.SetChildIndex(this.tbpAvancees, 0);
            this.tbcAjoutTissu.Controls.SetChildIndex(this.tbpPrincipal, 0);
            // 
            // tbpListeProjets
            // 
            this.tbpListeProjets.Controls.Add(this.dataGridView1);
            this.tbpListeProjets.Location = new System.Drawing.Point(4, 22);
            this.tbpListeProjets.Name = "tbpListeProjets";
            this.tbpListeProjets.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListeProjets.Size = new System.Drawing.Size(681, 459);
            this.tbpListeProjets.TabIndex = 2;
            this.tbpListeProjets.Text = "Projets associés au tissu";
            this.tbpListeProjets.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 430);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAjoutProjet
            // 
            this.btnAjoutProjet.Location = new System.Drawing.Point(392, 503);
            this.btnAjoutProjet.Name = "btnAjoutProjet";
            this.btnAjoutProjet.Size = new System.Drawing.Size(143, 23);
            this.btnAjoutProjet.TabIndex = 3;
            this.btnAjoutProjet.Text = "Ajouter un nouveau projet";
            this.btnAjoutProjet.UseVisualStyleBackColor = true;
            // 
            // frmConsultationTissu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(713, 538);
            this.Controls.Add(this.btnAjoutProjet);
            this.Name = "frmConsultationTissu";
            this.Text = "Détails du tissu";
            this.Controls.SetChildIndex(this.tbcAjoutTissu, 0);
            this.Controls.SetChildIndex(this.btnAnnuler, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnAjoutProjet, 0);
            this.tbcAjoutTissu.ResumeLayout(false);
            this.gbxCommentaire.ResumeLayout(false);
            this.gbxCommentaire.PerformLayout();
            this.tbpPrincipal.ResumeLayout(false);
            this.tbpPrincipal.PerformLayout();
            this.tbpAvancees.ResumeLayout(false);
            this.tbpAvancees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbpListeProjets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpListeProjets;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAjoutProjet;
    }
}
