﻿// <auto-generated />
using System;
using Cwiczenia11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cwiczenia11.Migrations
{
    [DbContext(typeof(DoctorsDbContext))]
    [Migration("20210128172744_AddMedicamentSeed")]
    partial class AddMedicamentSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("auto_generated")
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cwiczenia11.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDoctor");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            IdDoctor = 68866063,
                            Email = "aadamowicz@gmail.com",
                            FirstName = "Adam",
                            LastName = "Adamowicz"
                        },
                        new
                        {
                            IdDoctor = 2144717839,
                            Email = "ffilipowicz@gmail.com",
                            FirstName = "Filip",
                            LastName = "Filipowicz"
                        },
                        new
                        {
                            IdDoctor = 184093209,
                            Email = "jjanowicz@gmail.com",
                            FirstName = "Jan",
                            LastName = "Janowicz"
                        });
                });

            modelBuilder.Entity("Cwiczenia11.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMedicament");

                    b.ToTable("Medicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 25681991,
                            Description = "AA",
                            Name = "A",
                            Type = "AAA"
                        },
                        new
                        {
                            IdMedicament = 2097999038,
                            Description = "AA",
                            Name = "A",
                            Type = "AAA"
                        },
                        new
                        {
                            IdMedicament = 1884521769,
                            Description = "AA",
                            Name = "A",
                            Type = "AAA"
                        });
                });

            modelBuilder.Entity("Cwiczenia11.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPatient");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            IdPatient = 2125128178,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Anna",
                            LastName = "Annawska"
                        },
                        new
                        {
                            IdPatient = 708426475,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jadwiga",
                            LastName = "Jadwigowska"
                        },
                        new
                        {
                            IdPatient = 883142738,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Justyna",
                            LastName = "Justynowska"
                        });
                });

            modelBuilder.Entity("Cwiczenia11.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.Property<int?>("doctorIdDoctor")
                        .HasColumnType("int");

                    b.Property<int?>("patientIdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription");

                    b.HasIndex("doctorIdDoctor");

                    b.HasIndex("patientIdPatient");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("Cwiczenia11.Models.Prescription_Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPrescription");

                    b.HasIndex("IdPrescription");

                    b.ToTable("Prescription_Medicaments");
                });

            modelBuilder.Entity("Cwiczenia11.Models.Prescription", b =>
                {
                    b.HasOne("Cwiczenia11.Models.Doctor", "doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("doctorIdDoctor");

                    b.HasOne("Cwiczenia11.Models.Patient", "patient")
                        .WithMany()
                        .HasForeignKey("patientIdPatient");
                });

            modelBuilder.Entity("Cwiczenia11.Models.Prescription_Medicament", b =>
                {
                    b.HasOne("Cwiczenia11.Models.Medicament", "medicament")
                        .WithMany()
                        .HasForeignKey("IdMedicament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cwiczenia11.Models.Prescription", "prescription")
                        .WithMany("prescription_Medicaments")
                        .HasForeignKey("IdPrescription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}