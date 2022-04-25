using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp.Serializers;
using libraryppe;

namespace libraryppe
{
    public partial class frmInscription : Form
    {
        public frmInscription()
        {
            InitializeComponent();
        }

        // Récuperation des inputs user et création de l'utilisateur par defaut en status 1 (utilisateur)
        private void buttonInscription_Click(object sender, EventArgs e)
        {
            libraryppe.ApiController apiController = new ApiController();

            string nom = txbNom.Text;
            string prenom = txbPrenom.Text;
            string mail = txbMail.Text;
            string pass = txbPass.Text;

            if (apiController.RegisterApi(nom, prenom, mail, pass))
            {
                MessageBox.Show("L'utilisateur a bien été enregistré");
                this.Close();
            }
        }
    }
}
