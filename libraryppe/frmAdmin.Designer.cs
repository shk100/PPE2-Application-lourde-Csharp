namespace libraryppe
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.colonneId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonnePrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifierUser = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.AllowUserToResizeColumns = false;
            this.dgvAdmin.AllowUserToResizeRows = false;
            this.dgvAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.dgvAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAdmin.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdmin.ColumnHeadersHeight = 21;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colonneId,
            this.colonneNom,
            this.colonnePrenom,
            this.colonneMail,
            this.colonneStatus,
            this.modifierUser});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdmin.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdmin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.dgvAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvAdmin.Location = new System.Drawing.Point(100, 152);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ShowCellErrors = false;
            this.dgvAdmin.ShowCellToolTips = false;
            this.dgvAdmin.ShowEditingIcon = false;
            this.dgvAdmin.Size = new System.Drawing.Size(683, 451);
            this.dgvAdmin.TabIndex = 9;
            this.dgvAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellContentClick);
            this.dgvAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvAdmin_Paint);
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
            // colonneStatus
            // 
            this.colonneStatus.HeaderText = "Status";
            this.colonneStatus.Name = "colonneStatus";
            // 
            // modifierUser
            // 
            this.modifierUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifierUser.HeaderText = "Modifier l\'utilisateur";
            this.modifierUser.Name = "modifierUser";
            this.modifierUser.Text = "Modifier";
            this.modifierUser.UseColumnTextForButtonValue = true;
            this.modifierUser.Width = 120;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.White;
            this.labelMessage.Location = new System.Drawing.Point(51, 49);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(299, 33);
            this.labelMessage.TabIndex = 10;
            this.labelMessage.Text = "Gestion des utilisateurs";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(568, 59);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(248, 45);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Rafraichir les utilisateurs";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(881, 603);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.dgvAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonnePrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneStatus;
        private System.Windows.Forms.DataGridViewButtonColumn modifierUser;
        private System.Windows.Forms.Button buttonRefresh;
    }
}