﻿namespace libraryppe
{
    partial class frmAccueil
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
            this.labelAccueil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAccueil
            // 
            this.labelAccueil.AutoSize = true;
            this.labelAccueil.Location = new System.Drawing.Point(52, 45);
            this.labelAccueil.Name = "labelAccueil";
            this.labelAccueil.Size = new System.Drawing.Size(42, 13);
            this.labelAccueil.TabIndex = 0;
            this.labelAccueil.Text = "Acceuil";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAccueil);
            this.Name = "frmAccueil";
            this.Text = "frmAccueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAccueil;
    }
}