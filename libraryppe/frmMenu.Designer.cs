namespace libraryppe
{
    partial class frmMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonMessagerie = new System.Windows.Forms.Button();
            this.buttonParametre = new System.Windows.Forms.Button();
            this.buttonLocation = new System.Windows.Forms.Button();
            this.buttonBibliotheque = new System.Windows.Forms.Button();
            this.buttonAccueil = new System.Windows.Forms.Button();
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenu.Controls.Add(this.buttonMessagerie);
            this.panelMenu.Controls.Add(this.buttonParametre);
            this.panelMenu.Controls.Add(this.buttonLocation);
            this.panelMenu.Controls.Add(this.buttonBibliotheque);
            this.panelMenu.Controls.Add(this.buttonAccueil);
            this.panelMenu.Controls.Add(this.labelUserInfo);
            this.panelMenu.Location = new System.Drawing.Point(46, 57);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(236, 642);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonMessagerie
            // 
            this.buttonMessagerie.Location = new System.Drawing.Point(49, 322);
            this.buttonMessagerie.Name = "buttonMessagerie";
            this.buttonMessagerie.Size = new System.Drawing.Size(143, 61);
            this.buttonMessagerie.TabIndex = 6;
            this.buttonMessagerie.Text = "Messagerie";
            this.buttonMessagerie.UseVisualStyleBackColor = true;
            this.buttonMessagerie.Click += new System.EventHandler(this.buttonMessagerie_Click);
            // 
            // buttonParametre
            // 
            this.buttonParametre.Location = new System.Drawing.Point(49, 413);
            this.buttonParametre.Name = "buttonParametre";
            this.buttonParametre.Size = new System.Drawing.Size(143, 61);
            this.buttonParametre.TabIndex = 5;
            this.buttonParametre.Text = "Paramètre";
            this.buttonParametre.UseVisualStyleBackColor = true;
            // 
            // buttonLocation
            // 
            this.buttonLocation.Location = new System.Drawing.Point(49, 227);
            this.buttonLocation.Name = "buttonLocation";
            this.buttonLocation.Size = new System.Drawing.Size(143, 61);
            this.buttonLocation.TabIndex = 4;
            this.buttonLocation.Text = "Mes locations";
            this.buttonLocation.UseVisualStyleBackColor = true;
            this.buttonLocation.Click += new System.EventHandler(this.buttonLocation_Click);
            // 
            // buttonBibliotheque
            // 
            this.buttonBibliotheque.Location = new System.Drawing.Point(49, 134);
            this.buttonBibliotheque.Name = "buttonBibliotheque";
            this.buttonBibliotheque.Size = new System.Drawing.Size(143, 61);
            this.buttonBibliotheque.TabIndex = 3;
            this.buttonBibliotheque.Text = "Bibliothèque";
            this.buttonBibliotheque.UseVisualStyleBackColor = true;
            this.buttonBibliotheque.Click += new System.EventHandler(this.buttonBibliotheque_Click);
            // 
            // buttonAccueil
            // 
            this.buttonAccueil.Location = new System.Drawing.Point(49, 43);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(143, 61);
            this.buttonAccueil.TabIndex = 2;
            this.buttonAccueil.Text = "Accueil";
            this.buttonAccueil.UseVisualStyleBackColor = true;
            this.buttonAccueil.Click += new System.EventHandler(this.buttonAccueil_Click);
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.AutoSize = true;
            this.labelUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserInfo.Location = new System.Drawing.Point(30, 576);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(175, 31);
            this.labelUserInfo.TabIndex = 1;
            this.labelUserInfo.Text = "labelUserInfo";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContainer.Location = new System.Drawing.Point(378, 57);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(897, 642);
            this.panelContainer.TabIndex = 1;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 782);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMenu";
            this.Text = "Accueil";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button buttonLocation;
        private System.Windows.Forms.Button buttonBibliotheque;
        private System.Windows.Forms.Button buttonAccueil;
        private System.Windows.Forms.Label labelUserInfo;
        private System.Windows.Forms.Button buttonMessagerie;
        private System.Windows.Forms.Button buttonParametre;
    }
}