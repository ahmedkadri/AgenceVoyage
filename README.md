# Agence Voyage
### React typeScript/graphql-request/react-query
### .Net-Core EF/Swagger/RestAPI 
### Docker 
### Sqlite

## Lancer le Projet

1) **Telecharger le projet.**
2) **ouvrir le terminal et lancez le commandes suivante (projet React) :**
   1) cd agence_react
   2) docker build -t agence-voyage-react -f .\Dockerfile .
   3) docker run -p 3000:80/tcp agence-voyage-react
   4) url : "http://localhost:3000"
3) **ouvrir un autre terminal pour lancer le projet Web-API :**
   1) cd Agence_Voyage_Solution
   2) docker build -f .\Agence_Voyage_WebUI\Dockerfile -t webui_project .
   3) docker run -p 2000:80/tcp webui_project
   4) url : http://localhost:2000/swagger
4) **ouvrir un autre terminal pour lancer le projet Web-Graphql :**
   1) cd Agence_Voyage_Solution
   2) docker build -f .\Agence_Voyage_Graphql\Dockerfile -t graphql_project .
   3) docker run -p 4000:80/tcp graphql_project
   4) url : http://localhost:4000/graphql
  
>  [!WARNING]
>  ***si le projet ne retourne pas le resultat attendue veiller juste arreter l'image graphql_project et lancer le projet 'Agence_Voyage_Graphql' en locale !!!***


pour tester avec Graphiql ouvrir url http://localhost:4000/graphql et ajouter cette requette :

```
  query Client($nom: String, $prenom: String){
                  client(nom:$nom, prenom:$prenom){
                  
                    id,
                    adresse,
                    dateNaissance,
                    email,
                    nom,
                    prenom,
                    produitId,
                    dossierId,
                    dossier {
                      dateArriver,
                      dureeSejour,
                      lieu,
                      typeVoyage
                    },
                    produit {
                      adresse,
                      lieu,
                      nomHotel,
                      nombrEtoil
                    }

                  }
                }

    variable : {"nom":"ahmed","prenom":"kadri"}
```

> [!TIP]
> pour lancer tous les projet locale pour la patie react sur la console lancer la cmd ***npm start***
> et pour la partie back il faut lancer les 2 projets **Agence_Voyage_Graphql** et **Agence_Voyage_WebUI** en parallèle !
> voici des Screenshot :
