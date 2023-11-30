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
    public class DossierController : ControllerBase
    {
        private readonly IDossierRepository _dossierRepository;
        public DossierController(IDossierRepository dossierRepository)
        {
            _dossierRepository = dossierRepository;
        }

        [HttpGet]
        public ActionResult GetDossier(int id)
        {
            var dossier = _dossierRepository.GetDossier(id);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(dossier);
        }
    }
}
