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
    [Migration("20230523065820_editedCompanies")]
    partial class editedCompanies
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
                            Id = new Guid("1d9f6373-6bf1-4437-8f9a-6d6a940c5d2b"),
                            Address = "Unnamed Road, Volkovo",
                            Capacity = 50,
                            CentreName = "Carting Sky Cart",
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("ca74fe18-8e31-4caf-b997-3ba8aced1ca5"),
                            Address = "Planinarski Dom Matka Matka, 1060",
                            Capacity = 20,
                            CentreName = "Kayak Rental - Matka",
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("53a0c965-2611-4d29-b121-1b6810d48f09"),
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
                            Id = new Guid("b2f1f55a-6104-479f-b6b6-de4ac8fba74f"),
                            Capacity = 60,
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Location = "Teodosij Gologanov 79",
                            RestaurantName = "Gostilnica Dukat"
                        },
                        new
                        {
                            Id = new Guid("845c830f-cfe5-4e21-92e3-0f990e977913"),
                            Capacity = 90,
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Location = "Zagrebska 31, Skopje",
                            RestaurantName = "Dva Elena"
                        },
                        new
                        {
                            Id = new Guid("39d5c8d7-e06d-4547-930f-56bd8556a0d3"),
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