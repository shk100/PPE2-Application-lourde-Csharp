namespace libraryppe
{
    partial class frmMessage
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
            this.labelMessage = new System.Windows.Forms.Label();
            this.dgvMessage = new System.Windows.Forms.DataGridView();
            this.buttonMessage = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sujet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(45, 62);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(196, 31);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "Mes messages";
            // 
            // dgvMessage
            // 
            this.dgvMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.auteur,
            this.sujet,
            this.message,
            this.supprimer});
            this.dgvMessage.Location = new System.Drawing.Point(-11, 136);
            this.dgvMessage.Name = "dgvMessage";
            this.dgvMessage.Size = new System.Drawing.Size(898, 396);
            this.dgvMessage.TabIndex = 7;
            this.dgvMessage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMessage_CellContentClick);
            // 
            // buttonMessage
            // 
            this.buttonMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMessage.Location = new System.Drawing.Point(553, 49);
            this.buttonMessage.Name = "buttonMessage";
            this.buttonMessage.Size = new System.Drawing.Size(287, 64);
            this.buttonMessage.TabIndex = 8;
            this.buttonMessage.Text = "Contacter un administrateur";
            this.buttonMessage.UseVisualStyleBackColor = true;
            this.buttonMessage.Click += new System.EventHandler(this.button1_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // auteur
            // 
            this.auteur.HeaderText = "auteur";
            this.auteur.Name = "auteur";
            // 
            // sujet
            // 
            this.sujet.HeaderText = "Sujet";
            this.sujet.Name = "sujet";
            // 
            // message
            // 
            this.message.HeaderText = "Message";
            this.message.Name = "message";
            // 
            // supprimer
            // 
            this.supprimer.HeaderText = "Supprimer";
            this.supprimer.Name = "supprimer";
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseColumnTextForButtonValue = true;
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 564);
            this.Controls.Add(this.buttonMessage);
            this.Controls.Add(this.dgvMessage);
            this.Controls.Add(this.labelMessage);
            this.Name = "frmMessage";
            this.Text = "frmMessage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.DataGridView dgvMessage;
        private System.Windows.Forms.Button buttonMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn sujet;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.DataGridViewButtonColumn supprimer;
    }
}