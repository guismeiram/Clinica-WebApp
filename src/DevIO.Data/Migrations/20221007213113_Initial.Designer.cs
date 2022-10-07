﻿// <auto-generated />
using System;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DevIO.Data.Migrations
{
    [DbContext(typeof(ClinicaDbContext))]
    [Migration("20221007213113_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DevIO.Bussines.Models.Clinica", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Clinica");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Consulta", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ClinicaId")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("MedicoId")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PacienteId")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ClinicaId");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId")
                        .IsUnique();

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Endereco", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("MedicoId")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Especialidade", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Especialidades")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Especialidade");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Medico", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Crm")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Idade")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Medico", (string)null);
                });

            modelBuilder.Entity("DevIO.Bussines.Models.MedicoEspecialidade", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("EspecialidadeId")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("MedicoId")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadeId");

                    b.HasIndex("MedicoId");

                    b.ToTable("MedicoEspecialidade");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Paciente", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Consulta", b =>
                {
                    b.HasOne("DevIO.Bussines.Models.Clinica", "Clinica")
                        .WithMany("Consultas")
                        .HasForeignKey("ClinicaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DevIO.Bussines.Models.Medico", "Medico")
                        .WithMany("Consultas")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DevIO.Bussines.Models.Paciente", "Paciente")
                        .WithOne("Consulta")
                        .HasForeignKey("DevIO.Bussines.Models.Consulta", "PacienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Clinica");

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Endereco", b =>
                {
                    b.HasOne("DevIO.Bussines.Models.Medico", "Medico")
                        .WithOne("Endereco")
                        .HasForeignKey("DevIO.Bussines.Models.Endereco", "MedicoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.MedicoEspecialidade", b =>
                {
                    b.HasOne("DevIO.Bussines.Models.Especialidade", "Especialidade")
                        .WithMany("Medicos")
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DevIO.Bussines.Models.Medico", "Medico")
                        .WithMany("Especialidades")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Especialidade");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Clinica", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Especialidade", b =>
                {
                    b.Navigation("Medicos");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Medico", b =>
                {
                    b.Navigation("Consultas");

                    b.Navigation("Endereco")
                        .IsRequired();

                    b.Navigation("Especialidades");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Paciente", b =>
                {
                    b.Navigation("Consulta");
                });
#pragma warning restore 612, 618
        }
    }
}