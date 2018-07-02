namespace Couture
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.msMDI = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnTissuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnProjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnTissuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationTissuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesTissusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesProjetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesPatronsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMDI
            // 
            this.msMDI.BackColor = System.Drawing.Color.Gainsboro;
            this.msMDI.Font = new System.Drawing.Font("Georgina", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.affichageToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.msMDI.Location = new System.Drawing.Point(0, 0);
            this.msMDI.Name = "msMDI";
            this.msMDI.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.msMDI.Size = new System.Drawing.Size(958, 31);
            this.msMDI.TabIndex = 1;
            this.msMDI.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnTissuToolStripMenuItem,
            this.ajouterUnProjetToolStripMenuItem,
            this.ajouterUnTissuToolStripMenuItem1,
            this.consultationTissuToolStripMenuItem});
            this.fichierToolStripMenuItem.Font = new System.Drawing.Font("Georgina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ajouterUnTissuToolStripMenuItem
            // 
            this.ajouterUnTissuToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.ajouterUnTissuToolStripMenuItem.Font = new System.Drawing.Font("Georgina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterUnTissuToolStripMenuItem.Name = "ajouterUnTissuToolStripMenuItem";
            this.ajouterUnTissuToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.ajouterUnTissuToolStripMenuItem.Text = "Ajouter un tissu";
            this.ajouterUnTissuToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnTissuToolStripMenuItem_Click);
            // 
            // ajouterUnProjetToolStripMenuItem
            // 
            this.ajouterUnProjetToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.ajouterUnProjetToolStripMenuItem.Font = new System.Drawing.Font("Georgina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterUnProjetToolStripMenuItem.Name = "ajouterUnProjetToolStripMenuItem";
            this.ajouterUnProjetToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.ajouterUnProjetToolStripMenuItem.Text = "Ajouter un projet";
            this.ajouterUnProjetToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnProjetToolStripMenuItem_Click);
            // 
            // ajouterUnTissuToolStripMenuItem1
            // 
            this.ajouterUnTissuToolStripMenuItem1.BackColor = System.Drawing.Color.Gainsboro;
            this.ajouterUnTissuToolStripMenuItem1.Font = new System.Drawing.Font("Georgina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterUnTissuToolStripMenuItem1.Name = "ajouterUnTissuToolStripMenuItem1";
            this.ajouterUnTissuToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.ajouterUnTissuToolStripMenuItem1.Text = "Ajouter un patron";
            // 
            // consultationTissuToolStripMenuItem
            // 
            this.consultationTissuToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.consultationTissuToolStripMenuItem.Font = new System.Drawing.Font("Georgina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultationTissuToolStripMenuItem.Name = "consultationTissuToolStripMenuItem";
            this.consultationTissuToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.consultationTissuToolStripMenuItem.Text = "Consultation Tissu";
            this.consultationTissuToolStripMenuItem.Click += new System.EventHandler(this.consultationTissuToolStripMenuItem_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesTissusToolStripMenuItem,
            this.listeDesProjetsToolStripMenuItem,
            this.listeDesPatronsToolStripMenuItem});
            this.affichageToolStripMenuItem.Font = new System.Drawing.Font("Georgina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // listeDesTissusToolStripMenuItem
            // 
            this.listeDesTissusToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.listeDesTissusToolStripMenuItem.Name = "listeDesTissusToolStripMenuItem";
            this.listeDesTissusToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.listeDesTissusToolStripMenuItem.Text = "Liste des tissus";
            this.listeDesTissusToolStripMenuItem.Click += new System.EventHandler(this.listeDesTissusToolStripMenuItem_Click);
            // 
            // listeDesProjetsToolStripMenuItem
            // 
            this.listeDesProjetsToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.listeDesProjetsToolStripMenuItem.Name = "listeDesProjetsToolStripMenuItem";
            this.listeDesProjetsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.listeDesProjetsToolStripMenuItem.Text = "Liste des projets";
            this.listeDesProjetsToolStripMenuItem.Click += new System.EventHandler(this.listeDesProjetsToolStripMenuItem_Click);
            // 
            // listeDesPatronsToolStripMenuItem
            // 
            this.listeDesPatronsToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.listeDesPatronsToolStripMenuItem.Name = "listeDesPatronsToolStripMenuItem";
            this.listeDesPatronsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.listeDesPatronsToolStripMenuItem.Text = "Liste des patrons";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Font = new System.Drawing.Font("Georgina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 384);
            this.Controls.Add(this.msMDI);
            this.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMDI";
            this.Text = "Chiffon Dort";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.msMDI.ResumeLayout(false);
            this.msMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMDI;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnTissuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesTissusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesProjetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesPatronsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnProjetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnTissuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultationTissuToolStripMenuItem;
    }
}

