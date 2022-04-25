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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            FillDataGridView();
            designApp();
        }



        libraryppe.ApiController apiController = new ApiController();



        // Definition de parametre graphique du Form
        private void designApp()
        {
            dgvAdmin.BackgroundColor = Color.FromArgb(25, 35, 57);
            dgvAdmin.GridColor = Color.FromArgb(25, 35, 57);
            dgvAdmin.ForeColor = Color.White;
            dgvAdmin.DefaultCellStyle.BackColor = Color.FromArgb(25, 35, 57);
            dgvAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 35, 57);
            dgvAdmin.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }



        // Remplissage du dataGrid avec les utilisateurs
        private void FillDataGridView()
        {
            this.dgvAdmin.Rows.Clear();

            JArray content = apiController.GetAllUser();

            int tailleTableau = content.Count();
            for (int i = 0; i < tailleTableau; i++)
            {
                dgvAdmin.Rows.Add(content[i]["id"], content[i]["nom"], content[i]["prenom"], content[i]["mail"], content[i]["status"]);
            }
        }





        // Recuperation de la ligne ou est appuyer le bouton dans le dataGrid et ouverture du Form de modification utilisateur
        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                // Recuperation du mail de l'user de la ligne et stockage dans la variable activeMail pour l'utiliser dans le prochain Form
                ApiController.User.activeMail = dgvAdmin.Rows[e.RowIndex].Cells[3].Value.ToString();

                frmAdminModify modifyUserForm = new frmAdminModify();
                modifyUserForm.Show();
            }
        }




        // Déselection de la première cellule du dataGrid
        private void dgvAdmin_Paint(object sender, PaintEventArgs e)
        {
            this.dgvAdmin.ClearSelection();
        }



        // Rafraichissement du dataGrid
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }
    }
}
