using Agence_Voyage_Database.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Agence_Voyage_Business.ModelsDto;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Agence_Voyage_Graphql.GraphqlModels
{
    public class ClientType : ObjectGraphType<ClientDto>
    {
        public ClientType(string url)
        {
            Field(x => x.Id);
            Field(x => x.Nom);
            Field(x => x.Prenom);
            Field(x => x.Adresse);
            Field(x => x.DateNaissance);
            Field(x => x.Email);
            Field(x => x.ProduitId);
            Field(x => x.DossierId);

            Field<DossierType>(
                "Dossier",
                resolve : x =>
                {
                    try
                    {

                        using(HttpClient clienthttp = new HttpClient())
                        {
                            clienthttp.BaseAddress = new Uri(url + "dossier?id=" + x.Source.DossierId);
                            clienthttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            HttpResponseMessage response = clienthttp.GetAsync("").Result;
                            var result = JsonConvert.DeserializeObject<DossierDto>(response.Content.ReadAsStringAsync().Result);
                            return result;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                );

            Field<ProduitType>(
                "Produit",
                resolve: x =>
                {
                    try
                    {

                        using (HttpClient clienthttp = new HttpClient())
                        {
                            clienthttp.BaseAddress = new Uri(url + "produit?id=" + x.Source.ProduitId);
                            clienthttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            HttpResponseMessage response = clienthttp.GetAsync("").Result;
                            var result = JsonConvert.DeserializeObject<ProduitDto>(response.Content.ReadAsStringAsync().Result);
                            return result;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                );
        }
    }
}
