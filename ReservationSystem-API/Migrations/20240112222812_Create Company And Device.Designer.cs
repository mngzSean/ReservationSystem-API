﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ReservationSystem_API.Data;

#nullable disable

namespace ReservationSystem_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240112222812_Create Company And Device")]
    partial class CreateCompanyAndDevice
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ReservationSystem_API.Data.Company", b =>
                {
                    b.Property<int>("Idx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("idx");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Idx"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("contact");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("mail");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Idx")
                        .HasName("pk_companies");

                    b.ToTable("companies", (string)null);
                });

            modelBuilder.Entity("ReservationSystem_API.Data.Device", b =>
                {
                    b.Property<int>("Idx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("idx");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Idx"));

                    b.Property<int>("CompanyIdx")
                        .HasColumnType("integer")
                        .HasColumnName("company_idx");

                    b.Property<int>("FacilityIdx")
                        .HasColumnType("integer")
                        .HasColumnName("facility_idx");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("label");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Pid")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("pid");

                    b.Property<string>("Sn")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("sn");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("type");

                    b.HasKey("Idx")
                        .HasName("pk_devices");

                    b.HasIndex("CompanyIdx")
                        .HasDatabaseName("ix_devices_company_idx");

                    b.HasIndex("FacilityIdx")
                        .HasDatabaseName("ix_devices_facility_idx");

                    b.ToTable("devices", (string)null);
                });

            modelBuilder.Entity("ReservationSystem_API.Data.Facility", b =>
                {
                    b.Property<int>("Idx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("idx");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Idx"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("location");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("purpose");

                    b.HasKey("Idx")
                        .HasName("pk_facilities");

                    b.ToTable("facilities", (string)null);
                });

            modelBuilder.Entity("ReservationSystem_API.Data.Device", b =>
                {
                    b.HasOne("ReservationSystem_API.Data.Company", "Companies")
                        .WithMany()
                        .HasForeignKey("CompanyIdx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_devices_companies_company_idx");

                    b.HasOne("ReservationSystem_API.Data.Facility", "Facilities")
                        .WithMany()
                        .HasForeignKey("FacilityIdx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_devices_facilities_facility_idx");

                    b.Navigation("Companies");

                    b.Navigation("Facilities");
                });
#pragma warning restore 612, 618
        }
    }
}