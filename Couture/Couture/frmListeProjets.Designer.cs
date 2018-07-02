namespace Couture
{
    partial class frmListeProjets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeProjets));
            this.dtgListeProjets = new System.Windows.Forms.DataGridView();
            this.txtRechercheProjet = new System.Windows.Forms.TextBox();
            this.lblRechercherProjet = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeProjets)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListeProjets
            // 
            this.dtgListeProjets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListeProjets.Location = new System.Drawing.Point(14, 120);
            this.dtgListeProjets.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dtgListeProjets.Name = "dtgListeProjets";
            this.dtgListeProjets.Size = new System.Drawing.Size(777, 275);
            this.dtgListeProjets.TabIndex = 0;
            // 
            // txtRechercheProjet
            // 
            this.txtRechercheProjet.Location = new System.Drawing.Point(122, 31);
            this.txtRechercheProjet.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtRechercheProjet.Name = "txtRechercheProjet";
            this.txtRechercheProjet.Size = new System.Drawing.Size(448, 32);
            this.txtRechercheProjet.TabIndex = 1;
            // 
            // lblRechercherProjet
            // 
            this.lblRechercherProjet.AutoSize = true;
            this.lblRechercherProjet.Location = new System.Drawing.Point(38, 37);
            this.lblRechercherProjet.Name = "lblRechercherProjet";
            this.lblRechercherProjet.Size = new System.Drawing.Size(81, 24);
            this.lblRechercherProjet.TabIndex = 2;
            this.lblRechercherProjet.Text = "Rechercher :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(609, 416);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(87, 42);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(704, 416);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(87, 42);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // frmListeProjets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 479);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblRechercherProjet);
            this.Controls.Add(this.txtRechercheProjet);
            this.Controls.Add(this.dtgListeProjets);
            this.Font = new System.Drawing.Font("Georgina", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmListeProjets";
            this.Text = "frmListeProjets";
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeProjets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataGridView dtgListeProjets;
        protected System.Windows.Forms.TextBox txtRechercheProjet;
        private System.Windows.Forms.Label lblRechercherProjet;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
    }
}