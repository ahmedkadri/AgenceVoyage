import { useQuery } from "react-query";
import { GraphQLClient, gql } from "graphql-request";

const API_URL = `http://localhost:4000/graphql`;

const graphQLClient = new GraphQLClient(API_URL, {
    mode: "no-cors",
    method: "post",
});

export function useGetClient(nom: string, prenom: string) {
    return useQuery(["get-client", nom, prenom], async () => {
        const getClient  = await graphQLClient.request(
            gql`
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
            `
            ,
            { nom, prenom }
        );
        return getClient;
    });
}