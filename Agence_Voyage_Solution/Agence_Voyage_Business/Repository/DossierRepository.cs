using Agence_Voyage_Business.Interfaces;
using Agence_Voyage_Business.ModelsDto;
using Agence_Voyage_Database;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agence_Voyage_Business.Repository
{
    public class DossierRepository : IDossierRepository
    {
        private readonly AgenceVoyageContext _context;
        private readonly IMapper _mapper;

        public DossierRepository(AgenceVoyageContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public DossierDto GetDossier(int id)
        {
            var result = _context.Dossiers.Find(id);
            var dtoDossier = _mapper.Map<DossierDto>(result);
            return dtoDossier;
        }
    }
}
