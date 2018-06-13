namespace Couture
{
    partial class frmProjetParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjetParent));
            this.tbpGalerie = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbcProjet = new System.Windows.Forms.TabControl();
            this.cbxHome = new System.Windows.Forms.ComboBox();
            this.cbxAccessoire = new System.Windows.Forms.ComboBox();
            this.cbxVetement = new System.Windows.Forms.ComboBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.rbtHome = new System.Windows.Forms.RadioButton();
            this.rbtAccessoire = new System.Windows.Forms.RadioButton();
            this.rbtVetement = new System.Windows.Forms.RadioButton();
            this.lblTypeProjet = new System.Windows.Forms.Label();
            this.lblAvancement = new System.Windows.Forms.Label();
            this.rbtIdee = new System.Windows.Forms.RadioButton();
            this.rbtdecalque = new System.Windows.Forms.RadioButton();
            this.rbtreporte = new System.Windows.Forms.RadioButton();
            this.rbtdecoupe = new System.Windows.Forms.RadioButton();
            this.lblImprime = new System.Windows.Forms.RadioButton();
            this.rbtPique = new System.Windows.Forms.RadioButton();
            this.rbtFini = new System.Windows.Forms.RadioButton();
            this.lblNote = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblGalerie = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAjoutPhoto = new System.Windows.Forms.Button();
            this.btnAjoutPatron = new System.Windows.Forms.Button();
            this.btnAjoutTissu = new System.Windows.Forms.Button();
            this.tbpGalerie.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbcProjet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpGalerie
            // 
            this.tbpGalerie.Controls.Add(this.lblGalerie);
            this.tbpGalerie.Location = new System.Drawing.Point(4, 22);
            this.tbpGalerie.Name = "tbpGalerie";
            this.tbpGalerie.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGalerie.Size = new System.Drawing.Size(776, 535);
            this.tbpGalerie.TabIndex = 1;
            this.tbpGalerie.Text = "Galerie de photos";
            this.tbpGalerie.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.lblNote);
            this.tabPage1.Controls.Add(this.rbtFini);
            this.tabPage1.Controls.Add(this.rbtPique);
            this.tabPage1.Controls.Add(this.lblImprime);
            this.tabPage1.Controls.Add(this.rbtdecoupe);
            this.tabPage1.Controls.Add(this.rbtreporte);
            this.tabPage1.Controls.Add(this.rbtdecalque);
            this.tabPage1.Controls.Add(this.rbtIdee);
            this.tabPage1.Controls.Add(this.lblAvancement);
            this.tabPage1.Controls.Add(this.cbxHome);
            this.tabPage1.Controls.Add(this.cbxAccessoire);
            this.tabPage1.Controls.Add(this.cbxVetement);
            this.tabPage1.Controls.Add(this.lblCategorie);
            this.tabPage1.Controls.Add(this.rbtHome);
            this.tabPage1.Controls.Add(this.rbtAccessoire);
            this.tabPage1.Controls.Add(this.rbtVetement);
            this.tabPage1.Controls.Add(this.lblTypeProjet);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Projet";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbcProjet
            // 
            this.tbcProjet.Controls.Add(this.tabPage1);
            this.tbcProjet.Controls.Add(this.tbpGalerie);
            this.tbcProjet.Location = new System.Drawing.Point(6, 10);
            this.tbcProjet.Name = "tbcProjet";
            this.tbcProjet.SelectedIndex = 0;
            this.tbcProjet.Size = new System.Drawing.Size(784, 561);
            this.tbcProjet.TabIndex = 0;
            // 
            // cbxHome
            // 
            this.cbxHome.FormattingEnabled = true;
            this.cbxHome.Location = new System.Drawing.Point(304, 121);
            this.cbxHome.Name = "cbxHome";
            this.cbxHome.Size = new System.Drawing.Size(121, 21);
            this.cbxHome.TabIndex = 15;
            this.cbxHome.Text = "Coussin";
            // 
            // cbxAccessoire
            // 
            this.cbxAccessoire.FormattingEnabled = true;
            this.cbxAccessoire.Location = new System.Drawing.Point(177, 121);
            this.cbxAccessoire.Name = "cbxAccessoire";
            this.cbxAccessoire.Size = new System.Drawing.Size(121, 21);
            this.cbxAccessoire.TabIndex = 14;
            this.cbxAccessoire.Text = "Bandeau";
            // 
            // cbxVetement
            // 
            this.cbxVetement.FormattingEnabled = true;
            this.cbxVetement.Location = new System.Drawing.Point(44, 121);
            this.cbxVetement.Name = "cbxVetement";
            this.cbxVetement.Size = new System.Drawing.Size(127, 21);
            this.cbxVetement.TabIndex = 13;
            this.cbxVetement.Text = "Robe";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(41, 91);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(130, 13);
            this.lblCategorie.TabIndex = 12;
            this.lblCategorie.Text = "Choisissez une catégorie :";
            // 
            // rbtHome
            // 
            this.rbtHome.AutoSize = true;
            this.rbtHome.Location = new System.Drawing.Point(216, 53);
            this.rbtHome.Name = "rbtHome";
            this.rbtHome.Size = new System.Drawing.Size(156, 17);
            this.rbtHome.TabIndex = 11;
            this.rbtHome.TabStop = true;
            this.rbtHome.Text = "Home / Déco / Rangement";
            this.rbtHome.UseVisualStyleBackColor = true;
            // 
            // rbtAccessoire
            // 
            this.rbtAccessoire.AutoSize = true;
            this.rbtAccessoire.Location = new System.Drawing.Point(133, 53);
            this.rbtAccessoire.Name = "rbtAccessoire";
            this.rbtAccessoire.Size = new System.Drawing.Size(77, 17);
            this.rbtAccessoire.TabIndex = 10;
            this.rbtAccessoire.TabStop = true;
            this.rbtAccessoire.Text = "Accessoire";
            this.rbtAccessoire.UseVisualStyleBackColor = true;
            // 
            // rbtVetement
            // 
            this.rbtVetement.AutoSize = true;
            this.rbtVetement.Location = new System.Drawing.Point(44, 53);
            this.rbtVetement.Name = "rbtVetement";
            this.rbtVetement.Size = new System.Drawing.Size(70, 17);
            this.rbtVetement.TabIndex = 9;
            this.rbtVetement.TabStop = true;
            this.rbtVetement.Text = "Vêtement";
            this.rbtVetement.UseVisualStyleBackColor = true;
            // 
            // lblTypeProjet
            // 
            this.lblTypeProjet.AutoSize = true;
            this.lblTypeProjet.Location = new System.Drawing.Point(41, 26);
            this.lblTypeProjet.Name = "lblTypeProjet";
            this.lblTypeProjet.Size = new System.Drawing.Size(206, 13);
            this.lblTypeProjet.TabIndex = 8;
            this.lblTypeProjet.Text = "Quel type de projet désirez-vous coudre  ?";
            // 
            // lblAvancement
            // 
            this.lblAvancement.AutoSize = true;
            this.lblAvancement.Location = new System.Drawing.Point(41, 171);
            this.lblAvancement.Name = "lblAvancement";
            this.lblAvancement.Size = new System.Drawing.Size(106, 13);
            this.lblAvancement.TabIndex = 16;
            this.lblAvancement.Text = "Où en est ce projet ?";
            // 
            // rbtIdee
            // 
            this.rbtIdee.AutoSize = true;
            this.rbtIdee.Location = new System.Drawing.Point(44, 201);
            this.rbtIdee.Name = "rbtIdee";
            this.rbtIdee.Size = new System.Drawing.Size(95, 17);
            this.rbtIdee.TabIndex = 17;
            this.rbtIdee.TabStop = true;
            this.rbtIdee.Text = "Juste une Idée";
            this.rbtIdee.UseVisualStyleBackColor = true;
            // 
            // rbtdecalque
            // 
            this.rbtdecalque.AutoSize = true;
            this.rbtdecalque.Location = new System.Drawing.Point(44, 247);
            this.rbtdecalque.Name = "rbtdecalque";
            this.rbtdecalque.Size = new System.Drawing.Size(190, 17);
            this.rbtdecalque.TabIndex = 19;
            this.rbtdecalque.TabStop = true;
            this.rbtdecalque.Text = "Le patron  est décalqué / découpé";
            this.rbtdecalque.UseVisualStyleBackColor = true;
            // 
            // rbtreporte
            // 
            this.rbtreporte.AutoSize = true;
            this.rbtreporte.Location = new System.Drawing.Point(44, 270);
            this.rbtreporte.Name = "rbtreporte";
            this.rbtreporte.Size = new System.Drawing.Size(123, 17);
            this.rbtreporte.TabIndex = 20;
            this.rbtreporte.TabStop = true;
            this.rbtreporte.Text = "Et reporté sur le tissu";
            this.rbtreporte.UseVisualStyleBackColor = true;
            // 
            // rbtdecoupe
            // 
            this.rbtdecoupe.AutoSize = true;
            this.rbtdecoupe.Location = new System.Drawing.Point(44, 293);
            this.rbtdecoupe.Name = "rbtdecoupe";
            this.rbtdecoupe.Size = new System.Drawing.Size(123, 17);
            this.rbtdecoupe.TabIndex = 21;
            this.rbtdecoupe.TabStop = true;
            this.rbtdecoupe.Text = "Le tissu est découpé";
            this.rbtdecoupe.UseVisualStyleBackColor = true;
            // 
            // lblImprime
            // 
            this.lblImprime.AutoSize = true;
            this.lblImprime.Location = new System.Drawing.Point(44, 224);
            this.lblImprime.Name = "lblImprime";
            this.lblImprime.Size = new System.Drawing.Size(183, 17);
            this.lblImprime.TabIndex = 18;
            this.lblImprime.TabStop = true;
            this.lblImprime.Text = "Le patron est imprimé / assemblé ";
            this.lblImprime.UseVisualStyleBackColor = true;
            // 
            // rbtPique
            // 
            this.rbtPique.AutoSize = true;
            this.rbtPique.Location = new System.Drawing.Point(44, 316);
            this.rbtPique.Name = "rbtPique";
            this.rbtPique.Size = new System.Drawing.Size(124, 17);
            this.rbtPique.TabIndex = 22;
            this.rbtPique.TabStop = true;
            this.rbtPique.Text = "En avant la couture !";
            this.rbtPique.UseVisualStyleBackColor = true;
            // 
            // rbtFini
            // 
            this.rbtFini.AutoSize = true;
            this.rbtFini.Location = new System.Drawing.Point(44, 339);
            this.rbtFini.Name = "rbtFini";
            this.rbtFini.Size = new System.Drawing.Size(93, 17);
            this.rbtFini.TabIndex = 23;
            this.rbtFini.TabStop = true;
            this.rbtFini.Text = "Ouf, enfin fini !";
            this.rbtFini.UseVisualStyleBackColor = true;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(25, 379);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(41, 13);
            this.lblNote.TabIndex = 24;
            this.lblNote.Text = "Notes :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 407);
            this.textBox1.MaxLength = 1000;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(726, 106);
            this.textBox1.TabIndex = 25;
            // 
            // lblGalerie
            // 
            this.lblGalerie.AutoSize = true;
            this.lblGalerie.Location = new System.Drawing.Point(6, 24);
            this.lblGalerie.Name = "lblGalerie";
            this.lblGalerie.Size = new System.Drawing.Size(146, 13);
            this.lblGalerie.TabIndex = 0;
            this.lblGalerie.Text = "Les photos du projet terminé :";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(711, 577);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(630, 577);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAjoutPhoto
            // 
            this.btnAjoutPhoto.Location = new System.Drawing.Point(426, 577);
            this.btnAjoutPhoto.Name = "btnAjoutPhoto";
            this.btnAjoutPhoto.Size = new System.Drawing.Size(198, 23);
            this.btnAjoutPhoto.TabIndex = 3;
            this.btnAjoutPhoto.Text = "Ajouter une photo  du projet terminé";
            this.btnAjoutPhoto.UseVisualStyleBackColor = true;
            // 
            // btnAjoutPatron
            // 
            this.btnAjoutPatron.Location = new System.Drawing.Point(300, 577);
            this.btnAjoutPatron.Name = "btnAjoutPatron";
            this.btnAjoutPatron.Size = new System.Drawing.Size(120, 23);
            this.btnAjoutPatron.TabIndex = 4;
            this.btnAjoutPatron.Text = "Associer un patron";
            this.btnAjoutPatron.UseVisualStyleBackColor = true;
            // 
            // btnAjoutTissu
            // 
            this.btnAjoutTissu.Location = new System.Drawing.Point(192, 577);
            this.btnAjoutTissu.Name = "btnAjoutTissu";
            this.btnAjoutTissu.Size = new System.Drawing.Size(102, 23);
            this.btnAjoutTissu.TabIndex = 5;
            this.btnAjoutTissu.Text = "Associer un tissu";
            this.btnAjoutTissu.UseVisualStyleBackColor = true;
            // 
            // frmProjetParent
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.btnAjoutTissu);
            this.Controls.Add(this.btnAjoutPatron);
            this.Controls.Add(this.btnAjoutPhoto);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.tbcProjet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProjetParent";
            this.Text = "frmProjetParent";
            this.tbpGalerie.ResumeLayout(false);
            this.tbpGalerie.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbcProjet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabPage tbpGalerie;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rbtFini;
        private System.Windows.Forms.RadioButton rbtPique;
        private System.Windows.Forms.RadioButton lblImprime;
        protected System.Windows.Forms.RadioButton rbtdecoupe;
        private System.Windows.Forms.RadioButton rbtreporte;
        protected System.Windows.Forms.RadioButton rbtdecalque;
        protected System.Windows.Forms.RadioButton rbtIdee;
        protected System.Windows.Forms.Label lblAvancement;
        protected System.Windows.Forms.ComboBox cbxHome;
        protected System.Windows.Forms.ComboBox cbxAccessoire;
        protected System.Windows.Forms.ComboBox cbxVetement;
        private System.Windows.Forms.Label lblCategorie;
        protected System.Windows.Forms.RadioButton rbtHome;
        protected System.Windows.Forms.RadioButton rbtAccessoire;
        protected System.Windows.Forms.RadioButton rbtVetement;
        protected System.Windows.Forms.Label lblTypeProjet;
        protected System.Windows.Forms.TabControl tbcProjet;
        protected System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.Label lblNote;
        protected System.Windows.Forms.Label lblGalerie;
        protected System.Windows.Forms.Button btnAnnuler;
        protected System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAjoutPhoto;
        private System.Windows.Forms.Button btnAjoutPatron;
        private System.Windows.Forms.Button btnAjoutTissu;
    }
}