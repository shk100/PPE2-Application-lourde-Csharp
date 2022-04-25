namespace libraryppe
{
    partial class frmAdminModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminModify));
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelActuel = new System.Windows.Forms.Label();
            this.labelNew = new System.Windows.Forms.Label();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.White;
            this.labelMessage.Location = new System.Drawing.Point(41, 45);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(255, 33);
            this.labelMessage.TabIndex = 11;
            this.labelMessage.Text = "Modifier l\'utilisateur";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.BackColor = System.Drawing.Color.Transparent;
            this.labelNom.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.ForeColor = System.Drawing.Color.White;
            this.labelNom.Location = new System.Drawing.Point(76, 212);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(51, 19);
            this.labelNom.TabIndex = 12;
            this.labelNom.Text = "Nom :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.BackColor = System.Drawing.Color.Transparent;
            this.labelPrenom.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.ForeColor = System.Drawing.Color.White;
            this.labelPrenom.Location = new System.Drawing.Point(76, 258);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(73, 19);
            this.labelPrenom.TabIndex = 13;
            this.labelPrenom.Text = "Prénom :";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.BackColor = System.Drawing.Color.Transparent;
            this.labelMail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.ForeColor = System.Drawing.Color.White;
            this.labelMail.Location = new System.Drawing.Point(76, 312);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(48, 19);
            this.labelMail.TabIndex = 14;
            this.labelMail.Text = "Mail :";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(76, 356);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(63, 19);
            this.labelStatus.TabIndex = 15;
            this.labelStatus.Text = "Status :";
            // 
            // labelActuel
            // 
            this.labelActuel.AutoSize = true;
            this.labelActuel.BackColor = System.Drawing.Color.Transparent;
            this.labelActuel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActuel.ForeColor = System.Drawing.Color.White;
            this.labelActuel.Location = new System.Drawing.Point(176, 134);
            this.labelActuel.Name = "labelActuel";
            this.labelActuel.Size = new System.Drawing.Size(76, 27);
            this.labelActuel.TabIndex = 16;
            this.labelActuel.Text = "Actuel";
            // 
            // labelNew
            // 
            this.labelNew.AutoSize = true;
            this.labelNew.BackColor = System.Drawing.Color.Transparent;
            this.labelNew.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNew.ForeColor = System.Drawing.Color.White;
            this.labelNew.Location = new System.Drawing.Point(484, 134);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(139, 27);
            this.labelNew.TabIndex = 17;
            this.labelNew.Text = "Modification";
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(455, 213);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(233, 20);
            this.txbNom.TabIndex = 18;
            // 
            // txbPrenom
            // 
            this.txbPrenom.Location = new System.Drawing.Point(455, 257);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(233, 20);
            this.txbPrenom.TabIndex = 19;
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(455, 311);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(233, 20);
            this.txbMail.TabIndex = 20;
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(455, 355);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(233, 20);
            this.txbStatus.TabIndex = 21;
            // 
            // buttonModifier
            // 
            this.buttonModifier.BackColor = System.Drawing.Color.Transparent;
            this.buttonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModifier.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.ForeColor = System.Drawing.Color.White;
            this.buttonModifier.Location = new System.Drawing.Point(429, 401);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(287, 64);
            this.buttonModifier.TabIndex = 22;
            this.buttonModifier.Text = "Modifier l\'utilisateur";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // frmAdminModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.txbMail);
            this.Controls.Add(this.txbPrenom);
            this.Controls.Add(this.txbNom);
            this.Controls.Add(this.labelNew);
            this.Controls.Add(this.labelActuel);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelMessage);
            this.Name = "frmAdminModify";
            this.Text = "frmAdminModify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelActuel;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.TextBox txbPrenom;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Button buttonModifier;
    }
}