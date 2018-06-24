namespace Couture
{
    partial class frmAssocierTissuProjet
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
            this.lblChoisir = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMetrage = new System.Windows.Forms.Label();
            this.txtMetrage = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoisir
            // 
            this.lblChoisir.AutoSize = true;
            this.lblChoisir.Location = new System.Drawing.Point(26, 26);
            this.lblChoisir.Name = "lblChoisir";
            this.lblChoisir.Size = new System.Drawing.Size(148, 13);
            this.lblChoisir.TabIndex = 0;
            this.lblChoisir.Text = "Choisissez le tissu à associer :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 121);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblMetrage
            // 
            this.lblMetrage.AutoSize = true;
            this.lblMetrage.Location = new System.Drawing.Point(40, 212);
            this.lblMetrage.Name = "lblMetrage";
            this.lblMetrage.Size = new System.Drawing.Size(211, 13);
            this.lblMetrage.TabIndex = 2;
            this.lblMetrage.Text = "Quelle quantité avez vous besoin (en cm) ?";
            // 
            // txtMetrage
            // 
            this.txtMetrage.Location = new System.Drawing.Point(43, 228);
            this.txtMetrage.Name = "txtMetrage";
            this.txtMetrage.Size = new System.Drawing.Size(100, 20);
            this.txtMetrage.TabIndex = 3;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(692, 258);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(611, 258);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // frmAssocierTissuProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 308);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtMetrage);
            this.Controls.Add(this.lblMetrage);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblChoisir);
            this.Name = "frmAssocierTissuProjet";
            this.Text = "Associer un tissu au projet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblChoisir;
        private System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.Label lblMetrage;
        private System.Windows.Forms.TextBox txtMetrage;
        protected System.Windows.Forms.Button btnAnnuler;
        protected System.Windows.Forms.Button btnOK;
    }
}