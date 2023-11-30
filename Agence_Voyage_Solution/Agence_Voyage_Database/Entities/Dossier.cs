using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Agence_Voyage_Database.Entities
{
    public class Dossier
    {
        [Key]
        public int Id { get; set; }
        public string TypeVoyage { get; set; }
        public DateTime DateArriver { get; set; }
        public int DureeSejour { get; set; }
        public int NumeroVol { get; set; }
        public string Lieu { get; set; }
    }
}
