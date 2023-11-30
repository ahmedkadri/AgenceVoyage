using Agence_Voyage_Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agence_Voyage_WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitController : ControllerBase
    {
        private readonly IProduitRepository _produitRepository;
        public ProduitController(IProduitRepository produitRepository)
        {
            _produitRepository = produitRepository;
        }

        [HttpGet]
        public ActionResult GetProduit(int id)
        {
            var produit = _produitRepository.GetProduit(id);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(produit);
        }
    }
}
