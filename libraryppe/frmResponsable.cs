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
    public partial class frmResponsable : Form
    {
        public frmResponsable()
        {
            InitializeComponent();
            FillDataGridView();
            designApp();
        }



        libraryppe.ApiController apiController = new ApiController();


        // Définition des parametres graphique du Form
        private void designApp()
        {
            dgvResponsable.BackgroundColor = Color.FromArgb(25, 35, 57);
            dgvResponsable.GridColor = Color.FromArgb(25, 35, 57);
            dgvResponsable.ForeColor = Color.White;
            dgvResponsable.DefaultCellStyle.BackColor = Color.FromArgb(25, 35, 57);
            dgvResponsable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 35, 57);
            dgvResponsable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }





        // Remplissage du dataGrid avec les informations des utilisateurs
        private void FillDataGridView()
        {
            this.dgvResponsable.Rows.Clear();
            JArray content = apiController.GetAllUser();

            int tailleTableau = content.Count();
            for (int i = 0; i < tailleTableau; i++)
            {
                dgvResponsable.Rows.Add(content[i]["id"], content[i]["nom"], content[i]["prenom"], content[i]["mail"]);
            }
        }




        // Gestion du bouton du dataGrid qui permet de voir les livres détenu par l'utilisateur
        private void dgvResponsable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >=0)
            {
                // Recuperation du mail de l'user de la ligne et stockage dans la variable activeMail pour l'utiliser dans le prochain Form
               ApiController.User.activeMail = dgvResponsable.Rows[e.RowIndex].Cells[3].Value.ToString();

                frmLivreUser livreUserForm = new frmLivreUser();
                livreUserForm.Show();
            }
        }


        // Déselection de la première cellule du dataGrid
        private void dgvResponsable_Paint_1(object sender, PaintEventArgs e)
        {
           this.dgvResponsable.ClearSelection();
        }

        // Ouverture du Form pour envoyer un message à l'utilisateur
        private void buttonMessage_Click(object sender, EventArgs e)
        {
            frmSendMessageUser formSend = new frmSendMessageUser();
            formSend.Show();
        }

        // Rafraichissement du dataGrid
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }
    }
}
