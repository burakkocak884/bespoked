﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using profisee_project.Models;

namespace profisee_project.Migrations
{
    [DbContext(typeof(MainDataBaseContext))]
    [Migration("20230421140031_AddSaleCommisionToSaleTable")]
    partial class AddSaleCommisionToSaleTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("profisee_project.Models.Customer", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("customerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("profisee_project.Models.Discount", b =>
                {
                    b.Property<int>("discountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("DiscountPercentage")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("productId")
                        .HasColumnType("integer");

                    b.HasKey("discountID");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("profisee_project.Models.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("CommissionPercentage")
                        .HasColumnType("double precision");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("PurchasePrice")
                        .HasColumnType("double precision");

                    b.Property<int>("QuantityOnHand")
                        .HasColumnType("integer");

                    b.Property<double>("SalePrice")
                        .HasColumnType("double precision");

                    b.Property<string>("Style")
                        .HasColumnType("text");

                    b.HasKey("productId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("profisee_project.Models.Sale", b =>
                {
                    b.Property<int>("saleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("SaleCommission")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("SalePrice")
                        .HasColumnType("double precision");

                    b.Property<int>("customerId")
                        .HasColumnType("integer");

                    b.Property<int>("productId")
                        .HasColumnType("integer");

                    b.Property<int>("salesPersonId")
                        .HasColumnType("integer");

                    b.HasKey("saleId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("profisee_project.Models.SalesInDetails", b =>
                {
                    b.Property<int>("salesInDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("salePersonCommission")
                        .HasColumnType("double precision");

                    b.Property<double>("salePrice")
                        .HasColumnType("double precision");

                    b.Property<int>("salesInDetailsCustomerId")
                        .HasColumnType("integer");

                    b.Property<string>("salesInDetailsCustomerName")
                        .HasColumnType("text");

                    b.Property<DateTime>("salesInDetailsDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("salesInDetailsProductId")
                        .HasColumnType("integer");

                    b.Property<string>("salesInDetailsSalesPersonName")
                        .HasColumnType("text");

                    b.Property<int>("salesPersonId")
                        .HasColumnType("integer");

                    b.Property<string>("salesProductName")
                        .HasColumnType("text");

                    b.HasKey("salesInDetailsId");

                    b.ToTable("SalesInDetails");
                });

            modelBuilder.Entity("profisee_project.Models.SalesPerson", b =>
                {
                    b.Property<int>("salesPersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("TerminationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("managerId")
                        .HasColumnType("integer");

                    b.HasKey("salesPersonId");

                    b.ToTable("SalesPeople");
                });
#pragma warning restore 612, 618
        }
    }
}
