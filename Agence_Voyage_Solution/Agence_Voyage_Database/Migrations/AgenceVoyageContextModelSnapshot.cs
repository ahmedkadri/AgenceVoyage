﻿// <auto-generated />
using System;
using Agence_Voyage_Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Agence_Voyage_Database.Migrations
{
    [DbContext(typeof(AgenceVoyageContext))]
    partial class AgenceVoyageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("Agence_Voyage_Database.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adresse")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("TEXT");

                    b.Property<int>("DossierId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .HasColumnType("TEXT");

                    b.Property<string>("Prenom")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProduitId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Agence_Voyage_Database.Entities.Dossier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateArriver")
                        .HasColumnType("TEXT");

                    b.Property<int>("DureeSejour")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lieu")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroVol")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TypeVoyage")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Dossiers");
                });

            modelBuilder.Entity("Agence_Voyage_Database.Entities.Produit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adresse")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lieu")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomHotel")
                        .HasColumnType("TEXT");

                    b.Property<int>("NombrEtoil")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Produits");
                });
#pragma warning restore 612, 618
        }
    }
}