using System;
using System.Collections.Generic;
using System.Text;

namespace Agence_Voyage_Business.ModelsDto
{
    public class ProduitDto
    {
        public int Id { get; set; }
        public string NomHotel { get; set; }
        public string Adresse { get; set; }
        public string Lieu { get; set; }
        public int NombrEtoil { get; set; }
    }
}
