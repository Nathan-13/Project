﻿// <auto-generated />
using System;
using HMSystem.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HMSystemMvc.Migrations
{
    [DbContext(typeof(HospitalContext))]
    [Migration("20201216013818_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("HMSystem.Storage.EFModels.Bill", b =>
                {
                    b.Property<Guid>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DischargeDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsBillsPaid")
                        .HasColumnType("boolean");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("uuid");

                    b.Property<double>("TotalBill")
                        .HasColumnType("double precision");

                    b.HasKey("BillId");

                    b.HasIndex("PatientId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("HMSystem.Storage.EFModels.Doctor", b =>
                {
                    b.Property<Guid>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<bool>("IsDoctorBooked")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int>("NumberOfPatient")
                        .HasColumnType("integer");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Specialization")
                        .HasColumnType("text");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("HMSystem.Storage.EFModels.Patient", b =>
                {
                    b.Property<Guid>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<double>("BillPerDay")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("DateAdmitted")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<char>("Gender")
                        .HasColumnType("character(1)");

                    b.Property<bool>("IsCheckedOut")
                        .HasColumnType("boolean");

                    b.Property<double>("LabFees")
                        .HasColumnType("double precision");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<double>("MedicationFees")
                        .HasColumnType("double precision");

                    b.Property<int>("PatientDaysInHospital")
                        .HasColumnType("integer");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<double>("RehabFees")
                        .HasColumnType("double precision");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uuid");

                    b.Property<string>("Symptom")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("PatientId");

                    b.HasIndex("RoomId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("HMSystem.Storage.EFModels.Room", b =>
                {
                    b.Property<Guid>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("IsRoomBooked")
                        .HasColumnType("boolean");

                    b.Property<char>("RoomIsClean")
                        .HasColumnType("character(1)");

                    b.Property<string>("RoomLocation")
                        .HasColumnType("text");

                    b.Property<char>("RoomStatus")
                        .HasColumnType("character(1)");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HMSystem.Storage.EFModels.Symptom", b =>
                {
                    b.Property<Guid>("SymptomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uuid");

                    b.Property<string>("SymptomName")
                        .HasColumnType("text");

                    b.HasKey("SymptomId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Symptoms");
                });

            modelBuilder.Entity("HMSystem.Storage.EFModels.Bill", b =>
                {
                    b.HasOne("HMSystem.Storage.EFModels.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HMSystem.Storage.EFModels.Patient", b =>
                {
                    b.HasOne("HMSystem.Storage.EFModels.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HMSystem.Storage.EFModels.Symptom", b =>
                {
                    b.HasOne("HMSystem.Storage.EFModels.Doctor", "Doctor")
                        .WithMany("Symptoms")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}