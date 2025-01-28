﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatientManagement.Infrastructure.StoredModel;

#nullable disable

namespace PatientManagement.Infrastructure.Migrations
{
    [DbContext(typeof(StoredDbContext))]
    [Migration("20241218064033_patientMod2")]
    partial class patientMod2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("PatientManagement.Infrastructure.StoredModel.Entities.PatientStoredModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("patientId");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("birthDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("email");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("gender");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("patient");
                });

            modelBuilder.Entity("PatientManagement.Infrastructure.StoredModel.Entities.PhoneStoredModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("phoneId");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("number");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("char(36)")
                        .HasColumnName("patientId");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("phone");
                });

            modelBuilder.Entity("PatientManagement.Infrastructure.StoredModel.Entities.UserStoredModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("userId");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("fullName");

                    b.HasKey("Id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("PatientManagement.Infrastructure.StoredModel.Entities.PhoneStoredModel", b =>
                {
                    b.HasOne("PatientManagement.Infrastructure.StoredModel.Entities.PatientStoredModel", "Patient")
                        .WithMany("Phone")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PatientManagement.Infrastructure.StoredModel.Entities.PatientStoredModel", b =>
                {
                    b.Navigation("Phone");
                });
#pragma warning restore 612, 618
        }
    }
}
