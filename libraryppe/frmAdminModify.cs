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
    public partial class frmAdminModify : Form
    {
        public frmAdminModify()
        {
            InitializeComponent();

            FillInformation();
        }

        libraryppe.ApiController apiController = new ApiController();

        string selectionedUser = ApiController.User.activeMail;
        string nom;
        string prenom;
        string mail;
        string status;

        // Remplissage des labels avec les informations de l'user
        private void FillInformation()
        {
            JObject content = apiController.GetOneUser(selectionedUser);

            nom = content.GetValue("nom").ToString();
            prenom = content.GetValue("prenom").ToString();
            mail = content.GetValue("mail").ToString();
            status = content.GetValue("status").ToString();

            labelNom.Text = "Nom : " + nom;
            labelPrenom.Text = "Prenom: " + prenom;
            labelMail.Text = "Mail : " + mail;
            labelStatus.Text = "Status : " + status;
        }




        // Vérification des textBox pour savoir si elles sont vide ou non et modification de l'user
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            string tmpNom;
            string tmpPrenom;
            string tmpMail;
            string tmpStatus;

            if (String.IsNullOrEmpty(txbNom.Text))
            {
                tmpNom = nom;
            }
            else
            {
                tmpNom = txbNom.Text;
            }

            if (String.IsNullOrEmpty(txbPrenom.Text))
            {
                tmpPrenom = prenom;
            }
            else
            {
                tmpPrenom = txbPrenom.Text;
            }

            if (String.IsNullOrEmpty(txbMail.Text))
            {
                tmpMail = mail;
            }
            else
            {
                tmpMail = txbMail.Text;
            }

            if (String.IsNullOrEmpty(txbStatus.Text))
            {
                tmpStatus = status;
            }
            else
            {
                tmpStatus = txbStatus.Text;
            }

            apiController.UpdateUserInformation(selectionedUser, tmpNom, tmpPrenom, tmpMail, tmpStatus);

            MessageBox.Show("L'utilisateur à bien été modifié !");
            this.Close();
        }
    }
}
