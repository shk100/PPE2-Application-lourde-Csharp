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
    public partial class frmMessage : Form
    {
        public frmMessage()
        {
            InitializeComponent();
            StatusMessage();
        }


        libraryppe.ApiController apiController = new ApiController();

        int user = 1;
        int responsable = 2;
        int statutUser = ApiController.User.status;


        // Verification le statut de l'user et affiche le bon texte et la bonne fonction
        private void StatusMessage()
        {
            if (statutUser == user)
            {
                FillDataGridViewUser();
            }
            else if (statutUser == responsable)
            {
                FillDataGridViewAdmin();
                buttonMessage.Hide();
            }
        }

        // Remplissage du dataGrid avec les messages reçu de l'user
        private void FillDataGridViewUser()
        {
            // Clear du data grid
            this.dgvMessage.Rows.Clear();

            // Recuperation en Jarray d'un tableau contenant les données
            JArray content = apiController.GetAllMessage(ApiController.User.mail);

            int tailleTableau = content.Count();
            // Loop sur le tableau pour remplir chaque ligne
            for (int i = 0; i < tailleTableau; i++)
            {
                dgvMessage.Rows.Add(content[i]["id"], content[i]["auteur"], content[i]["sujet"], content[i]["message"]);
            }
        }


        // Remplissage du dataGrid avec les messages reçu de l'administrateur
        private void FillDataGridViewAdmin()
        {
            // Clear du data grid
            this.dgvMessage.Rows.Clear();

            // Recuperation en Jarray d'un tableau contenant les données
            JArray content = apiController.GetAllMessage("admin");

            int tailleTableau = content.Count();
            // Loop sur le tableau pour remplir chaque ligne
            for (int i = 0; i < tailleTableau; i++)
            {
                dgvMessage.Rows.Add(content[i]["id"], content[i]["auteur"], content[i]["sujet"], content[i]["message"]);
            }
        }



        // Ouverture du form de contact administrateur
        private void button1_Click(object sender, EventArgs e)
        {
            frmSendMessage formSend = new frmSendMessage();
            formSend.Show();
        }



        // Suppression d'un message avec son id en cliquant sur le bouton du dataGrid
        private void dgvMessage_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                // Recuperation de l'id du message
                string idMessage = dgvMessage.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Suppression du message
                apiController.DeleteMessage(idMessage);

                // MessageBox pour avertir de la suppresion
                MessageBox.Show("Le message à bien été supprimé !");

                // Refresh le dataGrid
                StatusMessage();
            }
        }



        // Déselection de la première cellule du dataGrid
        private void dgvMessage_Paint(object sender, PaintEventArgs e)
        {
            this.dgvMessage.ClearSelection();
        }

    }
}
