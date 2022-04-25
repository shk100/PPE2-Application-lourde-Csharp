namespace libraryppe
{
    partial class frmInscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscription));
            this.labelInscription = new System.Windows.Forms.Label();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.buttonInscription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInscription
            // 
            this.labelInscription.AutoSize = true;
            this.labelInscription.BackColor = System.Drawing.Color.Transparent;
            this.labelInscription.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInscription.ForeColor = System.Drawing.Color.White;
            this.labelInscription.Location = new System.Drawing.Point(33, 33);
            this.labelInscription.Name = "labelInscription";
            this.labelInscription.Size = new System.Drawing.Size(143, 33);
            this.labelInscription.TabIndex = 0;
            this.labelInscription.Text = "Inscription";
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(174, 151);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(230, 20);
            this.txbNom.TabIndex = 1;
            // 
            // txbPrenom
            // 
            this.txbPrenom.Location = new System.Drawing.Point(176, 222);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(228, 20);
            this.txbPrenom.TabIndex = 2;
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(174, 286);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(230, 20);
            this.txbMail.TabIndex = 3;
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(176, 352);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(228, 20);
            this.txbPass.TabIndex = 4;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.BackColor = System.Drawing.Color.Transparent;
            this.labelNom.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.ForeColor = System.Drawing.Color.White;
            this.labelNom.Location = new System.Drawing.Point(170, 124);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(52, 24);
            this.labelNom.TabIndex = 5;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.BackColor = System.Drawing.Color.Transparent;
            this.labelPrenom.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.ForeColor = System.Drawing.Color.White;
            this.labelPrenom.Location = new System.Drawing.Point(172, 195);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(79, 24);
            this.labelPrenom.TabIndex = 6;
            this.labelPrenom.Text = "Prénom";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.BackColor = System.Drawing.Color.Transparent;
            this.labelMail.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.ForeColor = System.Drawing.Color.White;
            this.labelMail.Location = new System.Drawing.Point(172, 259);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(124, 24);
            this.labelMail.TabIndex = 7;
            this.labelMail.Text = "Adresse mail";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.Transparent;
            this.labelPass.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.White;
            this.labelPass.Location = new System.Drawing.Point(172, 325);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(128, 24);
            this.labelPass.TabIndex = 8;
            this.labelPass.Text = "Mot de passe";
            // 
            // buttonInscription
            // 
            this.buttonInscription.BackColor = System.Drawing.Color.Transparent;
            this.buttonInscription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInscription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInscription.ForeColor = System.Drawing.Color.White;
            this.buttonInscription.Location = new System.Drawing.Point(251, 410);
            this.buttonInscription.Name = "buttonInscription";
            this.buttonInscription.Size = new System.Drawing.Size(118, 47);
            this.buttonInscription.TabIndex = 9;
            this.buttonInscription.Text = "S\'inscrire";
            this.buttonInscription.UseVisualStyleBackColor = false;
            this.buttonInscription.Click += new System.EventHandler(this.buttonInscription_Click);
            // 
            // frmInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 497);
            this.Controls.Add(this.buttonInscription);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbMail);
            this.Controls.Add(this.txbPrenom);
            this.Controls.Add(this.txbNom);
            this.Controls.Add(this.labelInscription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInscription";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "frmInscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInscription;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.TextBox txbPrenom;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button buttonInscription;
    }
}