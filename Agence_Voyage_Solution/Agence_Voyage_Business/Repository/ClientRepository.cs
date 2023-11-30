using Agence_Voyage_Business.Interfaces;
using Agence_Voyage_Business.ModelsDto;
using Agence_Voyage_Database;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agence_Voyage_Business.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly AgenceVoyageContext _context;
        private readonly IMapper _mapper;

        public ClientRepository(AgenceVoyageContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ClientDto GetClient(string nom, string prenom)
        {
            var result = _context.Clients.Where(i => i.Nom.ToUpper() == nom.ToUpper() && i.Prenom.ToUpper() == prenom.ToUpper()).FirstOrDefault();
            var dtoClient = _mapper.Map<ClientDto>(result);
            return dtoClient;
        }
    }
}
