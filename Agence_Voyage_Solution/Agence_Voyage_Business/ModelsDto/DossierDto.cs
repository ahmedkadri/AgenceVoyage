using System;
using System.Collections.Generic;
using System.Text;

namespace Agence_Voyage_Business.ModelsDto
{
    public class DossierDto
    {
        public int Id { get; set; }
        public string TypeVoyage { get; set; }
        public DateTime DateArriver { get; set; }
        public int DureeSejour { get; set; }
        public int NumeroVol { get; set; }
        public string Lieu { get; set; }
    }
}
