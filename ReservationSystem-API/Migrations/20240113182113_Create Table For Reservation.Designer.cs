﻿// <auto-generated />
using System;
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
    [Migration("20240113182113_Create Table For Reservation")]
    partial class CreateTableForReservation
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

            modelBuilder.Entity("ReservationSystem_API.Data.Group", b =>
                {
                    b.Property<int>("Idx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("idx");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Idx"));

                    b.Property<int>("FacilityIdx")
                        .HasColumnType("integer")
                        .HasColumnName("facility_idx");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Idx")
                        .HasName("pk_groups");

                    b.HasIndex("FacilityIdx")
                        .HasDatabaseName("ix_groups_facility_idx");

                    b.ToTable("groups", (string)null);
                });

            modelBuilder.Entity("ReservationSystem_API.Data.ReservationAlive", b =>
                {
                    b.Property<int>("Idx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("idx");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Idx"));

                    b.Property<int>("DeviceIdx")
                        .HasColumnType("integer")
                        .HasColumnName("device_idx");

                    b.Property<int>("FacilityIdx")
                        .HasColumnType("integer")
                        .HasColumnName("facility_idx");

                    b.Property<int>("RHIdx")
                        .HasColumnType("integer")
                        .HasColumnName("rh_idx");

                    b.Property<int>("SpaceIdx")
                        .HasColumnType("integer")
                        .HasColumnName("space_idx");

                    b.Property<int>("UserIdx")
                        .HasColumnType("integer")
                        .HasColumnName("user_idx");

                    b.HasKey("Idx")
                        .HasName("pk_reservations_alives");

                    b.HasIndex("DeviceIdx")
                        .HasDatabaseName("ix_reservations_alives_device_idx");

                    b.HasIndex("FacilityIdx")
                        .HasDatabaseName("ix_reservations_alives_facility_idx");

                    b.HasIndex("RHIdx")
                        .HasDatabaseName("ix_reservations_alives_rh_idx");

                    b.HasIndex("SpaceIdx")
                        .HasDatabaseName("ix_reservations_alives_space_idx");

                    b.HasIndex("UserIdx")
                        .HasDatabaseName("ix_reservations_alives_user_idx");

                    b.ToTable("reservations_alives", (string)null);
                });

            modelBuilder.Entity("ReservationSystem_API.Data.ReservationHistory", b =>
                {
                    b.Property<int>("Idx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("idx");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Idx"));

                    b.Property<DateTime>("Canceled")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("canceled");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<int>("DeviceIdx")
                        .HasColumnType("integer")
                        .HasColumnName("device_idx");

                    b.Property<DateTime>("Ended")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("ended");

                    b.Property<int>("FacilityIdx")
                        .HasColumnType("integer")
                        .HasColumnName("facility_idx");

                    b.Property<int>("SpaceIdx")
                        .HasColumnType("integer")
                        .HasColumnName("space_idx");

                    b.Property<DateTime>("Started")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("started");

                    b.Property<int>("UserIdx")
                        .HasColumnType("integer")
                        .HasColumnName("user_idx");

                    b.HasKey("Idx")
                        .HasName("pk_reservations_histories");

                    b.HasIndex("DeviceIdx")
                        .HasDatabaseName("ix_reservations_histories_device_idx");

                    b.HasIndex("FacilityIdx")
                        .HasDatabaseName("ix_reservations_histories_facility_idx");

                    b.HasIndex("SpaceIdx")
                        .HasDatabaseName("ix_reservations_histories_space_idx");

                    b.HasIndex("UserIdx")
                        .HasDatabaseName("ix_reservations_histories_user_idx");

                    b.ToTable("reservations_histories", (string)null);
                });

            modelBuilder.Entity("ReservationSystem_API.Data.Space", b =>
                {
                    b.Property<int>("Idx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("idx");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Idx"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("comment");

                    b.Property<int>("FacilityIdx")
                        .HasColumnType("integer")
                        .HasColumnName("facility_idx");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Idx")
                        .HasName("pk_spaces");

                    b.HasIndex("FacilityIdx")
                        .HasDatabaseName("ix_spaces_facility_idx");

                    b.ToTable("spaces", (string)null);
                });

            modelBuilder.Entity("ReservationSystem_API.Data.User", b =>
                {
                    b.Property<int>("Idx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("idx");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Idx"));

                    b.Property<string>("Birth")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("birth");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("contact");

                    b.Property<int>("GroupIdx")
                        .HasColumnType("integer")
                        .HasColumnName("group_idx");

                    b.Property<DateOnly>("JoinDate")
                        .HasColumnType("date")
                        .HasColumnName("join_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("sex");

                    b.Property<int>("Valid")
                        .HasColumnType("integer")
                        .HasColumnName("valid");

                    b.HasKey("Idx")
                        .HasName("pk_users");

                    b.HasIndex("GroupIdx")
                        .HasDatabaseName("ix_users_group_idx");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("ReservationSystem_API.Data.Device", b =>
                {
                    b.HasOne("ReservationSystem_API.Data.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyIdx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_devices_companies_company_idx");

                    b.HasOne("ReservationSystem_API.Data.Facility", "Facility")
                        .WithMany()
                        .HasForeignKey("FacilityIdx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_devices_facilities_facility_idx");

                    b.Navigation("Company");

                    b.Navigation("Facility");
                });

            modelBuilder.Entity("ReservationSystem_API.Data.Group", b =>
                {
                    b.HasOne("ReservationSystem_API.Data.Facility", "Facility")
                        .WithMany()
                        .HasForeignKey("FacilityIdx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_groups_facilities_facility_idx");

                    b.Navigation("Facility");
                });

            modelBuilder.Entity("ReservationSystem_API.Data.ReservationAlive", b =>
                {
                    b.HasOne("ReservationSystem_API.Data.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceIdx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_reservations_alives_devices_device_idx");

                    b.HasOne("ReservationSystem_API.Data.Facility", "Facility")
                        .WithMany()
                        .HasForeignKey("FacilityIdx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_reservations_alives_facilities_facility_idx");

                    b.HasOne("ReservationSystem_API.Data.ReservationHistory", "ReservationHistory")
                        .WithMany()
                        .HasForeignKey("RHIdx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_reservations_alives_reservations_histories_rh_idx");

                    b.HasOne("ReservationSystem_API.Data.Space", "Space")
                        .WithMany()
                        .HasForeignKey("SpaceIdx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_reservations_alives_spaces_space_idx");

                    b.HasOne("ReservationSystem_API.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserIdx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_reservations_alives_users_user_idx");

                    b.Navigation("Device");

                    b.Navigation("Facility");

                    b.Navigation("ReservationHistory");

                    b.Navigation("Space");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ReservationSystem_API.Data.ReservationHistory", b =>
                {
                    b.HasOne("ReservationSystem_API.Data.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceIdx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_reservations_histories_devices_device_idx");

                    b.HasOne("ReservationSystem_API.Data.Facility", "Facility")
                        .WithMany()
                        .HasForeignKey("FacilityIdx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_reservations_histories_facilities_facility_idx");

                    b.HasOne("ReservationSystem_API.Data.Space", "Space")
                        .WithMany()
                        .HasForeignKey("SpaceIdx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_reservations_histories_spaces_space_idx");

                    b.HasOne("ReservationSystem_API.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserIdx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_reservations_histories_users_user_idx");

                    b.Navigation("Device");

                    b.Navigation("Facility");

                    b.Navigation("Space");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ReservationSystem_API.Data.Space", b =>
                {
                    b.HasOne("ReservationSystem_API.Data.Facility", "Facility")
                        .WithMany()
                        .HasForeignKey("FacilityIdx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_spaces_facilities_facility_idx");

                    b.Navigation("Facility");
                });

            modelBuilder.Entity("ReservationSystem_API.Data.User", b =>
                {
                    b.HasOne("ReservationSystem_API.Data.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupIdx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_users_groups_group_idx");

                    b.Navigation("Group");
                });
#pragma warning restore 612, 618
        }
    }
}
