using Agence_Voyage_Business.ModelsDto;
using Agence_Voyage_Database.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agence_Voyage_Business.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Client, ClientDto>();
            CreateMap<Dossier, DossierDto>();
            CreateMap<Produit, ProduitDto>();
        }
    }
}
