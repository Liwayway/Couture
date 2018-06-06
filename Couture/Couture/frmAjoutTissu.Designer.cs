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
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblProvenance = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.chkMaille = new System.Windows.Forms.CheckBox();
            this.chkTisse = new System.Windows.Forms.CheckBox();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.cbxCouleur = new System.Windows.Forms.ComboBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.chkLave = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxPrincipales.SuspendLayout();
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
            this.gbxPrincipales.Controls.Add(this.chkLave);
            this.gbxPrincipales.Controls.Add(this.txtPrix);
            this.gbxPrincipales.Controls.Add(this.lblPrix);
            this.gbxPrincipales.Controls.Add(this.cbxCouleur);
            this.gbxPrincipales.Controls.Add(this.pictureBox1);
            this.gbxPrincipales.Controls.Add(this.lblCouleur);
            this.gbxPrincipales.Controls.Add(this.chkTisse);
            this.gbxPrincipales.Controls.Add(this.chkMaille);
            this.gbxPrincipales.Controls.Add(this.lblType);
            this.gbxPrincipales.Controls.Add(this.textBox1);
            this.gbxPrincipales.Controls.Add(this.lblProvenance);
            this.gbxPrincipales.Controls.Add(this.txtNom);
            this.gbxPrincipales.Controls.Add(this.lblNom);
            this.gbxPrincipales.Location = new System.Drawing.Point(12, 30);
            this.gbxPrincipales.Name = "gbxPrincipales";
            this.gbxPrincipales.Size = new System.Drawing.Size(663, 261);
            this.gbxPrincipales.TabIndex = 1;
            this.gbxPrincipales.TabStop = false;
            this.gbxPrincipales.Text = "Caractéristiques principales";
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
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(241, 30);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(338, 20);
            this.txtNom.TabIndex = 1;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 20);
            this.textBox1.TabIndex = 3;
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
            // chkMaille
            // 
            this.chkMaille.AutoSize = true;
            this.chkMaille.Location = new System.Drawing.Point(286, 102);
            this.chkMaille.Name = "chkMaille";
            this.chkMaille.Size = new System.Drawing.Size(91, 17);
            this.chkMaille.TabIndex = 5;
            this.chkMaille.Text = "Maille (tricoté)";
            this.chkMaille.UseVisualStyleBackColor = true;
            this.chkMaille.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkTisse
            // 
            this.chkTisse.AutoSize = true;
            this.chkTisse.Location = new System.Drawing.Point(383, 102);
            this.chkTisse.Name = "chkTisse";
            this.chkTisse.Size = new System.Drawing.Size(51, 17);
            this.chkTisse.TabIndex = 6;
            this.chkTisse.Text = "Tissé";
            this.chkTisse.UseVisualStyleBackColor = true;
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
            // cbxCouleur
            // 
            this.cbxCouleur.FormattingEnabled = true;
            this.cbxCouleur.Location = new System.Drawing.Point(280, 136);
            this.cbxCouleur.Name = "cbxCouleur";
            this.cbxCouleur.Size = new System.Drawing.Size(121, 21);
            this.cbxCouleur.TabIndex = 8;
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
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(280, 171);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(100, 20);
            this.txtPrix.TabIndex = 10;
            // 
            // chkLave
            // 
            this.chkLave.AutoSize = true;
            this.chkLave.Location = new System.Drawing.Point(174, 213);
            this.chkLave.Name = "chkLave";
            this.chkLave.Size = new System.Drawing.Size(236, 17);
            this.chkLave.TabIndex = 11;
            this.chkLave.Text = "Le tissu a été lavé une première fois (décati).";
            this.chkLave.UseVisualStyleBackColor = true;
            // 
            // frmAjoutTissu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.gbxPrincipales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAjoutTissu";
            this.Text = "Ajouter un tissu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxPrincipales.ResumeLayout(false);
            this.gbxPrincipales.PerformLayout();
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
        private System.Windows.Forms.CheckBox chkMaille;
        private System.Windows.Forms.CheckBox chkLave;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.ComboBox cbxCouleur;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.CheckBox chkTisse;
    }
}