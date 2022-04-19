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
    public partial class frmBibliotheque : Form
    {
        public frmBibliotheque()
        {
            InitializeComponent();
            FillDataGridViewAll();
        }

        libraryppe.ApiController apiController = new ApiController();

        string actualCategory;
        const string fiction = "fiction";
        const string horreur = "horreur";
        const string fantasy = "fantasy";
        const string romantique = "romantique";




        // Remplit le dataGrid avec les tout les livres
        public void FillDataGridViewAll()
        {
            actualCategory = "all";
            this.dgvBibliotheque.Rows.Clear();  // On clear le data grid

            JArray content = apiController.GetAllBook();
            string tmpDispo;
            int tailleTableau = content.Count();


            for (int i = 0; i<tailleTableau; i++)
            {
                if (content[i]["disponible"].ToString() == "1")
                {
                    tmpDispo = "oui";
                }
                else
                {
                    tmpDispo = "non";
                }
                dgvBibliotheque.Rows.Add(content[i]["titre"], content[i]["auteur"], content[i]["annee"], content[i]["categorie"], tmpDispo);
            }

        }

        private void FillDataGridViewCategorie(string categorie)
        {
            actualCategory = categorie;
            this.dgvBibliotheque.Rows.Clear();    // On clear le data grid

            JArray content = apiController.GetBookByCategorie(categorie);

            string tmpDispo;
            int tailleTableau = content.Count();


            for (int i = 0; i < tailleTableau; i++)
            {
                if (content[i]["disponible"].ToString() == "1")
                {
                    tmpDispo = "oui";
                }
                else
                {
                    tmpDispo = "non";
                }
                dgvBibliotheque.Rows.Add(content[i]["titre"], content[i]["auteur"], content[i]["annee"], content[i]["categorie"], tmpDispo);
            }
        }






        // Remplir le dataGrid avec les differentes categorie de livre
        private void buttonAll_Click(object sender, EventArgs e)
        {
            FillDataGridViewAll();
        }

        private void buttonFiction_Click(object sender, EventArgs e)
        {
            FillDataGridViewCategorie("fiction");
        }

        private void buttonHorreur_Click(object sender, EventArgs e)
        {
            FillDataGridViewCategorie("horreur");
        }

        private void buttonFantasy_Click(object sender, EventArgs e)
        {
            FillDataGridViewCategorie("fantasy");
        }

        private void buttonRomantique_Click(object sender, EventArgs e)
        {
            FillDataGridViewCategorie("romantique");
        }



        // Location du livre par l'user en appuyant sur le bouton de la ligne
        private void dgvBibliotheque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string disponible = "oui";

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                // Recuperation du titre du livre
                string test = dgvBibliotheque.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Si le livre est disponible :
                if (dgvBibliotheque.Rows[e.RowIndex].Cells[4].Value.ToString() == disponible )
                {
                    // Attribution du livre a un user et changement de la disponible en 0
                    apiController.RentBookUser(test, ApiController.User.mail);

                    if (actualCategory == "all")
                    {
                        FillDataGridViewAll();
                    }
                    else if (actualCategory == fiction)
                    {
                        FillDataGridViewCategorie(fiction);
                    }
                    else if (actualCategory == horreur)
                    {
                        FillDataGridViewCategorie(horreur);
                    }
                    else if (actualCategory == fantasy)
                    {
                        FillDataGridViewCategorie(fantasy);
                    }
                    else if (actualCategory == romantique)
                    {
                        FillDataGridViewCategorie(romantique);
                    }
                    MessageBox.Show("Le livre a bien ete loué au nom de : " + ApiController.User.nom);
                }    
                // Si le livre n'est pas disponible :
                else
                {
                    MessageBox.Show("Le livre n'est actuellement pas disponible !");
                }
               
            }
        }
    }
}
