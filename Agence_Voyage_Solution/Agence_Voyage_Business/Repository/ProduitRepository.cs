using Agence_Voyage_Business.Interfaces;
using Agence_Voyage_Business.ModelsDto;
using Agence_Voyage_Database;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agence_Voyage_Business.Repository
{
    public class ProduitRepository : IProduitRepository
    {
        private readonly AgenceVoyageContext _context;
        private readonly IMapper _mapper;
        public ProduitRepository(AgenceVoyageContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ProduitDto GetProduit(int id)
        {
            var result = _context.Produits.Find(id);
            var dtoProduit = _mapper.Map<ProduitDto>(result);
            return dtoProduit;
        }
    }
}
