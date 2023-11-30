using System;
using System.Collections.Generic;
using System.Text;

namespace Agence_Voyage_Business.ModelsDto
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Email { get; set; }
        public int DossierId { get; set; }
        public int ProduitId { get; set; }
    }
}
