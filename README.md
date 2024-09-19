
<div class=" align-items-center">
  <h1>Zoo Arcadia</h1>
  <p>Site vitrine pour le zoo Arcadia résultat de l'ECF de Studi. Le site présente les différents services et habitats proposés dans le zoo.</p>
  <p>L'interface administrateur et employé permettent de gérer le site.</p>

</div>

### URLs du Déploiement

Le site a été déployé sur l'outil <img height="15" src="https://global.discourse-cdn.com/business6/uploads/render/original/2X/1/11352202c8503f736bea5efb59684f678d7c860c.svg"> [**Render**](https://render.com/) aux adresses suivantes : 
  - Front : (https://zoo-arcadia-ufm9.onrender.com)
  - Back : https://arcadia-back-bikt.onrender.com/swagger


### Modules

- <img height="15" src="https://user-images.githubusercontent.com/25181517/183890595-779a7e64-3f43-4634-bad2-eceef4e80268.png"> Angular web app
- <img height="15" src="https://user-images.githubusercontent.com/25181517/121405754-b4f48f80-c95d-11eb-8893-fc325bde617f.png"> .NET API

## Technologies utilisées

- <img height="15" src="https://user-images.githubusercontent.com/25181517/183890595-779a7e64-3f43-4634-bad2-eceef4e80268.png"> [**Angular 18**](https://angular.dev/) pour le frontend

- <img height="15" src="https://user-images.githubusercontent.com/25181517/183898054-b3d693d4-dafb-4808-a509-bab54cf5de34.png"> [**Bootstrap**](https://getbootstrap.com/) pour les styles

- <img height="15" src="https://user-images.githubusercontent.com/25181517/183890598-19a0ac2d-e88a-4005-a8df-1ee36782fde1.png"> [**TypeScript**](https://www.typescriptlang.org/) pour améliorer les scripts <img height="15" src="https://user-images.githubusercontent.com/25181517/117447155-6a868a00-af3d-11eb-9cfe-245df15c9f3f.png"> [**JavaScript**](https://www.javascript.com/)
    [text](README.md)

## Mode d'emploi

### Technologies requises

- <img height="15" src="https://user-images.githubusercontent.com/25181517/183568594-85e280a7-0d7e-4d1a-9028-c8c2209e073c.png"> [**Node**](https://nodejs.org/en/download/current)
- <img height="15" src="https://user-images.githubusercontent.com/25181517/121401671-49102800-c959-11eb-9f6f-74d49a5e1774.png"> [**npm**](https://docs.npmjs.com/downloading-and-installing-node-js-and-npm)
- <img height="15" src="https://user-images.githubusercontent.com/25181517/121405754-b4f48f80-c95d-11eb-8893-fc325bde617f.png"> [**.NET SDK**](https://dotnet.microsoft.com/en-us/download/dotnet)

- <img height="15" src="https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Git_icon.svg/1200px-Git_icon.svg.png"> [**Git**](https://git-scm.com/) 

- <img height="15" src="https://user-images.githubusercontent.com/25181517/192108891-d86b6220-e232-423a-bf5f-90903e6887c3.png"> [**Visual Studio Code**](https://code.visualstudio.com)

N'oubliez pas d'ajouter les chemins d'angular et node au PATH de vos environnements variables si besoin.

### Lancer l'application

Pour démarrer l'application la première fois, veuillez exécuter sur un terminal git bash le script suivant dans le répertoire de l'application :

```bash
./first_launch.sh
```

ou cliquez sur le fichier **first_launch.bat**

Ce script vous placera sur la branche démo qui gère la base de données de façon "in-memory" pour que les données apparaissent malgré l'initialisation en local


Puis à chaque nouvelle initialisation, veuillez exécuter le script suivant dans le répertoire de l'application :

```bash
./launch_scripts.sh
```

ou cliquez sur le fichier **launch_scripts.bat** (veillez à être placé sur la branche démo)

### Utilisateurs

**Admin** 

email : admin@zoo-arcadia.com  |  mot de passe : Admin0001

**Employé** 

email : employee@zoo-arcadia.com  |  mot de passe : Employee0001

**Note**:

- L'application **Angular**<img height="15" src="https://user-images.githubusercontent.com/25181517/183890595-779a7e64-3f43-4634-bad2-eceef4e80268.png"> démarrera sur http://localhost:4200
- L'API **.NET** <img height="15" src="https://user-images.githubusercontent.com/25181517/121405754-b4f48f80-c95d-11eb-8893-fc325bde617f.png"> démarrera sur https://localhost:7096 (avec <img height="15" src="https://user-images.githubusercontent.com/25181517/186711335-a3729606-5a78-4496-9a36-06efcc74f800.png"> [**Swagger**](https://swagger.io/) sur https://localhost:7096/swagger)
