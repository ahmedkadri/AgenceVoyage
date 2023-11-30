using Agence_Voyage_Business.ModelsDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agence_Voyage_Business.Interfaces
{
    public interface IClientRepository
    {
        public ClientDto GetClient(string nom, string prenom);
    }
}
