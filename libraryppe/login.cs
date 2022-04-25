using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Serializers;
using libraryppe;

namespace libraryppe
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();

        }



        // Verifie les identifiants de l'user                     
        private void Login()
        {
            libraryppe.ApiController apiController = new ApiController();
            string mail = tbMail.Text;
            string pass = tbPass.Text;
            if (apiController.LoginApi(mail, pass))
            {
                this.Hide();
                frmMenu formAccueil = new frmMenu();
                formAccueil.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Probleme d'identifiant ou mot de passe");
            }

        }
        

        /*
        // Connexion automatisé pour les tests de l'application
        private void Login()
        {
            libraryppe.ApiController apiController = new ApiController();

            string mail = "adminMail";
            string pass = "adminMdp";
            if (apiController.LoginApi(mail, pass))
            {
                this.Hide();
                frmMenu formAccueil = new frmMenu();
                formAccueil.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Probleme lors du login");
            }

        }
        */

        // Bouton pour lancer l'authentification
        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            Login();
        }


        // Bouton qui ouvre le Form d'inscription 
        private void buttonInscription_Click(object sender, EventArgs e)
        {
            frmInscription formInscri = new frmInscription();
            formInscri.ShowDialog();
        }
    }
}
