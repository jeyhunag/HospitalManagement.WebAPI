﻿// <auto-generated />
using System;
using HospitalManagement.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HospitalMenegment.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HospitalMenegment.DAL.DbModels.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("appointment_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("appointment_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("appointment_number")
                        .HasColumnType("int");

                    b.Property<string>("appointment_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("appointments");
                });

            modelBuilder.Entity("HospitalMenegment.DAL.DbModels.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("doctor_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doctor_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doctor_mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doctor_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doctor_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doctor_speciast")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doctor_username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("doctors");
                });

            modelBuilder.Entity("HospitalMenegment.DAL.DbModels.Hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("hospital_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hospital_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hospital_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hospital_place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hospital_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("hospitals");
                });

            modelBuilder.Entity("HospitalMenegment.DAL.DbModels.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("medicine_company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medicine_composition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medicine_cost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medicine_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medicine_dose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medicine_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medicine_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("medicines");
                });

            modelBuilder.Entity("HospitalMenegment.DAL.DbModels.Nurse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("nurse_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nurse_duty_hour")
                        .HasColumnType("int");

                    b.Property<string>("nurse_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nurse_mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nurse_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nurse_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nurse_username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("nurses");
                });

            modelBuilder.Entity("HospitalMenegment.DAL.DbModels.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("patient_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("patient_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("patient_blood_group")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("patient_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("patient_mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("patient_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("patient_username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("patients");
                });

            modelBuilder.Entity("HospitalMenegment.DAL.DbModels.Appointment", b =>
                {
                    b.HasOne("HospitalMenegment.DAL.DbModels.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("HospitalMenegment.DAL.DbModels.Doctor", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
