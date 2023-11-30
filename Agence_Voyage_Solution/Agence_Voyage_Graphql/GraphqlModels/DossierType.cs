using Agence_Voyage_Business.ModelsDto;
using Agence_Voyage_Database.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agence_Voyage_Graphql.GraphqlModels
{
    public class DossierType : ObjectGraphType<DossierDto>
    {
        public DossierType()
        {
            Field(x => x.Id);
            Field(x => x.TypeVoyage);
            Field(x => x.DateArriver);
            Field(x => x.DureeSejour);
            Field(x => x.NumeroVol);
            Field(x => x.Lieu);
        }
    }
}
