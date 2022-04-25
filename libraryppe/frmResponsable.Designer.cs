namespace libraryppe
{
    partial class frmResponsable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResponsable));
            this.labelResponsable = new System.Windows.Forms.Label();
            this.dgvResponsable = new System.Windows.Forms.DataGridView();
            this.colonneId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonnePrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voirleslivres = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonMessage = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsable)).BeginInit();
            this.SuspendLayout();
            // 
            // labelResponsable
            // 
            this.labelResponsable.AutoSize = true;
            this.labelResponsable.BackColor = System.Drawing.Color.Transparent;
            this.labelResponsable.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponsable.ForeColor = System.Drawing.Color.White;
            this.labelResponsable.Location = new System.Drawing.Point(51, 49);
            this.labelResponsable.Name = "labelResponsable";
            this.labelResponsable.Size = new System.Drawing.Size(170, 33);
            this.labelResponsable.TabIndex = 2;
            this.labelResponsable.Text = "Responsable";
            // 
            // dgvResponsable
            // 
            this.dgvResponsable.AllowUserToAddRows = false;
            this.dgvResponsable.AllowUserToDeleteRows = false;
            this.dgvResponsable.AllowUserToResizeColumns = false;
            this.dgvResponsable.AllowUserToResizeRows = false;
            this.dgvResponsable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.dgvResponsable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvResponsable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvResponsable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResponsable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResponsable.ColumnHeadersHeight = 21;
            this.dgvResponsable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResponsable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colonneId,
            this.colonneNom,
            this.colonnePrenom,
            this.colonneMail,
            this.voirleslivres});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResponsable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResponsable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.dgvResponsable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvResponsable.Location = new System.Drawing.Point(146, 172);
            this.dgvResponsable.Name = "dgvResponsable";
            this.dgvResponsable.ShowCellErrors = false;
            this.dgvResponsable.ShowCellToolTips = false;
            this.dgvResponsable.ShowEditingIcon = false;
            this.dgvResponsable.Size = new System.Drawing.Size(587, 451);
            this.dgvResponsable.TabIndex = 8;
            this.dgvResponsable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResponsable_CellContentClick);
            this.dgvResponsable.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvResponsable_Paint_1);
            // 
            // colonneId
            // 
            this.colonneId.HeaderText = "id";
            this.colonneId.Name = "colonneId";
            this.colonneId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colonneId.Width = 120;
            // 
            // colonneNom
            // 
            this.colonneNom.HeaderText = "Nom";
            this.colonneNom.Name = "colonneNom";
            // 
            // colonnePrenom
            // 
            this.colonnePrenom.HeaderText = "Prénom";
            this.colonnePrenom.Name = "colonnePrenom";
            // 
            // colonneMail
            // 
            this.colonneMail.HeaderText = "Mail";
            this.colonneMail.Name = "colonneMail";
            // 
            // voirleslivres
            // 
            this.voirleslivres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voirleslivres.HeaderText = "Voir les livres";
            this.voirleslivres.Name = "voirleslivres";
            this.voirleslivres.Text = "Voir";
            this.voirleslivres.UseColumnTextForButtonValue = true;
            this.voirleslivres.Width = 120;
            // 
            // buttonMessage
            // 
            this.buttonMessage.BackColor = System.Drawing.Color.Transparent;
            this.buttonMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMessage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMessage.ForeColor = System.Drawing.Color.White;
            this.buttonMessage.Location = new System.Drawing.Point(557, 49);
            this.buttonMessage.Name = "buttonMessage";
            this.buttonMessage.Size = new System.Drawing.Size(287, 64);
            this.buttonMessage.TabIndex = 9;
            this.buttonMessage.Text = "Contacter un utilisateur";
            this.buttonMessage.UseVisualStyleBackColor = false;
            this.buttonMessage.Click += new System.EventHandler(this.buttonMessage_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(254, 49);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(248, 64);
            this.buttonRefresh.TabIndex = 12;
            this.buttonRefresh.Text = "Rafraichir les utilisateurs";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // frmResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(881, 603);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonMessage);
            this.Controls.Add(this.dgvResponsable);
            this.Controls.Add(this.labelResponsable);
            this.Name = "frmResponsable";
            this.Text = "frmResponsable";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResponsable;
        private System.Windows.Forms.DataGridView dgvResponsable;
        private System.Windows.Forms.Button buttonMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonnePrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneMail;
        private System.Windows.Forms.DataGridViewButtonColumn voirleslivres;
        private System.Windows.Forms.Button buttonRefresh;
    }
}