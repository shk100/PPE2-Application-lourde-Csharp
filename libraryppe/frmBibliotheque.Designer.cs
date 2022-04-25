namespace libraryppe
{
    partial class frmBibliotheque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBibliotheque));
            this.labelBibliotheque = new System.Windows.Forms.Label();
            this.buttonFiction = new System.Windows.Forms.Button();
            this.buttonHorreur = new System.Windows.Forms.Button();
            this.buttonFantasy = new System.Windows.Forms.Button();
            this.buttonRomantique = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.dgvBibliotheque = new System.Windows.Forms.DataGridView();
            this.colonneTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneAuteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneAnnee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Louer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotheque)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBibliotheque
            // 
            this.labelBibliotheque.AutoSize = true;
            this.labelBibliotheque.BackColor = System.Drawing.Color.Transparent;
            this.labelBibliotheque.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBibliotheque.ForeColor = System.Drawing.Color.White;
            this.labelBibliotheque.Location = new System.Drawing.Point(51, 49);
            this.labelBibliotheque.Name = "labelBibliotheque";
            this.labelBibliotheque.Size = new System.Drawing.Size(165, 33);
            this.labelBibliotheque.TabIndex = 0;
            this.labelBibliotheque.Text = "Bibliotheque";
            // 
            // buttonFiction
            // 
            this.buttonFiction.BackColor = System.Drawing.Color.Transparent;
            this.buttonFiction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFiction.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiction.ForeColor = System.Drawing.Color.White;
            this.buttonFiction.Location = new System.Drawing.Point(45, 114);
            this.buttonFiction.Name = "buttonFiction";
            this.buttonFiction.Size = new System.Drawing.Size(135, 45);
            this.buttonFiction.TabIndex = 1;
            this.buttonFiction.Text = "Fiction";
            this.buttonFiction.UseVisualStyleBackColor = false;
            this.buttonFiction.Click += new System.EventHandler(this.buttonFiction_Click);
            // 
            // buttonHorreur
            // 
            this.buttonHorreur.BackColor = System.Drawing.Color.Transparent;
            this.buttonHorreur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHorreur.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHorreur.ForeColor = System.Drawing.Color.White;
            this.buttonHorreur.Location = new System.Drawing.Point(280, 114);
            this.buttonHorreur.Name = "buttonHorreur";
            this.buttonHorreur.Size = new System.Drawing.Size(135, 45);
            this.buttonHorreur.TabIndex = 2;
            this.buttonHorreur.Text = "Horreur";
            this.buttonHorreur.UseVisualStyleBackColor = false;
            this.buttonHorreur.Click += new System.EventHandler(this.buttonHorreur_Click);
            // 
            // buttonFantasy
            // 
            this.buttonFantasy.BackColor = System.Drawing.Color.Transparent;
            this.buttonFantasy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFantasy.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFantasy.ForeColor = System.Drawing.Color.White;
            this.buttonFantasy.Location = new System.Drawing.Point(498, 114);
            this.buttonFantasy.Name = "buttonFantasy";
            this.buttonFantasy.Size = new System.Drawing.Size(135, 45);
            this.buttonFantasy.TabIndex = 3;
            this.buttonFantasy.Text = "Fantasy";
            this.buttonFantasy.UseVisualStyleBackColor = false;
            this.buttonFantasy.Click += new System.EventHandler(this.buttonFantasy_Click);
            // 
            // buttonRomantique
            // 
            this.buttonRomantique.BackColor = System.Drawing.Color.Transparent;
            this.buttonRomantique.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRomantique.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRomantique.ForeColor = System.Drawing.Color.White;
            this.buttonRomantique.Location = new System.Drawing.Point(716, 114);
            this.buttonRomantique.Name = "buttonRomantique";
            this.buttonRomantique.Size = new System.Drawing.Size(135, 45);
            this.buttonRomantique.TabIndex = 4;
            this.buttonRomantique.Text = "Romantique";
            this.buttonRomantique.UseVisualStyleBackColor = false;
            this.buttonRomantique.Click += new System.EventHandler(this.buttonRomantique_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.BackColor = System.Drawing.Color.Transparent;
            this.buttonAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAll.Font = new System.Drawing.Font("Roboto", 14F);
            this.buttonAll.ForeColor = System.Drawing.Color.White;
            this.buttonAll.Location = new System.Drawing.Point(716, 41);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(135, 45);
            this.buttonAll.TabIndex = 5;
            this.buttonAll.Text = "Tout afficher";
            this.buttonAll.UseVisualStyleBackColor = false;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // dgvBibliotheque
            // 
            this.dgvBibliotheque.AllowUserToAddRows = false;
            this.dgvBibliotheque.AllowUserToDeleteRows = false;
            this.dgvBibliotheque.AllowUserToResizeColumns = false;
            this.dgvBibliotheque.AllowUserToResizeRows = false;
            this.dgvBibliotheque.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.dgvBibliotheque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBibliotheque.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvBibliotheque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBibliotheque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBibliotheque.ColumnHeadersHeight = 21;
            this.dgvBibliotheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBibliotheque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colonneTitre,
            this.colonneAuteur,
            this.colonneAnnee,
            this.colonneCategorie,
            this.colonneDisponible,
            this.Louer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBibliotheque.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBibliotheque.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.dgvBibliotheque.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvBibliotheque.Location = new System.Drawing.Point(121, 192);
            this.dgvBibliotheque.Name = "dgvBibliotheque";
            this.dgvBibliotheque.ShowCellErrors = false;
            this.dgvBibliotheque.ShowCellToolTips = false;
            this.dgvBibliotheque.ShowEditingIcon = false;
            this.dgvBibliotheque.Size = new System.Drawing.Size(684, 451);
            this.dgvBibliotheque.TabIndex = 6;
            this.dgvBibliotheque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBibliotheque_CellContentClick);
            this.dgvBibliotheque.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvBibliotheque_Paint);
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
            // colonneDisponible
            // 
            this.colonneDisponible.HeaderText = "Disponible";
            this.colonneDisponible.Name = "colonneDisponible";
            // 
            // Louer
            // 
            this.Louer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Louer.HeaderText = "Louer";
            this.Louer.Name = "Louer";
            this.Louer.Text = "Louer";
            this.Louer.UseColumnTextForButtonValue = true;
            this.Louer.Width = 120;
            // 
            // frmBibliotheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(897, 642);
            this.Controls.Add(this.dgvBibliotheque);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonRomantique);
            this.Controls.Add(this.buttonFantasy);
            this.Controls.Add(this.buttonHorreur);
            this.Controls.Add(this.buttonFiction);
            this.Controls.Add(this.labelBibliotheque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBibliotheque";
            this.Text = "accueiltest";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotheque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBibliotheque;
        private System.Windows.Forms.Button buttonFiction;
        private System.Windows.Forms.Button buttonHorreur;
        private System.Windows.Forms.Button buttonFantasy;
        private System.Windows.Forms.Button buttonRomantique;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.DataGridView dgvBibliotheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneAuteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneAnnee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneDisponible;
        private System.Windows.Forms.DataGridViewButtonColumn Louer;
    }
}