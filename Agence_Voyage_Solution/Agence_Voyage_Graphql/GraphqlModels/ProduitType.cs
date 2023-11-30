using Agence_Voyage_Business.ModelsDto;
using GraphQL.Types;

namespace Agence_Voyage_Graphql.GraphqlModels
{
    public class ProduitType : ObjectGraphType<ProduitDto>
    {
        public ProduitType()
        {
            Field(x => x.Id);
            Field(x => x.NomHotel);
            Field(x => x.Adresse);
            Field(x => x.Lieu);
            Field(x => x.NombrEtoil);
        }
    }
}
