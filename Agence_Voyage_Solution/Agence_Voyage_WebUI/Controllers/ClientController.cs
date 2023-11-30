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
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;
        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpGet("ClientByName")]
        public ActionResult GetClient(string nom, string prenom)
        {
            var client = _clientRepository.GetClient(nom, prenom);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(client);
        }
    }
}
