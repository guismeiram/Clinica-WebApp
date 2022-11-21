﻿// <auto-generated />
using System;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DevIO.Data.Migrations
{
    [DbContext(typeof(ClinicaDbContext))]
    partial class ClinicaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DevIO.Bussines.Models.Clinica", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Ddd")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Clinica");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Consulta", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
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

                    b.HasIndex("ClinicaId")
                        .IsUnique();

                    b.HasIndex("MedicoId")
                        .IsUnique();

                    b.HasIndex("PacienteId")
                        .IsUnique();

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Especialidade", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Especialidade");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Medico", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Crm")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Ddd")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Idade")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Medico", (string)null);
                });

            modelBuilder.Entity("DevIO.Bussines.Models.MedicoEspecialidade", b =>
                {
                    b.Property<string>("EspecialidadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("MedicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Id")
                        .HasColumnType("varchar(100)");

                    b.HasKey("EspecialidadeId", "MedicoId");

                    b.HasIndex("MedicoId");

                    b.ToTable("MedicoEspecialidade");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Paciente", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Ddd")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Idade")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Consulta", b =>
                {
                    b.HasOne("DevIO.Bussines.Models.Clinica", "Clinica")
                        .WithOne("Consultas")
                        .HasForeignKey("DevIO.Bussines.Models.Consulta", "ClinicaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DevIO.Bussines.Models.Medico", "Medico")
                        .WithOne("Consultas")
                        .HasForeignKey("DevIO.Bussines.Models.Consulta", "MedicoId")
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
                    b.Navigation("Consultas")
                        .IsRequired();
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Especialidade", b =>
                {
                    b.Navigation("Medicos");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Medico", b =>
                {
                    b.Navigation("Consultas")
                        .IsRequired();

                    b.Navigation("Especialidades");
                });

            modelBuilder.Entity("DevIO.Bussines.Models.Paciente", b =>
                {
                    b.Navigation("Consulta")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
