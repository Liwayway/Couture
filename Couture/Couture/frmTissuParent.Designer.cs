namespace Couture
{
    partial class frmTissuParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTissuParent));
            this.tbcAjoutTissu = new System.Windows.Forms.TabControl();
            this.tbpPrincipal = new System.Windows.Forms.TabPage();
            this.lblPhotoInstruction = new System.Windows.Forms.Label();
            this.cbxLaize = new System.Windows.Forms.ComboBox();
            this.lblLaize = new System.Windows.Forms.Label();
            this.txtMetrage = new System.Windows.Forms.TextBox();
            this.lblMetrage = new System.Windows.Forms.Label();
            this.chkLave = new System.Windows.Forms.CheckBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.cbxCouleur = new System.Windows.Forms.ComboBox();
            this.picTissu = new System.Windows.Forms.PictureBox();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.txtProvenance = new System.Windows.Forms.TextBox();
            this.lblProvenance = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.gbxCommentaire = new System.Windows.Forms.GroupBox();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.tbpAvancees = new System.Windows.Forms.TabPage();
            this.cbxMatierePrincipale = new System.Windows.Forms.ComboBox();
            this.lblMatiere = new System.Windows.Forms.Label();
            this.lblElasticite = new System.Windows.Forms.Label();
            this.txtElasticite = new System.Windows.Forms.TextBox();
            this.lblDensite = new System.Windows.Forms.Label();
            this.txtDensite = new System.Windows.Forms.TextBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.cbxCategorie = new System.Windows.Forms.ComboBox();
            this.cbxMotif = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbcAjoutTissu.SuspendLayout();
            this.tbpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTissu)).BeginInit();
            this.gbxCommentaire.SuspendLayout();
            this.tbpAvancees.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcAjoutTissu
            // 
            this.tbcAjoutTissu.Controls.Add(this.tbpPrincipal);
            this.tbcAjoutTissu.Controls.Add(this.tbpAvancees);
            this.tbcAjoutTissu.Font = new System.Drawing.Font("Georgina", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcAjoutTissu.Location = new System.Drawing.Point(14, 14);
            this.tbcAjoutTissu.Name = "tbcAjoutTissu";
            this.tbcAjoutTissu.SelectedIndex = 0;
            this.tbcAjoutTissu.Size = new System.Drawing.Size(803, 560);
            this.tbcAjoutTissu.TabIndex = 0;
            // 
            // tbpPrincipal
            // 
            this.tbpPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.tbpPrincipal.Controls.Add(this.lblPhotoInstruction);
            this.tbpPrincipal.Controls.Add(this.cbxLaize);
            this.tbpPrincipal.Controls.Add(this.lblLaize);
            this.tbpPrincipal.Controls.Add(this.txtMetrage);
            this.tbpPrincipal.Controls.Add(this.lblMetrage);
            this.tbpPrincipal.Controls.Add(this.chkLave);
            this.tbpPrincipal.Controls.Add(this.txtPrix);
            this.tbpPrincipal.Controls.Add(this.lblPrix);
            this.tbpPrincipal.Controls.Add(this.cbxCouleur);
            this.tbpPrincipal.Controls.Add(this.picTissu);
            this.tbpPrincipal.Controls.Add(this.lblCouleur);
            this.tbpPrincipal.Controls.Add(this.txtProvenance);
            this.tbpPrincipal.Controls.Add(this.lblProvenance);
            this.tbpPrincipal.Controls.Add(this.txtNom);
            this.tbpPrincipal.Controls.Add(this.lblNom);
            this.tbpPrincipal.Controls.Add(this.gbxCommentaire);
            this.tbpPrincipal.Font = new System.Drawing.Font("Georgina", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpPrincipal.Location = new System.Drawing.Point(4, 34);
            this.tbpPrincipal.Name = "tbpPrincipal";
            this.tbpPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPrincipal.Size = new System.Drawing.Size(795, 522);
            this.tbpPrincipal.TabIndex = 0;
            this.tbpPrincipal.Text = "Propriétés principales";
            // 
            // lblPhotoInstruction
            // 
            this.lblPhotoInstruction.AutoSize = true;
            this.lblPhotoInstruction.Font = new System.Drawing.Font("Georgina", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotoInstruction.Location = new System.Drawing.Point(14, 187);
            this.lblPhotoInstruction.Name = "lblPhotoInstruction";
            this.lblPhotoInstruction.Size = new System.Drawing.Size(152, 48);
            this.lblPhotoInstruction.TabIndex = 36;
            this.lblPhotoInstruction.Text = "Double-cliquer \r\npour importer une photo";
            // 
            // cbxLaize
            // 
            this.cbxLaize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLaize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxLaize.FormattingEnabled = true;
            this.cbxLaize.Location = new System.Drawing.Point(343, 238);
            this.cbxLaize.Name = "cbxLaize";
            this.cbxLaize.Size = new System.Drawing.Size(140, 32);
            this.cbxLaize.TabIndex = 33;
            this.cbxLaize.SelectedIndexChanged += new System.EventHandler(this.cbxLaize_SelectedIndexChanged);
            // 
            // lblLaize
            // 
            this.lblLaize.AutoSize = true;
            this.lblLaize.Location = new System.Drawing.Point(250, 241);
            this.lblLaize.Name = "lblLaize";
            this.lblLaize.Size = new System.Drawing.Size(75, 24);
            this.lblLaize.TabIndex = 32;
            this.lblLaize.Text = "Laize (cm) :";
            this.lblLaize.Click += new System.EventHandler(this.lblLaize_Click);
            // 
            // txtMetrage
            // 
            this.txtMetrage.Location = new System.Drawing.Point(664, 196);
            this.txtMetrage.Name = "txtMetrage";
            this.txtMetrage.Size = new System.Drawing.Size(116, 32);
            this.txtMetrage.TabIndex = 31;
            // 
            // lblMetrage
            // 
            this.lblMetrage.AutoSize = true;
            this.lblMetrage.Location = new System.Drawing.Point(555, 199);
            this.lblMetrage.Name = "lblMetrage";
            this.lblMetrage.Size = new System.Drawing.Size(95, 24);
            this.lblMetrage.TabIndex = 30;
            this.lblMetrage.Text = "Métrage (cm) :";
            // 
            // chkLave
            // 
            this.chkLave.AutoSize = true;
            this.chkLave.Location = new System.Drawing.Point(254, 286);
            this.chkLave.Name = "chkLave";
            this.chkLave.Size = new System.Drawing.Size(285, 28);
            this.chkLave.TabIndex = 29;
            this.chkLave.Text = "Le tissu a été lavé une première fois (décati).";
            this.chkLave.UseVisualStyleBackColor = true;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(396, 196);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(126, 32);
            this.txtPrix.TabIndex = 28;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(250, 200);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(119, 24);
            this.lblPrix.TabIndex = 27;
            this.lblPrix.Text = "Prix au mètre (€)  :";
            // 
            // cbxCouleur
            // 
            this.cbxCouleur.FormattingEnabled = true;
            this.cbxCouleur.Location = new System.Drawing.Point(396, 156);
            this.cbxCouleur.Name = "cbxCouleur";
            this.cbxCouleur.Size = new System.Drawing.Size(140, 32);
            this.cbxCouleur.TabIndex = 26;
            this.cbxCouleur.SelectedIndexChanged += new System.EventHandler(this.cbxCouleur_SelectedIndexChanged);
            // 
            // picTissu
            // 
            this.picTissu.Image = ((System.Drawing.Image)(resources.GetObject("picTissu.Image")));
            this.picTissu.Location = new System.Drawing.Point(17, 36);
            this.picTissu.Name = "picTissu";
            this.picTissu.Size = new System.Drawing.Size(149, 148);
            this.picTissu.TabIndex = 20;
            this.picTissu.TabStop = false;
            this.picTissu.Click += new System.EventHandler(this.picTissu_Click);
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Location = new System.Drawing.Point(250, 159);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(130, 24);
            this.lblCouleur.TabIndex = 25;
            this.lblCouleur.Text = "Couleur Dominante :";
            // 
            // txtProvenance
            // 
            this.txtProvenance.Location = new System.Drawing.Point(343, 71);
            this.txtProvenance.Name = "txtProvenance";
            this.txtProvenance.Size = new System.Drawing.Size(394, 32);
            this.txtProvenance.TabIndex = 23;
            // 
            // lblProvenance
            // 
            this.lblProvenance.AutoSize = true;
            this.lblProvenance.Location = new System.Drawing.Point(250, 74);
            this.lblProvenance.Name = "lblProvenance";
            this.lblProvenance.Size = new System.Drawing.Size(84, 24);
            this.lblProvenance.TabIndex = 22;
            this.lblProvenance.Text = "Provenance :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(331, 33);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(394, 32);
            this.txtNom.TabIndex = 21;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(250, 37);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 24);
            this.lblNom.TabIndex = 19;
            this.lblNom.Text = "Nom :";
            // 
            // gbxCommentaire
            // 
            this.gbxCommentaire.Controls.Add(this.txtCommentaire);
            this.gbxCommentaire.Location = new System.Drawing.Point(7, 328);
            this.gbxCommentaire.Name = "gbxCommentaire";
            this.gbxCommentaire.Size = new System.Drawing.Size(773, 189);
            this.gbxCommentaire.TabIndex = 11;
            this.gbxCommentaire.TabStop = false;
            this.gbxCommentaire.Text = "Commentaire";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(7, 22);
            this.txtCommentaire.MaxLength = 1000;
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(758, 159);
            this.txtCommentaire.TabIndex = 8;
            // 
            // tbpAvancees
            // 
            this.tbpAvancees.BackColor = System.Drawing.Color.Transparent;
            this.tbpAvancees.Controls.Add(this.cbxMatierePrincipale);
            this.tbpAvancees.Controls.Add(this.lblMatiere);
            this.tbpAvancees.Controls.Add(this.lblElasticite);
            this.tbpAvancees.Controls.Add(this.txtElasticite);
            this.tbpAvancees.Controls.Add(this.lblDensite);
            this.tbpAvancees.Controls.Add(this.txtDensite);
            this.tbpAvancees.Controls.Add(this.lblCategorie);
            this.tbpAvancees.Controls.Add(this.lblMotif);
            this.tbpAvancees.Controls.Add(this.cbxCategorie);
            this.tbpAvancees.Controls.Add(this.cbxMotif);
            this.tbpAvancees.Location = new System.Drawing.Point(4, 34);
            this.tbpAvancees.Name = "tbpAvancees";
            this.tbpAvancees.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAvancees.Size = new System.Drawing.Size(795, 522);
            this.tbpAvancees.TabIndex = 1;
            this.tbpAvancees.Text = "Propriétés avancées";
            // 
            // cbxMatierePrincipale
            // 
            this.cbxMatierePrincipale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMatierePrincipale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMatierePrincipale.FormattingEnabled = true;
            this.cbxMatierePrincipale.Location = new System.Drawing.Point(157, 54);
            this.cbxMatierePrincipale.Name = "cbxMatierePrincipale";
            this.cbxMatierePrincipale.Size = new System.Drawing.Size(140, 32);
            this.cbxMatierePrincipale.TabIndex = 14;
            this.cbxMatierePrincipale.SelectedIndexChanged += new System.EventHandler(this.cbxMatierePrincipale_SelectedIndexChanged);
            // 
            // lblMatiere
            // 
            this.lblMatiere.AutoSize = true;
            this.lblMatiere.Location = new System.Drawing.Point(31, 58);
            this.lblMatiere.Name = "lblMatiere";
            this.lblMatiere.Size = new System.Drawing.Size(126, 24);
            this.lblMatiere.TabIndex = 13;
            this.lblMatiere.Text = "Matière principale :";
            // 
            // lblElasticite
            // 
            this.lblElasticite.AutoSize = true;
            this.lblElasticite.Location = new System.Drawing.Point(376, 58);
            this.lblElasticite.Name = "lblElasticite";
            this.lblElasticite.Size = new System.Drawing.Size(106, 24);
            this.lblElasticite.TabIndex = 11;
            this.lblElasticite.Text = "Elasticité (en %) :";
            // 
            // txtElasticite
            // 
            this.txtElasticite.Location = new System.Drawing.Point(499, 54);
            this.txtElasticite.Name = "txtElasticite";
            this.txtElasticite.Size = new System.Drawing.Size(116, 32);
            this.txtElasticite.TabIndex = 12;
            // 
            // lblDensite
            // 
            this.lblDensite.AutoSize = true;
            this.lblDensite.Location = new System.Drawing.Point(383, 100);
            this.lblDensite.Name = "lblDensite";
            this.lblDensite.Size = new System.Drawing.Size(97, 24);
            this.lblDensite.TabIndex = 5;
            this.lblDensite.Text = "Densité (g/m²) :";
            // 
            // txtDensite
            // 
            this.txtDensite.Location = new System.Drawing.Point(499, 97);
            this.txtDensite.Name = "txtDensite";
            this.txtDensite.Size = new System.Drawing.Size(116, 32);
            this.txtDensite.TabIndex = 6;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(72, 144);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(75, 24);
            this.lblCategorie.TabIndex = 10;
            this.lblCategorie.Text = "Catégorie : ";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(98, 100);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(53, 24);
            this.lblMotif.TabIndex = 7;
            this.lblMotif.Text = "Motif : ";
            // 
            // cbxCategorie
            // 
            this.cbxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCategorie.FormattingEnabled = true;
            this.cbxCategorie.Location = new System.Drawing.Point(157, 141);
            this.cbxCategorie.Name = "cbxCategorie";
            this.cbxCategorie.Size = new System.Drawing.Size(140, 32);
            this.cbxCategorie.TabIndex = 9;
            this.cbxCategorie.SelectedIndexChanged += new System.EventHandler(this.cbxCategorie_SelectedIndexChanged);
            // 
            // cbxMotif
            // 
            this.cbxMotif.FormattingEnabled = true;
            this.cbxMotif.Location = new System.Drawing.Point(157, 97);
            this.cbxMotif.Name = "cbxMotif";
            this.cbxMotif.Size = new System.Drawing.Size(140, 32);
            this.cbxMotif.TabIndex = 8;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Font = new System.Drawing.Font("Georgina", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(726, 580);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(87, 27);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Georgina", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(632, 580);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 27);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmTissuParent
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(831, 621);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.tbcAjoutTissu);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTissuParent";
            this.Text = "frmTissuParent";
            this.Load += new System.EventHandler(this.FrmParentTissuTabControl_Load);
            this.tbcAjoutTissu.ResumeLayout(false);
            this.tbpPrincipal.ResumeLayout(false);
            this.tbpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTissu)).EndInit();
            this.gbxCommentaire.ResumeLayout(false);
            this.gbxCommentaire.PerformLayout();
            this.tbpAvancees.ResumeLayout(false);
            this.tbpAvancees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.TabControl tbcAjoutTissu;
        protected System.Windows.Forms.GroupBox gbxCommentaire;
        protected System.Windows.Forms.TextBox txtCommentaire;
        protected System.Windows.Forms.TabPage tbpPrincipal;
        protected System.Windows.Forms.TabPage tbpAvancees;
        protected System.Windows.Forms.Label lblLaize;
        protected System.Windows.Forms.TextBox txtMetrage;
        protected System.Windows.Forms.Label lblMetrage;
        protected System.Windows.Forms.CheckBox chkLave;
        protected System.Windows.Forms.TextBox txtPrix;
        protected System.Windows.Forms.Label lblPrix;
        protected System.Windows.Forms.PictureBox picTissu;
        protected System.Windows.Forms.Label lblCouleur;
        protected System.Windows.Forms.TextBox txtProvenance;
        protected System.Windows.Forms.Label lblProvenance;
        protected System.Windows.Forms.TextBox txtNom;
        protected System.Windows.Forms.Label lblNom;
        protected System.Windows.Forms.Label lblMatiere;
        protected System.Windows.Forms.Label lblElasticite;
        protected System.Windows.Forms.TextBox txtElasticite;
        protected System.Windows.Forms.Label lblDensite;
        protected System.Windows.Forms.TextBox txtDensite;
        protected System.Windows.Forms.Label lblCategorie;
        protected System.Windows.Forms.Label lblMotif;
        protected System.Windows.Forms.Button btnAnnuler;
        protected System.Windows.Forms.Button btnOK;
        protected System.Windows.Forms.Label lblPhotoInstruction;
        internal System.Windows.Forms.ComboBox cbxLaize;
        internal System.Windows.Forms.ComboBox cbxCouleur;
        internal System.Windows.Forms.ComboBox cbxMatierePrincipale;
        internal System.Windows.Forms.ComboBox cbxCategorie;
        internal System.Windows.Forms.ComboBox cbxMotif;
    }
}