using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryppe
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            infoApplication();
            OpenActiveForm(acceuilForm);
            verifStatut();
        }


        // Reference aux autres Forms
        frmAccueil acceuilForm = new frmAccueil();
        frmBibliotheque biblioForm = new frmBibliotheque();
        frmLocation locationForm = new frmLocation();
        frmMessage messageForm = new frmMessage();
        frmResponsable responsableForm = new frmResponsable();
        frmAdmin adminForm = new frmAdmin();

        Form activeForm;



        // Modification du visuel de l'application et affiche les infos de l'user connecté
        private void infoApplication()
        {
            panelMenu.BackColor = Color.FromArgb(35, Color.Black);
            panelContainer.BackColor = Color.FromArgb(35, Color.Black);
            buttonAccueil.FlatAppearance.BorderSize = 0;
            labelUserInfo.Text = ApiController.User.nom + " " + ApiController.User.prenom;
        }




        // Permet D'ouvrir un Form dans le panel a droite du menu
        private void OpenActiveForm(Form newForm)
        {
            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;

            this.panelContainer.Controls.Add(newForm);

            newForm.BringToFront();
            newForm.Show();
        }


        // Verification du statut de l'user connecté et affiche le bouton correspondant
        private void verifStatut()
        {
            int utilisateur = 1;
            int responsable = 2;
            int admin = 3;
            int statutUser = ApiController.User.status;

            if (statutUser == utilisateur)
            {
                buttonAdmin.Visible = false;
                buttonResponsable.Visible = false;
            }
            else if (statutUser == responsable)
            {
                buttonAdmin.Visible = false;
                buttonResponsable.Visible = true;
            }
            else if (statutUser == admin)
            {
                buttonResponsable.Visible = true;
                buttonAdmin.Visible = true;
            }
        }






        // Ouvre le Form Accueil
        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            OpenActiveForm(acceuilForm);
        }

        // Ouvre le Form Bibliothèque
        private void buttonBibliotheque_Click(object sender, EventArgs e)
        {
            OpenActiveForm(biblioForm);
        }

        // Ouvre le Form Location
        private void buttonLocation_Click(object sender, EventArgs e)
        {
            OpenActiveForm(locationForm);
        }

        // Ouvre le Form Message
        private void buttonMessagerie_Click(object sender, EventArgs e)
        {
            OpenActiveForm(messageForm);
        }

        // Ouvre le Form Responsable
        private void buttonResponsable_Click(object sender, EventArgs e)
        {
            OpenActiveForm(responsableForm);
        }

        // Ouvre le Form Admin
        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            OpenActiveForm(adminForm);
        }
    }
}
