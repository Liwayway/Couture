namespace Couture
{
    partial class frmListeTissus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeTissus));
            this.grdTissus = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRechercheTissu = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnous = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTissus)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTissus
            // 
            this.grdTissus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTissus.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grdTissus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTissus.Location = new System.Drawing.Point(11, 69);
            this.grdTissus.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.grdTissus.Name = "grdTissus";
            this.grdTissus.ReadOnly = true;
            this.grdTissus.Size = new System.Drawing.Size(776, 326);
            this.grdTissus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rechercher : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRechercheTissu
            // 
            this.txtRechercheTissu.Location = new System.Drawing.Point(113, 19);
            this.txtRechercheTissu.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtRechercheTissu.Name = "txtRechercheTissu";
            this.txtRechercheTissu.Size = new System.Drawing.Size(347, 32);
            this.txtRechercheTissu.TabIndex = 3;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(511, 407);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(87, 42);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(605, 407);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(87, 42);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(700, 407);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "&Fermer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnous
            // 
            this.btnous.Location = new System.Drawing.Point(574, 15);
            this.btnous.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnous.Name = "btnous";
            this.btnous.Size = new System.Drawing.Size(87, 42);
            this.btnous.TabIndex = 8;
            this.btnous.Text = "Tous";
            this.btnous.UseVisualStyleBackColor = true;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(480, 15);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(87, 42);
            this.btnRechercher.TabIndex = 9;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // frmListeTissus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 464);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnous);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtRechercheTissu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdTissus);
            this.Font = new System.Drawing.Font("Georgina", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmListeTissus";
            this.Text = "Ma collection de tissus";
            this.Load += new System.EventHandler(this.frmListeTissus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTissus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTissus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRechercheTissu;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnous;
        private System.Windows.Forms.Button btnRechercher;
    }
}