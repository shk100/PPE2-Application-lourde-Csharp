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
        // Url de l'api de login user
        public string userLoginUrl = "http://localhost:8080/api/users/login/";


        string urlAPI = "http://localhost:8080";


        public class User
        {
            public static string mail { get; set; }
            public static string nom { get; set; }
            public static string prenom { get; set; }       // A DEPLACER DANS UNE CLASSE A LA FIN
            public static string token { get; set; }
            public static int status { get; set; }
        }




        /**                   Login                **/


        //Verification des logs de l'user
        public bool LoginApi(string mail, string pass)
        {
            var client = new RestClient(userLoginUrl + mail + "/" + pass);    // Envoi des infos
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                // Recuperation des datas et enregistrer en User
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






        /**                     Livre              **/


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


        public JArray GetBookByCategorie(string categorie)
        {
            var client = new RestClient(urlAPI + "/api/livres/bycategorie/" + categorie);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            JArray v = JArray.Parse(response.Content);


            return v;
        }


        // location d'un livre par un user
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


        // Retour d'un livre a la bibliotheque
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



        // Envoyer un message a un utilisateur
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


        // Recuperer tout les messages reçu par un utilisateur
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


        // Supprimer un message avec son id
        public void DeleteMessage(string id)
        {
            var client = new RestClient(urlAPI + "/api/messages/" + id);
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            IRestResponse response = client.Execute(request);
        }





    }
}
