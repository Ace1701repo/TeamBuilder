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
    [Migration("20230515125834_ModelEdited")]
    partial class ModelEdited
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

                    b.Property<Guid>("CompanyId")
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

                    b.Property<Guid>("TeamId")
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
                            Id = new Guid("5167a786-6e01-4684-8aa5-ace186cdddda"),
                            Address = "Unnamed Road, Volkovo",
                            Capacity = 50,
                            CentreName = "Karting Skaj Kart",
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("8e538ff4-4f6a-426e-8759-1e8a33e66cbf"),
                            Address = "Planinarski Dom Matka Matka, 1060",
                            Capacity = 20,
                            CentreName = "Vrelo Cave Boat Trips & Kayak Rentale",
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("a4f19c6e-0e58-4c79-87ff-c14dc872883d"),
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
                            Id = new Guid("1badf715-ac53-45dd-97f1-8cb7f18dce4a"),
                            Capacity = 60,
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Location = "Teodosij Gologanov 79",
                            RestaurantName = "Gostilnica Dukat"
                        },
                        new
                        {
                            Id = new Guid("b3ff2e94-685c-4bbe-81c8-8b47ad5329e6"),
                            Capacity = 90,
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            LastModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Location = "Zagrebska 31, Skopje",
                            RestaurantName = "Dva Elena"
                        },
                        new
                        {
                            Id = new Guid("b3ef6b86-6722-4d4d-9326-9aa8e94dd58d"),
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
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamBuilderAPI.Models.Team", "Team")
                        .WithMany("Employees")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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