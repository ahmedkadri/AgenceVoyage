using Agence_Voyage_Business.ModelsDto;
using GraphQL.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Agence_Voyage_Graphql.GraphqlModels
{
    public class ClientQuery : ObjectGraphType<object>
    {
        public ClientQuery(string url)
        {
            Name = "CientQuery";

            Field<ClientType>(
                "Client",
                arguments: new QueryArguments(
                    new QueryArgument<StringGraphType> { Name = "nom"}, new QueryArgument<StringGraphType> { Name = "prenom" }),
                resolve : x =>
                {
                    try
                    {

                        using (HttpClient clienthttp = new HttpClient())
                        {
                            clienthttp.BaseAddress = new Uri(url + "Client/ClientByName?nom=" + x.GetArgument<string>("nom") + "&prenom=" + x.GetArgument<string>("prenom"));
                            clienthttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                            HttpResponseMessage response = clienthttp.GetAsync("").Result;
                            var result = JsonConvert.DeserializeObject<ClientDto>(response.Content.ReadAsStringAsync().Result);
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
