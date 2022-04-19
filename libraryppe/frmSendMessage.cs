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
    public partial class frmSendMessage : Form
    {
        public frmSendMessage()
        {
            InitializeComponent();
        }



        libraryppe.ApiController apiController = new ApiController();



        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            string sujet = txbSujet.Text;
            string message = txbMessage.Text;
            string auteur = ApiController.User.mail;
            string destinataire = "admin";

            apiController.SendMessage(sujet, auteur, destinataire, message);
            MessageBox.Show("Votre message à bien été envoyé !");
            this.Close();
        }
    }
}
