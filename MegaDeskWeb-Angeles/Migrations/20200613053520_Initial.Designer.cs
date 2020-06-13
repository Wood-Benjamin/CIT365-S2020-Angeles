﻿// <auto-generated />
using System;
using MegaDeskWeb_Angeles.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MegaDeskWeb_Angeles.Migrations
{
    [DbContext(typeof(MegaDeskWeb_AngelesContext))]
    [Migration("20200613053520_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MegaDeskWeb_Angeles.Models.DeskQuote", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<int>("Depth")
                        .HasColumnType("int");

                    b.Property<decimal>("DrawerCost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Drawers")
                        .HasColumnType("int");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MaterialCost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("QuoteDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("QuoteTotal")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Rush")
                        .HasColumnType("int");

                    b.Property<decimal>("RushCost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("SurfaceAreaCost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("DeskQuote");
                });
#pragma warning restore 612, 618
        }
    }
}
