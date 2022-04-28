﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tp2POA.Models;

#nullable disable

namespace Tp2POA.Migrations
{
    [DbContext(typeof(Tp2POAContext))]
    [Migration("20220428055928_Migrations")]
    partial class Migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Tp2POA.Models.Medecin", b =>
                {
                    b.Property<int>("MedecinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDeNaissance")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateEntreeFonction")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Mdp")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MedecinId");

                    b.ToTable("Medecins");
                });

            modelBuilder.Entity("Tp2POA.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDeNaissance")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Diagnostic")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
