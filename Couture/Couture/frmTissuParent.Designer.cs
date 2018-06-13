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
            this.rbtnTisse = new System.Windows.Forms.RadioButton();
            this.rbtnMaille = new System.Windows.Forms.RadioButton();
            this.cbxLaize = new System.Windows.Forms.ComboBox();
            this.lblLaize = new System.Windows.Forms.Label();
            this.txtMetrage = new System.Windows.Forms.TextBox();
            this.lblMetrage = new System.Windows.Forms.Label();
            this.chkLave = new System.Windows.Forms.CheckBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.cbxCouleur = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxCommentaire.SuspendLayout();
            this.tbpAvancees.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcAjoutTissu
            // 
            this.tbcAjoutTissu.Controls.Add(this.tbpPrincipal);
            this.tbcAjoutTissu.Controls.Add(this.tbpAvancees);
            this.tbcAjoutTissu.Location = new System.Drawing.Point(12, 12);
            this.tbcAjoutTissu.Name = "tbcAjoutTissu";
            this.tbcAjoutTissu.SelectedIndex = 0;
            this.tbcAjoutTissu.Size = new System.Drawing.Size(689, 485);
            this.tbcAjoutTissu.TabIndex = 0;
            // 
            // tbpPrincipal
            // 
            this.tbpPrincipal.Controls.Add(this.lblPhotoInstruction);
            this.tbpPrincipal.Controls.Add(this.rbtnTisse);
            this.tbpPrincipal.Controls.Add(this.rbtnMaille);
            this.tbpPrincipal.Controls.Add(this.cbxLaize);
            this.tbpPrincipal.Controls.Add(this.lblLaize);
            this.tbpPrincipal.Controls.Add(this.txtMetrage);
            this.tbpPrincipal.Controls.Add(this.lblMetrage);
            this.tbpPrincipal.Controls.Add(this.chkLave);
            this.tbpPrincipal.Controls.Add(this.txtPrix);
            this.tbpPrincipal.Controls.Add(this.lblPrix);
            this.tbpPrincipal.Controls.Add(this.cbxCouleur);
            this.tbpPrincipal.Controls.Add(this.pictureBox1);
            this.tbpPrincipal.Controls.Add(this.lblCouleur);
            this.tbpPrincipal.Controls.Add(this.lblType);
            this.tbpPrincipal.Controls.Add(this.textBox1);
            this.tbpPrincipal.Controls.Add(this.lblProvenance);
            this.tbpPrincipal.Controls.Add(this.txtNom);
            this.tbpPrincipal.Controls.Add(this.lblNom);
            this.tbpPrincipal.Controls.Add(this.gbxCommentaire);
            this.tbpPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tbpPrincipal.Name = "tbpPrincipal";
            this.tbpPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPrincipal.Size = new System.Drawing.Size(681, 459);
            this.tbpPrincipal.TabIndex = 0;
            this.tbpPrincipal.Text = "Propriétés principales";
            this.tbpPrincipal.UseVisualStyleBackColor = true;
            // 
            // lblPhotoInstruction
            // 
            this.lblPhotoInstruction.AutoSize = true;
            this.lblPhotoInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotoInstruction.Location = new System.Drawing.Point(12, 162);
            this.lblPhotoInstruction.Name = "lblPhotoInstruction";
            this.lblPhotoInstruction.Size = new System.Drawing.Size(119, 26);
            this.lblPhotoInstruction.TabIndex = 36;
            this.lblPhotoInstruction.Text = "Double-cliquer \r\npour importer une photo";
            // 
            // rbtnTisse
            // 
            this.rbtnTisse.AutoSize = true;
            this.rbtnTisse.Location = new System.Drawing.Point(438, 101);
            this.rbtnTisse.Name = "rbtnTisse";
            this.rbtnTisse.Size = new System.Drawing.Size(50, 17);
            this.rbtnTisse.TabIndex = 35;
            this.rbtnTisse.TabStop = true;
            this.rbtnTisse.Text = "Tissé";
            this.rbtnTisse.UseVisualStyleBackColor = true;
            // 
            // rbtnMaille
            // 
            this.rbtnMaille.AutoSize = true;
            this.rbtnMaille.Location = new System.Drawing.Point(323, 101);
            this.rbtnMaille.Name = "rbtnMaille";
            this.rbtnMaille.Size = new System.Drawing.Size(90, 17);
            this.rbtnMaille.TabIndex = 34;
            this.rbtnMaille.TabStop = true;
            this.rbtnMaille.Text = "Maille (tricoté)";
            this.rbtnMaille.UseVisualStyleBackColor = true;
            // 
            // cbxLaize
            // 
            this.cbxLaize.FormattingEnabled = true;
            this.cbxLaize.Location = new System.Drawing.Point(258, 206);
            this.cbxLaize.Name = "cbxLaize";
            this.cbxLaize.Size = new System.Drawing.Size(121, 21);
            this.cbxLaize.TabIndex = 33;
            this.cbxLaize.SelectedIndexChanged += new System.EventHandler(this.cbxLaize_SelectedIndexChanged);
            // 
            // lblLaize
            // 
            this.lblLaize.AutoSize = true;
            this.lblLaize.Location = new System.Drawing.Point(214, 209);
            this.lblLaize.Name = "lblLaize";
            this.lblLaize.Size = new System.Drawing.Size(38, 13);
            this.lblLaize.TabIndex = 32;
            this.lblLaize.Text = "Laize :";
            this.lblLaize.Click += new System.EventHandler(this.lblLaize_Click);
            // 
            // txtMetrage
            // 
            this.txtMetrage.Location = new System.Drawing.Point(511, 170);
            this.txtMetrage.Name = "txtMetrage";
            this.txtMetrage.Size = new System.Drawing.Size(100, 20);
            this.txtMetrage.TabIndex = 31;
            // 
            // lblMetrage
            // 
            this.lblMetrage.AutoSize = true;
            this.lblMetrage.Location = new System.Drawing.Point(453, 173);
            this.lblMetrage.Name = "lblMetrage";
            this.lblMetrage.Size = new System.Drawing.Size(52, 13);
            this.lblMetrage.TabIndex = 30;
            this.lblMetrage.Text = "Métrage :";
            // 
            // chkLave
            // 
            this.chkLave.AutoSize = true;
            this.chkLave.Location = new System.Drawing.Point(217, 248);
            this.chkLave.Name = "chkLave";
            this.chkLave.Size = new System.Drawing.Size(236, 17);
            this.chkLave.TabIndex = 29;
            this.chkLave.Text = "Le tissu a été lavé une première fois (décati).";
            this.chkLave.UseVisualStyleBackColor = true;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(323, 170);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(100, 20);
            this.txtPrix.TabIndex = 28;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(214, 173);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(74, 13);
            this.lblPrix.TabIndex = 27;
            this.lblPrix.Text = "Prix au mètre :";
            // 
            // cbxCouleur
            // 
            this.cbxCouleur.FormattingEnabled = true;
            this.cbxCouleur.Location = new System.Drawing.Point(323, 135);
            this.cbxCouleur.Name = "cbxCouleur";
            this.cbxCouleur.Size = new System.Drawing.Size(121, 21);
            this.cbxCouleur.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Location = new System.Drawing.Point(214, 138);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(103, 13);
            this.lblCouleur.TabIndex = 25;
            this.lblCouleur.Text = "Couleur Dominante :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(214, 101);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(76, 13);
            this.lblType.TabIndex = 24;
            this.lblType.Text = "Type de tissu :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 20);
            this.textBox1.TabIndex = 23;
            // 
            // lblProvenance
            // 
            this.lblProvenance.AutoSize = true;
            this.lblProvenance.Location = new System.Drawing.Point(214, 61);
            this.lblProvenance.Name = "lblProvenance";
            this.lblProvenance.Size = new System.Drawing.Size(71, 13);
            this.lblProvenance.TabIndex = 22;
            this.lblProvenance.Text = "Provenance :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(284, 29);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(338, 20);
            this.txtNom.TabIndex = 21;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(214, 32);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 19;
            this.lblNom.Text = "Nom :";
            // 
            // gbxCommentaire
            // 
            this.gbxCommentaire.Controls.Add(this.txtCommentaire);
            this.gbxCommentaire.Location = new System.Drawing.Point(6, 284);
            this.gbxCommentaire.Name = "gbxCommentaire";
            this.gbxCommentaire.Size = new System.Drawing.Size(663, 164);
            this.gbxCommentaire.TabIndex = 11;
            this.gbxCommentaire.TabStop = false;
            this.gbxCommentaire.Text = "Commentaire";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(6, 19);
            this.txtCommentaire.MaxLength = 1000;
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(651, 138);
            this.txtCommentaire.TabIndex = 8;
            // 
            // tbpAvancees
            // 
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
            this.tbpAvancees.Location = new System.Drawing.Point(4, 22);
            this.tbpAvancees.Name = "tbpAvancees";
            this.tbpAvancees.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAvancees.Size = new System.Drawing.Size(681, 459);
            this.tbpAvancees.TabIndex = 1;
            this.tbpAvancees.Text = "Propriétés avancées";
            this.tbpAvancees.UseVisualStyleBackColor = true;
            // 
            // cbxMatierePrincipale
            // 
            this.cbxMatierePrincipale.FormattingEnabled = true;
            this.cbxMatierePrincipale.Location = new System.Drawing.Point(129, 47);
            this.cbxMatierePrincipale.Name = "cbxMatierePrincipale";
            this.cbxMatierePrincipale.Size = new System.Drawing.Size(121, 21);
            this.cbxMatierePrincipale.TabIndex = 14;
            // 
            // lblMatiere
            // 
            this.lblMatiere.AutoSize = true;
            this.lblMatiere.Location = new System.Drawing.Point(27, 50);
            this.lblMatiere.Name = "lblMatiere";
            this.lblMatiere.Size = new System.Drawing.Size(96, 13);
            this.lblMatiere.TabIndex = 13;
            this.lblMatiere.Text = "Matière principale :";
            // 
            // lblElasticite
            // 
            this.lblElasticite.AutoSize = true;
            this.lblElasticite.Location = new System.Drawing.Point(323, 50);
            this.lblElasticite.Name = "lblElasticite";
            this.lblElasticite.Size = new System.Drawing.Size(55, 13);
            this.lblElasticite.TabIndex = 11;
            this.lblElasticite.Text = "Elasticité :";
            // 
            // txtElasticite
            // 
            this.txtElasticite.Location = new System.Drawing.Point(390, 47);
            this.txtElasticite.Name = "txtElasticite";
            this.txtElasticite.Size = new System.Drawing.Size(100, 20);
            this.txtElasticite.TabIndex = 12;
            // 
            // lblDensite
            // 
            this.lblDensite.AutoSize = true;
            this.lblDensite.Location = new System.Drawing.Point(329, 87);
            this.lblDensite.Name = "lblDensite";
            this.lblDensite.Size = new System.Drawing.Size(49, 13);
            this.lblDensite.TabIndex = 5;
            this.lblDensite.Text = "Densité :";
            // 
            // txtDensite
            // 
            this.txtDensite.Location = new System.Drawing.Point(390, 84);
            this.txtDensite.Name = "txtDensite";
            this.txtDensite.Size = new System.Drawing.Size(100, 20);
            this.txtDensite.TabIndex = 6;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(62, 125);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(61, 13);
            this.lblCategorie.TabIndex = 10;
            this.lblCategorie.Text = "Catégorie : ";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(84, 87);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(39, 13);
            this.lblMotif.TabIndex = 7;
            this.lblMotif.Text = "Motif : ";
            // 
            // cbxCategorie
            // 
            this.cbxCategorie.FormattingEnabled = true;
            this.cbxCategorie.Location = new System.Drawing.Point(129, 122);
            this.cbxCategorie.Name = "cbxCategorie";
            this.cbxCategorie.Size = new System.Drawing.Size(121, 21);
            this.cbxCategorie.TabIndex = 9;
            this.cbxCategorie.SelectedIndexChanged += new System.EventHandler(this.cbxCategorie_SelectedIndexChanged);
            // 
            // cbxMotif
            // 
            this.cbxMotif.FormattingEnabled = true;
            this.cbxMotif.Location = new System.Drawing.Point(129, 84);
            this.cbxMotif.Name = "cbxMotif";
            this.cbxMotif.Size = new System.Drawing.Size(121, 21);
            this.cbxMotif.TabIndex = 8;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(622, 503);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(541, 503);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // frmTissuParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 538);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.tbcAjoutTissu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTissuParent";
            this.Text = "frmTissuParent";
            this.Load += new System.EventHandler(this.FrmParentTissuTabControl_Load);
            this.tbcAjoutTissu.ResumeLayout(false);
            this.tbpPrincipal.ResumeLayout(false);
            this.tbpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        protected System.Windows.Forms.RadioButton rbtnTisse;
        protected System.Windows.Forms.RadioButton rbtnMaille;
        protected System.Windows.Forms.ComboBox cbxLaize;
        protected System.Windows.Forms.Label lblLaize;
        protected System.Windows.Forms.TextBox txtMetrage;
        protected System.Windows.Forms.Label lblMetrage;
        protected System.Windows.Forms.CheckBox chkLave;
        protected System.Windows.Forms.TextBox txtPrix;
        protected System.Windows.Forms.Label lblPrix;
        protected System.Windows.Forms.ComboBox cbxCouleur;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Label lblCouleur;
        protected System.Windows.Forms.Label lblType;
        protected System.Windows.Forms.TextBox textBox1;
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
        protected System.Windows.Forms.ComboBox cbxMatierePrincipale;
        protected System.Windows.Forms.ComboBox cbxCategorie;
        protected System.Windows.Forms.ComboBox cbxMotif;
    }
}