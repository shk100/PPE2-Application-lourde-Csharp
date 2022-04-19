namespace libraryppe
{
    partial class frmLocation
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
            this.labelLocation = new System.Windows.Forms.Label();
            this.dgvLocation = new System.Windows.Forms.DataGridView();
            this.colonneTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneAuteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneAnnee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(51, 49);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(180, 31);
            this.labelLocation.TabIndex = 1;
            this.labelLocation.Text = "Mes locations";
            // 
            // dgvLocation
            // 
            this.dgvLocation.AllowUserToAddRows = false;
            this.dgvLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colonneTitre,
            this.colonneAuteur,
            this.colonneAnnee,
            this.colonneCategorie,
            this.test});
            this.dgvLocation.Location = new System.Drawing.Point(-2, 171);
            this.dgvLocation.Name = "dgvLocation";
            this.dgvLocation.Size = new System.Drawing.Size(898, 396);
            this.dgvLocation.TabIndex = 7;
            this.dgvLocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocation_CellContentClick);
            // 
            // colonneTitre
            // 
            this.colonneTitre.HeaderText = "Titre";
            this.colonneTitre.Name = "colonneTitre";
            this.colonneTitre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colonneTitre.Width = 120;
            // 
            // colonneAuteur
            // 
            this.colonneAuteur.HeaderText = "Auteur";
            this.colonneAuteur.Name = "colonneAuteur";
            // 
            // colonneAnnee
            // 
            this.colonneAnnee.HeaderText = "Année";
            this.colonneAnnee.Name = "colonneAnnee";
            // 
            // colonneCategorie
            // 
            this.colonneCategorie.HeaderText = "Catégorie";
            this.colonneCategorie.Name = "colonneCategorie";
            // 
            // test
            // 
            this.test.HeaderText = "";
            this.test.Name = "test";
            this.test.Text = "Rendre le livre";
            this.test.UseColumnTextForButtonValue = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(623, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 75);
            this.button1.TabIndex = 8;
            this.button1.Text = "Rafraichir mes locations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvLocation);
            this.Controls.Add(this.labelLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLocation";
            this.Text = "frmLocation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.DataGridView dgvLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneAuteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneAnnee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneCategorie;
        private System.Windows.Forms.DataGridViewButtonColumn test;
        private System.Windows.Forms.Button button1;
    }
}