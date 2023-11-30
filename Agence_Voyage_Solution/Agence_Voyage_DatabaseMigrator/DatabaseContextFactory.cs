using Agence_Voyage_Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Agence_Voyage_DatabaseMigrator
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<AgenceVoyageContext>
    {
        public AgenceVoyageContext CreateDbContext(string[] args)
        {
            string path = Directory.GetCurrentDirectory();

            var builder = new ConfigurationBuilder()
                               .SetBasePath(path)
                               .AddJsonFile("local.settings.json");

            var configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");

            var options = new DbContextOptionsBuilder<AgenceVoyageContext>()
                            .UseSqlite(connectionString).Options;

            return new AgenceVoyageContext(options);
        }
    }
}
