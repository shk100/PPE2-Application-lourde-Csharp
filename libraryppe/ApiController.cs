using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace libraryppe
{
    public class ApiController
    {

        // URL de l'API
        string urlAPI = "http://localhost:8080";


        // Classe User qui permet de stocker les informations de l'utilisateur après la connexion dans toute l'application
        public class User
        {
            public static string mail { get; set; }
            public static string nom { get; set; }
            public static string prenom { get; set; }     
            public static string token { get; set; }
            public static int status { get; set; }
            public static string activeMail { get; set; }
        }




        /**                   USER               **/


        //Verification des identifiants de l'utilisateur
        public bool LoginApi(string mail, string pass)
        {
            var client = new RestClient(urlAPI + "/api/users/login/" + mail + "/" + pass);    // Envoi des infos
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                // Recuperation des datas et enregistrement dans la classe User
                dynamic data = JObject.Parse(response.Content);
                User.mail = data.mail;
                User.nom = data.nom;
                User.prenom = data.prenom;
                User.token = data.token;
                User.status = data.status;
                return true;
            }
            else
            {
                return false;
            }
        }


        // Enregistrement d'un nouvel user 
        public bool RegisterApi(string nom, string prenom, string mail, string pass)
        {
            var client = new RestClient(urlAPI + "/api/users");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("nom", nom);
            request.AddParameter("prenom", prenom);
            request.AddParameter("mail", mail);
            request.AddParameter("pass", pass);
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Récupération de tous les users
        public JArray GetAllUser()
        {
            var client = new RestClient(urlAPI + "/api/users");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            IRestResponse response = client.Execute(request);
            JArray v = JArray.Parse(response.Content);

            return v;
        }



        // Récupération des informations d'un seul utilisateur avec son mail
        public JObject GetOneUser(string user)        // Utilisation d'un JObject plutot qu'un JArray car il y a qu'un seul retour
        {
            var client = new RestClient(urlAPI + "/api/users/" + user);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            JObject v = JObject.Parse(response.Content);

            return v;
        }


        // Modification d'un utilisateur avec son mail

        public void UpdateUserInformation(string user, string newNom, string newPrenom, string newMail, string newStatus)
        {
            var client = new RestClient(urlAPI + "/api/users/" + user);
            client.Timeout = -1;
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("nom", newNom);
            request.AddParameter("prenom", newPrenom);
            request.AddParameter("mail", newMail);
            request.AddParameter("status", newStatus);
            IRestResponse response = client.Execute(request);
        }











        /**                     Livre              **/




        // Récupération de tout les livres
        public JArray GetAllBook()
        {
            var client = new RestClient(urlAPI + "/api/livres/");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            JArray v = JArray.Parse(response.Content);
         //   dynamic data = JObject.Parse(response.Content);
            return v;
        }



        // Récupération des livres par catégorie
        public JArray GetBookByCategorie(string categorie)
        {
            var client = new RestClient(urlAPI + "/api/livres/bycategorie/" + categorie);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            JArray v = JArray.Parse(response.Content);

            return v;
        }


        // Location d'un livre par un utilisateur
        public void RentBookUser(string titre, string user)
        {
            int plusDisponible = 0;
            var client = new RestClient(urlAPI + "/api/livres/" + titre);
            client.Timeout = -1;
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("user", user);
            request.AddParameter("disponible", plusDisponible);
            IRestResponse response = client.Execute(request);
        }


        // Retour d'un livre à la bibliotheque
        public void ReturnBookUser(string titre)
        {
            int Disponible = 1;
            var client = new RestClient(urlAPI + "/api/livres/location/" + titre);
            client.Timeout = -1;
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("user", "");
            request.AddParameter("disponible", Disponible);
            IRestResponse response = client.Execute(request);
        }

        // Récupération des livres loués par un user
        public JArray GetBookByUser(string user)
        {
            var client = new RestClient(urlAPI + "/api/livres/location/" + user);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            JArray v = JArray.Parse(response.Content);
            
            return v;
        }








        /**                     Message                **/



        // Envoyer un message à un utilisateur
        public void SendMessage(string sujet, string auteur, string destinataire, string message)
        {
            var client = new RestClient(urlAPI + "/api/messages/");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("sujet", sujet);
            request.AddParameter("auteur", auteur);
            request.AddParameter("destinataire", destinataire);
            request.AddParameter("message", message);
            IRestResponse response = client.Execute(request);
        }


        // Récupérer tous les messages reçus par un utilisateur
        public JArray GetAllMessage(string user)
        {
            var client = new RestClient(urlAPI + "/api/messages/" + user);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            IRestResponse response = client.Execute(request);

            JArray v = JArray.Parse(response.Content);

            return v;
        }


        // Supprimer un message avec son ID
        public void DeleteMessage(string id)
        {
            var client = new RestClient(urlAPI + "/api/messages/" + id);
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            IRestResponse response = client.Execute(request);
        }





    }
}
