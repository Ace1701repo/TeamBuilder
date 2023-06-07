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
    [Migration("20230516084132_TeamModified")]
    partial class TeamModified
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

                    b.Property<Guid?>("TeamId")
                        .HasColumnType("uniqueidentifier");

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
                            Id = new Guid("c5ba6acd-06ec-43d9-8742-07fac5a0b362"),
                            Address = "Unnamed Road, Volkovo",
                            Capacity = 50,
                            CentreName = "Karting Skaj Kart",
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("85f2be41-4041-4f98-a768-7d334d6b5427"),
                            Address = "Planinarski Dom Matka Matka, 1060",
                            Capacity = 20,
                            CentreName = "Vrelo Cave Boat Trips & Kayak Rentale",
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("36cca45f-a2f5-4a23-a4a0-089b690a1a3b"),
                            Address = "Justinijan Prvi, Drachevo",
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
                            Id = new Guid("4fd8be55-f329-4810-983a-9d3f7224f6c3"),
                            Capacity = 60,
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Location = "Teodosij Gologanov 79",
                            RestaurantName = "Gostilnica Dukat"
                        },
                        new
                        {
                            Id = new Guid("8a264f28-f1d6-4e04-9861-558fb6241a8f"),
                            Capacity = 90,
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Location = "Zagrebska 31, Skopje",
                            RestaurantName = "Dva Elena"
                        },
                        new
                        {
                            Id = new Guid("08c82a8b-9658-4c4f-a48e-727ea589bed5"),
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