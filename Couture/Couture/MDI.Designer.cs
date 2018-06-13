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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.affichageToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnTissuToolStripMenuItem,
            this.ajouterUnProjetToolStripMenuItem,
            this.ajouterUnTissuToolStripMenuItem1,
            this.consultationTissuToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ajouterUnTissuToolStripMenuItem
            // 
            this.ajouterUnTissuToolStripMenuItem.Name = "ajouterUnTissuToolStripMenuItem";
            this.ajouterUnTissuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterUnTissuToolStripMenuItem.Text = "Ajouter un tissu";
            this.ajouterUnTissuToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnTissuToolStripMenuItem_Click);
            // 
            // ajouterUnProjetToolStripMenuItem
            // 
            this.ajouterUnProjetToolStripMenuItem.Name = "ajouterUnProjetToolStripMenuItem";
            this.ajouterUnProjetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterUnProjetToolStripMenuItem.Text = "Ajouter un projet";
            this.ajouterUnProjetToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnProjetToolStripMenuItem_Click);
            // 
            // ajouterUnTissuToolStripMenuItem1
            // 
            this.ajouterUnTissuToolStripMenuItem1.Name = "ajouterUnTissuToolStripMenuItem1";
            this.ajouterUnTissuToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ajouterUnTissuToolStripMenuItem1.Text = "Ajouter un patron";
            // 
            // consultationTissuToolStripMenuItem
            // 
            this.consultationTissuToolStripMenuItem.Name = "consultationTissuToolStripMenuItem";
            this.consultationTissuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultationTissuToolStripMenuItem.Text = "Consultation Tissu";
            this.consultationTissuToolStripMenuItem.Click += new System.EventHandler(this.consultationTissuToolStripMenuItem_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesTissusToolStripMenuItem,
            this.listeDesProjetsToolStripMenuItem,
            this.listeDesPatronsToolStripMenuItem});
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // listeDesTissusToolStripMenuItem
            // 
            this.listeDesTissusToolStripMenuItem.Name = "listeDesTissusToolStripMenuItem";
            this.listeDesTissusToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listeDesTissusToolStripMenuItem.Text = "Liste des tissus";
            this.listeDesTissusToolStripMenuItem.Click += new System.EventHandler(this.listeDesTissusToolStripMenuItem_Click);
            // 
            // listeDesProjetsToolStripMenuItem
            // 
            this.listeDesProjetsToolStripMenuItem.Name = "listeDesProjetsToolStripMenuItem";
            this.listeDesProjetsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listeDesProjetsToolStripMenuItem.Text = "Liste des projets";
            this.listeDesProjetsToolStripMenuItem.Click += new System.EventHandler(this.listeDesProjetsToolStripMenuItem_Click);
            // 
            // listeDesPatronsToolStripMenuItem
            // 
            this.listeDesPatronsToolStripMenuItem.Name = "listeDesPatronsToolStripMenuItem";
            this.listeDesPatronsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listeDesPatronsToolStripMenuItem.Text = "Liste des patrons";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 263);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMDI";
            this.Text = "Ecole Chiffon Dort";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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

