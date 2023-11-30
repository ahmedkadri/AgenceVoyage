using Agence_Voyage_Database;
using Agence_Voyage_Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agence_Voyage_WebUI
{
    public class Seed
    {
        public static async Task SeedData(AgenceVoyageContext context)
        {

            if (context.Dossiers.FirstOrDefault() == null)
            {
                var dossier0 = new Dossier
                {
                    Id = 1,
                    Lieu = "Djerba",
                    DureeSejour = 7,
                    NumeroVol = 123,
                    TypeVoyage = "Touristique",
                    DateArriver = DateTime.Now
                };
                var dossier1 = new Dossier
                {
                    Id = 2,
                    Lieu = "Marrakech",
                    DureeSejour = 14,
                    NumeroVol = 456,
                    TypeVoyage = "Touristique",
                    DateArriver = DateTime.Now
                };
                var dossier2 = new Dossier
                {
                    Id = 3,
                    Lieu = "Paris",
                    DureeSejour = 30,
                    NumeroVol = 789,
                    TypeVoyage = "Mission",
                    DateArriver = DateTime.Now
                };

                var listDossier = new List<Dossier> { dossier0, dossier1, dossier2 };

                context.AddRange(listDossier);
            }

            if (context.Produits.FirstOrDefault() == null)
            {
                var produit0 = new Produit
                {
                    Id = 1,
                    Lieu = "Djerba Tunisie",
                    Adresse = "01 rue one piece",
                    NombrEtoil = 5,
                    NomHotel = "Oasis"
                };
                var produit1 = new Produit
                {
                    Id = 2,
                    Lieu = "Marrakech Maroc",
                    Adresse = "02 rue Bleach",
                    NombrEtoil = 4,
                    NomHotel = "Casa"
                };
                var produit2 = new Produit
                {
                    Id = 3,
                    Lieu = "Paris France",
                    Adresse = "03 rue Hunter",
                    NombrEtoil = 3,
                    NomHotel = "NotreDame"
                };

                var listProduit = new List<Produit> { produit0, produit1, produit2 };

                context.AddRange(listProduit);
            }

            if (context.Clients.FirstOrDefault() == null)
            {
                var client0 = new Client
                {
                    Id = 1,
                    Nom = "Ahmed",
                    Prenom = "Kadri",
                    Adresse = "Tunis",
                    Email = "ahmed.kadri@esprit.tn",
                    DateNaissance = DateTime.Now,
                    DossierId = 1,
                    ProduitId = 1
                };
                var client1 = new Client
                {
                    Id = 2,
                    Nom = "Amin",
                    Prenom = "Ouni",
                    Adresse = "Tunis",
                    Email = "Amin.Ouni@esprit.tn",
                    DateNaissance = DateTime.Now,
                    DossierId = 2,
                    ProduitId = 2
                };
                var client2 = new Client
                {
                    Id = 3,
                    Nom = "Sirine",
                    Prenom = "Kefi",
                    Adresse = "Tunis",
                    Email = "Sirine.Kefi@esprit.tn",
                    DateNaissance = DateTime.Now,
                    DossierId = 3,
                    ProduitId = 3
                };

                var listClient = new List<Client> { client0, client1, client2 };

                context.AddRange(listClient);
            }

            context.SaveChanges();
        }
    }
}
