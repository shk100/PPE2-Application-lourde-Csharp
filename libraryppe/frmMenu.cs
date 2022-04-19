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
        }


        frmAccueil acceuilForm = new frmAccueil();
        frmBibliotheque biblioForm = new frmBibliotheque();
        frmLocation locationForm = new frmLocation();
        frmMessage messageForm= new frmMessage();

        Form activeForm;

        


        private void infoApplication()
        {
            labelUserInfo.Text = ApiController.User.nom + " " + ApiController.User.prenom;
        }





        private void OpenActiveForm(Form childForm)
        {

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelContainer.Controls.Add(childForm);

            childForm.BringToFront();
            childForm.Show();
        }













        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            OpenActiveForm(acceuilForm);
        }


        private void buttonBibliotheque_Click(object sender, EventArgs e)
        {
            OpenActiveForm(biblioForm);
        }

        private void buttonLocation_Click(object sender, EventArgs e)
        {
            OpenActiveForm(locationForm);
        }

        private void buttonMessagerie_Click(object sender, EventArgs e)
        {
            OpenActiveForm(messageForm);
        }
    }
}
