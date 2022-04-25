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
    public partial class frmLocation : Form
    {
        public frmLocation()
        {
            InitializeComponent();
            FillDataGridViewUser();
            designapp();
        }


        libraryppe.ApiController apiController = new ApiController();


        // Définiton des parametres graphique du Form
        private void designapp()
        {
            dgvLocation1.BackgroundColor = Color.FromArgb(25, 35, 57);
            dgvLocation1.GridColor = Color.FromArgb(25, 35, 57);
            dgvLocation1.ForeColor = Color.White;
            dgvLocation1.DefaultCellStyle.BackColor = Color.FromArgb(25, 35, 57);
            dgvLocation1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 35, 57);
            dgvLocation1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }


        // Remplissage du dataGrid avec les informations des livres
        public void FillDataGridViewUser()
        {
            this.dgvLocation1.Rows.Clear();  // On clear le data grid
            string currentUser = ApiController.User.mail;

            JArray content = apiController.GetBookByUser(ApiController.User.mail);

            int tailleTableau = content.Count();
            for (int i = 0; i < tailleTableau; i++)
            {
                dgvLocation1.Rows.Add(content[i]["titre"], content[i]["auteur"], content[i]["annee"], content[i]["categorie"]);
            }
        }






        private void dgvLocation1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvLocation1.ClearSelection();
        }



        // Déselection de la première cellule du dataGrid
        private void dgvLocation1_Paint(object sender, PaintEventArgs e)
        {
            this.dgvLocation1.ClearSelection();
        }


        // Gestion du bouton de rendu de livre du dataGrid
        private void dgvLocation1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                // Recuperation du titre du livre
                string titreLivre = dgvLocation1.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Retour du livre a la bibliotheque et disponibilité sur oui
                apiController.ReturnBookUser(titreLivre);

                MessageBox.Show("Votre livre à bien été rendu !");

                // Recharge du dataGrid avec les données update
                FillDataGridViewUser();
            }
        }




        // Raffraichissement du dataGrid
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridViewUser();
        }
    }
}
