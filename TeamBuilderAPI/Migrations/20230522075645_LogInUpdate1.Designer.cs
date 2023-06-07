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
    [Migration("20230522075645_LogInUpdate1")]
    partial class LogInUpdate1
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
                            Id = new Guid("b08297b8-0141-4171-879f-bb34b9d055a6"),
                            Address = "Unnamed Road, Volkovo",
                            Capacity = 50,
                            CentreName = "Carting Sky Cart",
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("1a0df635-6db0-4c9d-ac43-4f936d27c640"),
                            Address = "Planinarski Dom Matka Matka, 1060",
                            Capacity = 20,
                            CentreName = "Kayak Rental - Matka",
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("55fefcda-303c-416f-96a6-ad73f508e412"),
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
                            Id = new Guid("3838ebd4-b3a5-45f3-aa1d-c9c7fc29dadf"),
                            Capacity = 60,
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Location = "Teodosij Gologanov 79",
                            RestaurantName = "Gostilnica Dukat"
                        },
                        new
                        {
                            Id = new Guid("58d84545-8290-4351-9a83-d0efa24fe8cb"),
                            Capacity = 90,
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Location = "Zagrebska 31, Skopje",
                            RestaurantName = "Dva Elena"
                        },
                        new
                        {
                            Id = new Guid("8e6439db-f9ec-4031-980e-175b00ea1809"),
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
