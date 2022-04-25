namespace libraryppe
{
    partial class frmLivreUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLivreUser));
            this.dgvLivre = new System.Windows.Forms.DataGridView();
            this.colonneTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneAuteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneAnnee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelLivreUser = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLivre
            // 
            this.dgvLivre.AllowUserToAddRows = false;
            this.dgvLivre.AllowUserToDeleteRows = false;
            this.dgvLivre.AllowUserToResizeColumns = false;
            this.dgvLivre.AllowUserToResizeRows = false;
            this.dgvLivre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.dgvLivre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLivre.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvLivre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLivre.ColumnHeadersHeight = 21;
            this.dgvLivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLivre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colonneTitre,
            this.colonneAuteur,
            this.colonneAnnee,
            this.colonneCategorie});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLivre.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLivre.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.dgvLivre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvLivre.Location = new System.Drawing.Point(173, 132);
            this.dgvLivre.Name = "dgvLivre";
            this.dgvLivre.ShowCellErrors = false;
            this.dgvLivre.ShowCellToolTips = false;
            this.dgvLivre.ShowEditingIcon = false;
            this.dgvLivre.Size = new System.Drawing.Size(464, 429);
            this.dgvLivre.TabIndex = 9;
            this.dgvLivre.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvLivre_Paint);
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
            // labelLivreUser
            // 
            this.labelLivreUser.AutoSize = true;
            this.labelLivreUser.BackColor = System.Drawing.Color.Transparent;
            this.labelLivreUser.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLivreUser.ForeColor = System.Drawing.Color.White;
            this.labelLivreUser.Location = new System.Drawing.Point(37, 53);
            this.labelLivreUser.Name = "labelLivreUser";
            this.labelLivreUser.Size = new System.Drawing.Size(253, 33);
            this.labelLivreUser.TabIndex = 10;
            this.labelLivreUser.Text = "Liste des livres de : ";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(337, 53);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(67, 33);
            this.labelUser.TabIndex = 11;
            this.labelUser.Text = "user";
            // 
            // frmLivreUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(820, 560);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelLivreUser);
            this.Controls.Add(this.dgvLivre);
            this.Name = "frmLivreUser";
            this.Text = "frmLivreUser";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLivre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneAuteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneAnnee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneCategorie;
        private System.Windows.Forms.Label labelLivreUser;
        private System.Windows.Forms.Label labelUser;
    }
}