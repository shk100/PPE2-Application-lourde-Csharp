namespace libraryppe
{
    partial class frmSendMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendMessage));
            this.txbSujet = new System.Windows.Forms.TextBox();
            this.labelSujet = new System.Windows.Forms.Label();
            this.txbMessage = new System.Windows.Forms.RichTextBox();
            this.labelMess = new System.Windows.Forms.Label();
            this.buttonEnvoyer = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbSujet
            // 
            this.txbSujet.Location = new System.Drawing.Point(27, 117);
            this.txbSujet.Name = "txbSujet";
            this.txbSujet.Size = new System.Drawing.Size(537, 20);
            this.txbSujet.TabIndex = 1;
            // 
            // labelSujet
            // 
            this.labelSujet.AutoSize = true;
            this.labelSujet.BackColor = System.Drawing.Color.Transparent;
            this.labelSujet.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSujet.ForeColor = System.Drawing.Color.White;
            this.labelSujet.Location = new System.Drawing.Point(23, 94);
            this.labelSujet.Name = "labelSujet";
            this.labelSujet.Size = new System.Drawing.Size(45, 19);
            this.labelSujet.TabIndex = 2;
            this.labelSujet.Text = "Sujet";
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(27, 206);
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(537, 174);
            this.txbMessage.TabIndex = 4;
            this.txbMessage.Text = "";
            // 
            // labelMess
            // 
            this.labelMess.AutoSize = true;
            this.labelMess.BackColor = System.Drawing.Color.Transparent;
            this.labelMess.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMess.ForeColor = System.Drawing.Color.White;
            this.labelMess.Location = new System.Drawing.Point(23, 183);
            this.labelMess.Name = "labelMess";
            this.labelMess.Size = new System.Drawing.Size(73, 19);
            this.labelMess.TabIndex = 5;
            this.labelMess.Text = "Message";
            // 
            // buttonEnvoyer
            // 
            this.buttonEnvoyer.BackColor = System.Drawing.Color.Transparent;
            this.buttonEnvoyer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEnvoyer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnvoyer.ForeColor = System.Drawing.Color.White;
            this.buttonEnvoyer.Location = new System.Drawing.Point(452, 397);
            this.buttonEnvoyer.Name = "buttonEnvoyer";
            this.buttonEnvoyer.Size = new System.Drawing.Size(112, 41);
            this.buttonEnvoyer.TabIndex = 6;
            this.buttonEnvoyer.Text = "Envoyer";
            this.buttonEnvoyer.UseVisualStyleBackColor = false;
            this.buttonEnvoyer.Click += new System.EventHandler(this.buttonEnvoyer_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.White;
            this.labelMessage.Location = new System.Drawing.Point(21, 28);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(353, 33);
            this.labelMessage.TabIndex = 7;
            this.labelMessage.Text = "Contacter un administrateur";
            // 
            // frmSendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonEnvoyer);
            this.Controls.Add(this.labelMess);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.labelSujet);
            this.Controls.Add(this.txbSujet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSendMessage";
            this.Text = "Contacter un administrateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbSujet;
        private System.Windows.Forms.Label labelSujet;
        private System.Windows.Forms.RichTextBox txbMessage;
        private System.Windows.Forms.Label labelMess;
        private System.Windows.Forms.Button buttonEnvoyer;
        private System.Windows.Forms.Label labelMessage;
    }
}