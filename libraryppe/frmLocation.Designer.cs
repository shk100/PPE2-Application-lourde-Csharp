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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocation));
            this.labelLocation = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dgvLocation1 = new System.Windows.Forms.DataGridView();
            this.colonneTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneAuteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneAnnee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.BackColor = System.Drawing.Color.Transparent;
            this.labelLocation.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.ForeColor = System.Drawing.Color.White;
            this.labelLocation.Location = new System.Drawing.Point(51, 49);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(184, 33);
            this.labelLocation.TabIndex = 1;
            this.labelLocation.Text = "Mes locations";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(623, 65);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(213, 75);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "Rafraichir mes locations";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // dgvLocation1
            // 
            this.dgvLocation1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvLocation1.AllowUserToAddRows = false;
            this.dgvLocation1.AllowUserToDeleteRows = false;
            this.dgvLocation1.AllowUserToResizeColumns = false;
            this.dgvLocation1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLocation1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocation1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.dgvLocation1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLocation1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvLocation1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocation1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocation1.ColumnHeadersHeight = 21;
            this.dgvLocation1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLocation1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colonneTitre,
            this.colonneAuteur,
            this.colonneAnnee,
            this.colonneCategorie,
            this.test});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocation1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLocation1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.dgvLocation1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvLocation1.Location = new System.Drawing.Point(144, 228);
            this.dgvLocation1.Name = "dgvLocation1";
            this.dgvLocation1.ReadOnly = true;
            this.dgvLocation1.ShowCellErrors = false;
            this.dgvLocation1.ShowCellToolTips = false;
            this.dgvLocation1.ShowEditingIcon = false;
            this.dgvLocation1.Size = new System.Drawing.Size(584, 413);
            this.dgvLocation1.TabIndex = 9;
            this.dgvLocation1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocation1_CellContentClick);
            this.dgvLocation1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvLocation1_DataBindingComplete);
            this.dgvLocation1.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvLocation1_Paint);
            // 
            // colonneTitre
            // 
            this.colonneTitre.HeaderText = "Titre";
            this.colonneTitre.Name = "colonneTitre";
            this.colonneTitre.ReadOnly = true;
            this.colonneTitre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colonneTitre.Width = 120;
            // 
            // colonneAuteur
            // 
            this.colonneAuteur.HeaderText = "Auteur";
            this.colonneAuteur.Name = "colonneAuteur";
            this.colonneAuteur.ReadOnly = true;
            // 
            // colonneAnnee
            // 
            this.colonneAnnee.HeaderText = "Année";
            this.colonneAnnee.Name = "colonneAnnee";
            this.colonneAnnee.ReadOnly = true;
            // 
            // colonneCategorie
            // 
            this.colonneCategorie.HeaderText = "Catégorie";
            this.colonneCategorie.Name = "colonneCategorie";
            this.colonneCategorie.ReadOnly = true;
            // 
            // test
            // 
            this.test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.test.HeaderText = "Rendre";
            this.test.Name = "test";
            this.test.ReadOnly = true;
            this.test.Text = "Rendre";
            this.test.UseColumnTextForButtonValue = true;
            this.test.Width = 120;
            // 
            // frmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(881, 603);
            this.Controls.Add(this.dgvLocation1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLocation";
            this.Text = "frmLocation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dgvLocation1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneAuteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneAnnee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneCategorie;
        private System.Windows.Forms.DataGridViewButtonColumn test;
    }
}