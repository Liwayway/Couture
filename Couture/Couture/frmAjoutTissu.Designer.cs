namespace Couture
{
    partial class frmAjoutTissu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjoutTissu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxPrincipales = new System.Windows.Forms.GroupBox();
            this.chkLave = new System.Windows.Forms.CheckBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.cbxCouleur = new System.Windows.Forms.ComboBox();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblProvenance = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnAjoutProjet = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblMetrage = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDensite = new System.Windows.Forms.Label();
            this.lblLaize = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbtnMaille = new System.Windows.Forms.RadioButton();
            this.rbtnTisse = new System.Windows.Forms.RadioButton();
            this.txtDensite = new System.Windows.Forms.TextBox();
            this.gbxAvances = new System.Windows.Forms.GroupBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.cbxMotif = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblElasticite = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblMatiere = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.gbxCommentaire = new System.Windows.Forms.GroupBox();
            this.lklblAvances = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxPrincipales.SuspendLayout();
            this.gbxAvances.SuspendLayout();
            this.gbxCommentaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbxPrincipales
            // 
            this.gbxPrincipales.Controls.Add(this.lklblAvances);
            this.gbxPrincipales.Controls.Add(this.rbtnTisse);
            this.gbxPrincipales.Controls.Add(this.rbtnMaille);
            this.gbxPrincipales.Controls.Add(this.comboBox1);
            this.gbxPrincipales.Controls.Add(this.lblLaize);
            this.gbxPrincipales.Controls.Add(this.textBox2);
            this.gbxPrincipales.Controls.Add(this.lblMetrage);
            this.gbxPrincipales.Controls.Add(this.chkLave);
            this.gbxPrincipales.Controls.Add(this.txtPrix);
            this.gbxPrincipales.Controls.Add(this.lblPrix);
            this.gbxPrincipales.Controls.Add(this.cbxCouleur);
            this.gbxPrincipales.Controls.Add(this.pictureBox1);
            this.gbxPrincipales.Controls.Add(this.lblCouleur);
            this.gbxPrincipales.Controls.Add(this.lblType);
            this.gbxPrincipales.Controls.Add(this.textBox1);
            this.gbxPrincipales.Controls.Add(this.lblProvenance);
            this.gbxPrincipales.Controls.Add(this.txtNom);
            this.gbxPrincipales.Controls.Add(this.lblNom);
            this.gbxPrincipales.Location = new System.Drawing.Point(12, 30);
            this.gbxPrincipales.Name = "gbxPrincipales";
            this.gbxPrincipales.Size = new System.Drawing.Size(663, 335);
            this.gbxPrincipales.TabIndex = 1;
            this.gbxPrincipales.TabStop = false;
            this.gbxPrincipales.Text = "Caractéristiques principales";
            // 
            // chkLave
            // 
            this.chkLave.AutoSize = true;
            this.chkLave.Location = new System.Drawing.Point(174, 249);
            this.chkLave.Name = "chkLave";
            this.chkLave.Size = new System.Drawing.Size(236, 17);
            this.chkLave.TabIndex = 11;
            this.chkLave.Text = "Le tissu a été lavé une première fois (décati).";
            this.chkLave.UseVisualStyleBackColor = true;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(280, 171);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(100, 20);
            this.txtPrix.TabIndex = 10;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(171, 174);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(74, 13);
            this.lblPrix.TabIndex = 9;
            this.lblPrix.Text = "Prix au mètre :";
            // 
            // cbxCouleur
            // 
            this.cbxCouleur.FormattingEnabled = true;
            this.cbxCouleur.Location = new System.Drawing.Point(280, 136);
            this.cbxCouleur.Name = "cbxCouleur";
            this.cbxCouleur.Size = new System.Drawing.Size(121, 21);
            this.cbxCouleur.TabIndex = 8;
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Location = new System.Drawing.Point(171, 139);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(103, 13);
            this.lblCouleur.TabIndex = 7;
            this.lblCouleur.Text = "Couleur Dominante :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(171, 102);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(76, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type de tissu :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblProvenance
            // 
            this.lblProvenance.AutoSize = true;
            this.lblProvenance.Location = new System.Drawing.Point(171, 62);
            this.lblProvenance.Name = "lblProvenance";
            this.lblProvenance.Size = new System.Drawing.Size(71, 13);
            this.lblProvenance.TabIndex = 2;
            this.lblProvenance.Text = "Provenance :";
            this.lblProvenance.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(241, 30);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(338, 20);
            this.txtNom.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(171, 33);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // btnAjoutProjet
            // 
            this.btnAjoutProjet.Location = new System.Drawing.Point(358, 725);
            this.btnAjoutProjet.Name = "btnAjoutProjet";
            this.btnAjoutProjet.Size = new System.Drawing.Size(99, 40);
            this.btnAjoutProjet.TabIndex = 2;
            this.btnAjoutProjet.Text = "Ajouter un projet";
            this.btnAjoutProjet.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(465, 725);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 40);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(576, 725);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(99, 40);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // lblMetrage
            // 
            this.lblMetrage.AutoSize = true;
            this.lblMetrage.Location = new System.Drawing.Point(410, 174);
            this.lblMetrage.Name = "lblMetrage";
            this.lblMetrage.Size = new System.Drawing.Size(52, 13);
            this.lblMetrage.TabIndex = 13;
            this.lblMetrage.Text = "Métrage :";
            this.lblMetrage.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(468, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // lblDensite
            // 
            this.lblDensite.AutoSize = true;
            this.lblDensite.Location = new System.Drawing.Point(321, 69);
            this.lblDensite.Name = "lblDensite";
            this.lblDensite.Size = new System.Drawing.Size(49, 13);
            this.lblDensite.TabIndex = 5;
            this.lblDensite.Text = "Densité :";
            // 
            // lblLaize
            // 
            this.lblLaize.AutoSize = true;
            this.lblLaize.Location = new System.Drawing.Point(171, 210);
            this.lblLaize.Name = "lblLaize";
            this.lblLaize.Size = new System.Drawing.Size(38, 13);
            this.lblLaize.TabIndex = 15;
            this.lblLaize.Text = "Laize :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // rbtnMaille
            // 
            this.rbtnMaille.AutoSize = true;
            this.rbtnMaille.Location = new System.Drawing.Point(280, 102);
            this.rbtnMaille.Name = "rbtnMaille";
            this.rbtnMaille.Size = new System.Drawing.Size(90, 17);
            this.rbtnMaille.TabIndex = 17;
            this.rbtnMaille.TabStop = true;
            this.rbtnMaille.Text = "Maille (tricoté)";
            this.rbtnMaille.UseVisualStyleBackColor = true;
            // 
            // rbtnTisse
            // 
            this.rbtnTisse.AutoSize = true;
            this.rbtnTisse.Location = new System.Drawing.Point(395, 102);
            this.rbtnTisse.Name = "rbtnTisse";
            this.rbtnTisse.Size = new System.Drawing.Size(50, 17);
            this.rbtnTisse.TabIndex = 18;
            this.rbtnTisse.TabStop = true;
            this.rbtnTisse.Text = "Tissé";
            this.rbtnTisse.UseVisualStyleBackColor = true;
            // 
            // txtDensite
            // 
            this.txtDensite.Location = new System.Drawing.Point(382, 66);
            this.txtDensite.Name = "txtDensite";
            this.txtDensite.Size = new System.Drawing.Size(100, 20);
            this.txtDensite.TabIndex = 6;
            // 
            // gbxAvances
            // 
            this.gbxAvances.Controls.Add(this.comboBox2);
            this.gbxAvances.Controls.Add(this.lblMatiere);
            this.gbxAvances.Controls.Add(this.textBox3);
            this.gbxAvances.Controls.Add(this.lblElasticite);
            this.gbxAvances.Controls.Add(this.lblCategorie);
            this.gbxAvances.Controls.Add(this.comboBox3);
            this.gbxAvances.Controls.Add(this.cbxMotif);
            this.gbxAvances.Controls.Add(this.lblMotif);
            this.gbxAvances.Controls.Add(this.txtDensite);
            this.gbxAvances.Controls.Add(this.lblDensite);
            this.gbxAvances.Location = new System.Drawing.Point(12, 543);
            this.gbxAvances.Name = "gbxAvances";
            this.gbxAvances.Size = new System.Drawing.Size(663, 164);
            this.gbxAvances.TabIndex = 7;
            this.gbxAvances.TabStop = false;
            this.gbxAvances.Text = "Caractéristiques Avancées";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(76, 69);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(39, 13);
            this.lblMotif.TabIndex = 7;
            this.lblMotif.Text = "Motif : ";
            // 
            // cbxMotif
            // 
            this.cbxMotif.FormattingEnabled = true;
            this.cbxMotif.Location = new System.Drawing.Point(121, 66);
            this.cbxMotif.Name = "cbxMotif";
            this.cbxMotif.Size = new System.Drawing.Size(121, 21);
            this.cbxMotif.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(121, 104);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(54, 107);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(61, 13);
            this.lblCategorie.TabIndex = 10;
            this.lblCategorie.Text = "Catégorie : ";
            // 
            // lblElasticite
            // 
            this.lblElasticite.AutoSize = true;
            this.lblElasticite.Location = new System.Drawing.Point(315, 32);
            this.lblElasticite.Name = "lblElasticite";
            this.lblElasticite.Size = new System.Drawing.Size(55, 13);
            this.lblElasticite.TabIndex = 11;
            this.lblElasticite.Text = "Elasticité :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(382, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // lblMatiere
            // 
            this.lblMatiere.AutoSize = true;
            this.lblMatiere.Location = new System.Drawing.Point(19, 32);
            this.lblMatiere.Name = "lblMatiere";
            this.lblMatiere.Size = new System.Drawing.Size(96, 13);
            this.lblMatiere.TabIndex = 13;
            this.lblMatiere.Text = "Matière principale :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(121, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(6, 19);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(651, 138);
            this.txtCommentaire.TabIndex = 8;
            this.txtCommentaire.TextChanged += new System.EventHandler(this.txtCommentaire_TextChanged);
            // 
            // gbxCommentaire
            // 
            this.gbxCommentaire.Controls.Add(this.txtCommentaire);
            this.gbxCommentaire.Location = new System.Drawing.Point(12, 373);
            this.gbxCommentaire.Name = "gbxCommentaire";
            this.gbxCommentaire.Size = new System.Drawing.Size(663, 164);
            this.gbxCommentaire.TabIndex = 9;
            this.gbxCommentaire.TabStop = false;
            this.gbxCommentaire.Text = "Commentaire";
            this.gbxCommentaire.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lklblAvances
            // 
            this.lklblAvances.AutoSize = true;
            this.lklblAvances.Location = new System.Drawing.Point(171, 302);
            this.lklblAvances.Name = "lklblAvances";
            this.lklblAvances.Size = new System.Drawing.Size(160, 13);
            this.lklblAvances.TabIndex = 15;
            this.lklblAvances.TabStop = true;
            this.lklblAvances.Text = "Ajouter plus  de caractéristiques ";
            this.lklblAvances.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblAvances_LinkClicked);
            // 
            // frmAjoutTissu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(688, 780);
            this.Controls.Add(this.gbxCommentaire);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjoutProjet);
            this.Controls.Add(this.gbxAvances);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbxPrincipales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAjoutTissu";
            this.Text = "Ajouter un tissu";
            this.Load += new System.EventHandler(this.frmAjoutTissu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxPrincipales.ResumeLayout(false);
            this.gbxPrincipales.PerformLayout();
            this.gbxAvances.ResumeLayout(false);
            this.gbxAvances.PerformLayout();
            this.gbxCommentaire.ResumeLayout(false);
            this.gbxCommentaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxPrincipales;
        private System.Windows.Forms.Label lblProvenance;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkLave;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.ComboBox cbxCouleur;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Button btnAjoutProjet;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblMetrage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rbtnTisse;
        private System.Windows.Forms.RadioButton rbtnMaille;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblLaize;
        private System.Windows.Forms.Label lblDensite;
        private System.Windows.Forms.TextBox txtDensite;
        private System.Windows.Forms.GroupBox gbxAvances;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblMatiere;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblElasticite;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox cbxMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.GroupBox gbxCommentaire;
        private System.Windows.Forms.LinkLabel lklblAvances;
    }
}