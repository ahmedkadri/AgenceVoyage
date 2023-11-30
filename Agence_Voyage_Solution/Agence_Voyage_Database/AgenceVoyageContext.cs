using Agence_Voyage_Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Agence_Voyage_Database
{
    public class AgenceVoyageContext : DbContext
    {
        public AgenceVoyageContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Dossier> Dossiers { get; set; }
        public DbSet<Produit> Produits { get; set; }
    }
}
