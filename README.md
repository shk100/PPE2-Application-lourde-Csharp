# PPE2-Application-lourde-Csharp
Projet final de BTS SIO PPE2 qui est une application lourde C# en Windows Form qui se connecte a une API en Node-JS qui represente une simulation de bibliotheque.

Dans cette application, il est possible de réaliser plusieurs actions.

- Consulter la liste des livres disponibles ainsi que de pouvoir les louer.
- Gerer les livres actuellement louer et les rendre.
- Consulter ses messages et contacter un administrateur.
- Consulter la liste d'utilisateur et acceder aux livres en leur possession.
- Modifier les données personnelles des utilisateurs.
- Envoyer un message a un utilisateur particulier.

Il existe trois type de status utilisateur : admin , responsable et utilisateur avec des acces differents les uns des autres.
Toutes les données de l'utilisateur sont stockées dans la classe User apres l'authentification.
Le fichier ApiController contient toutes les fonctions de requête HTTP vers l'API de l'application.


Plusieurs bibliothèques ont été utilisé :

REST SHARP :

Rest Sharp a été utilisé dans ce projet pour faciliter les échanges entre l'API et le client C#.
C'est une librairie open-source de client HTTP qui fonctionne avec .NET qui sert à gérer de manière simplifiée et propre l'accès aux données d'une API.
https://restsharp.dev


NEWTONSOFT.JSON :

Newtonsoft.Json a été utilisé dans ce projet pour gérer les data de retour de l'API qui sont dans un format IRestReponse avec Rest Sharp afin de pouvoir les déserialiser et sérialiser en stockant les datas sous forme de tableau ou d'objet Json.
https://wwww.newtonsoft.com/json



