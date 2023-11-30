using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agence_Voyage_Graphql.GraphqlModels
{
    public class ClientSchema : Schema
    {
        public ClientSchema(IDependencyResolver resolver)
        {
            Query = resolver.Resolve<ClientQuery>();
            DependencyResolver = resolver;
        }
    }
}
