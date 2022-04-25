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
    public partial class frmLivreUser : Form
    {
        public frmLivreUser()
        {
            InitializeComponent();
            FillInformation();
            designApp();
        }

        string selectedUser = ApiController.User.activeMail;

        libraryppe.ApiController apiController = new ApiController();


        //Definition des parametrres graphique du Form
        private void designApp()
        {
            dgvLivre.BackgroundColor = Color.FromArgb(25, 35, 57);
            dgvLivre.GridColor = Color.FromArgb(25, 35, 57);
            dgvLivre.ForeColor = Color.White;
            dgvLivre.DefaultCellStyle.BackColor = Color.FromArgb(25, 35, 57);
            dgvLivre.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 35, 57);
            dgvLivre.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }



        // Remplissage du dataGrid avec les livres
        private void FillInformation()
        {
            labelUser.Text = selectedUser;

            apiController.GetBookByUser(selectedUser);

            JArray content = apiController.GetBookByUser(selectedUser);

            int tailleTableau = content.Count();
            for (int i = 0; i < tailleTableau; i++)
            {
                dgvLivre.Rows.Add(content[i]["titre"], content[i]["auteur"], content[i]["annee"], content[i]["categorie"]);
            }
        }

        // Déselection de la premiere celulle du dataGrid
        private void dgvLivre_Paint(object sender, PaintEventArgs e)
        {
            this.dgvLivre.ClearSelection();
        }
    }
}
