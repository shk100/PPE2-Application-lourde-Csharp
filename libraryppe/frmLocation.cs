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
        }


        libraryppe.ApiController apiController = new ApiController();
       

        private void dgvlou_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void FillDataGridViewUser()
        {
            this.dgvLocation.Rows.Clear();  // On clear le data grid
            string currentUser = ApiController.User.mail;

            JArray content = apiController.GetBookByUser(ApiController.User.mail);

            int tailleTableau = content.Count();


            for (int i = 0; i < tailleTableau; i++)
            {
                dgvLocation.Rows.Add(content[i]["titre"], content[i]["auteur"], content[i]["annee"], content[i]["categorie"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillDataGridViewUser();
        }

        private void dgvLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                // Recuperation du titre du livre
                string titreLivre = dgvLocation.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Retour du livre a la bibliotheque et disponibilité sur oui
                apiController.ReturnBookUser(titreLivre);

                MessageBox.Show("Votre livre à bien été rendu !");

                // Recharge du dataGrid avec les données update
                FillDataGridViewUser();
            }
        }
    }
}
