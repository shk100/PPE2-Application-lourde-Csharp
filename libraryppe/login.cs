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


        /*
        // Verifie les identifiants de l'user                     A REMETTRE AVANT LA FIN*********************************************
        private void Login()
        {
            libraryppe.ApiController apiController = new ApiController();
            string mail = tbMail.Text;
            string pass = tbPass.Text;
           if( apiController.LoginApi(mail, pass))
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
        */

        

        private void Login()
        {
            libraryppe.ApiController apiController = new ApiController();

            string mail = "mailfred";
            string pass = "mdpfred";
            if (apiController.LoginApi(mail, pass))
            {
                this.Hide();
                frmMenu formAccueil = new frmMenu();
                formAccueil.ShowDialog();
                this.Close();
            }

        }
        


        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
