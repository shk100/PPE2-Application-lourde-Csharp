using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace libraryppe
{
    public partial class frmSendMessageUser : Form
    {
        public frmSendMessageUser()
        {
            InitializeComponent();
            FillComboBox();
        }


        libraryppe.ApiController apiController = new ApiController();


        // Remplissafe de la comboBox avec les differents utilisateurs
        private void FillComboBox()
        {
            JArray content = apiController.GetAllUser();

            int tailleTableau = content.Count();
            for (int i = 0; i < tailleTableau; i++)
            {
                cbUser.Items.Add(content[i]["mail"]);
            }
        }



        // Envoi du message a un utilisateur en fonction du choix de la comboBox
        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            string sujet = txbSujet.Text;
            string message = txbMessage.Text;
            string auteur = "admin";
            string destinataire = cbUser.Text;

            apiController.SendMessage(sujet, auteur, destinataire, message);
            MessageBox.Show("Votre message à bien été envoyé !");
            this.Close();
        }
    }
}
