using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Agence_Voyage_Database.Entities
{
    public class Client
    {
        [Key]
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
