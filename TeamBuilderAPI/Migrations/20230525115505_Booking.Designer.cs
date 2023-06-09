﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamBuilderAPI.Models;

#nullable disable

namespace TeamBuilderAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230525115505_Booking")]
    partial class Booking
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TeamBuilderAPI.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfEmployees")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("TeamBuilderAPI.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TeamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("TeamId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TeamBuilderAPI.Models.EventCentre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BookActivity")
                        .HasColumnType("datetime2");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("CentreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("EventCentres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("39f9433f-14d0-445b-969a-4f05269ec648"),
                            Address = "Unnamed Road, Volkovo",
                            BookActivity = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Capacity = 50,
                            CentreName = "Carting Sky Cart",
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("81ce3424-c213-4e10-b5ed-7a72ec8ec03e"),
                            Address = "Planinarski Dom Matka Matka, 1060",
                            BookActivity = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Capacity = 20,
                            CentreName = "Kayak Rental - Matka",
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("db7c6efc-9c51-4735-9190-53b67e38c8fa"),
                            Address = "Justinijan Prvi, Drachevo",
                            BookActivity = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Capacity = 50,
                            CentreName = "Paintball Arena BEST",
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });

            modelBuilder.Entity("TeamBuilderAPI.Models.Restaurant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BookRestaurant")
                        .HasColumnType("datetime2");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = new Guid("06aec49c-15e2-4a9b-b426-a437ece2984c"),
                            BookRestaurant = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Capacity = 60,
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Location = "Teodosij Gologanov 79",
                            RestaurantName = "Gostilnica Dukat"
                        },
                        new
                        {
                            Id = new Guid("ae37a053-344f-49c2-a4a6-c8ed71ad8f10"),
                            BookRestaurant = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Capacity = 90,
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Location = "Zagrebska 31, Skopje",
                            RestaurantName = "Dva Elena"
                        },
                        new
                        {
                            Id = new Guid("9917b0a1-f642-4bdc-9cd2-4eb87345fb45"),
                            BookRestaurant = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Capacity = 60,
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Location = "Teodosie Gologanov no.63, Skopje",
                            RestaurantName = "Makedonska Kuka"
                        });
                });

            modelBuilder.Entity("TeamBuilderAPI.Models.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("TeamBuilderAPI.Models.Employee", b =>
                {
                    b.HasOne("TeamBuilderAPI.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId");

                    b.HasOne("TeamBuilderAPI.Models.Team", "Team")
                        .WithMany("Employees")
                        .HasForeignKey("TeamId");

                    b.Navigation("Company");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("TeamBuilderAPI.Models.Team", b =>
                {
                    b.HasOne("TeamBuilderAPI.Models.Company", "Company")
                        .WithMany("Teams")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("TeamBuilderAPI.Models.Company", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("TeamBuilderAPI.Models.Team", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
