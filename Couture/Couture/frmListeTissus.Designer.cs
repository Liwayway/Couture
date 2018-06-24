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
            ((System.ComponentModel.ISupportInitialize)(this.grdTissus)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTissus
            // 
            this.grdTissus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTissus.BackgroundColor = System.Drawing.Color.Teal;
            this.grdTissus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTissus.Location = new System.Drawing.Point(12, 99);
            this.grdTissus.Name = "grdTissus";
            this.grdTissus.ReadOnly = true;
            this.grdTissus.Size = new System.Drawing.Size(665, 243);
            this.grdTissus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rechercher : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRechercheTissu
            // 
            this.txtRechercheTissu.Location = new System.Drawing.Point(98, 35);
            this.txtRechercheTissu.Name = "txtRechercheTissu";
            this.txtRechercheTissu.Size = new System.Drawing.Size(298, 20);
            this.txtRechercheTissu.TabIndex = 3;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(394, 380);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(475, 380);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "&Fermer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmListeTissus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 415);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtRechercheTissu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdTissus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}