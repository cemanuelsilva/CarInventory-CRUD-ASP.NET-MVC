﻿// <auto-generated />
using System;
using LearnApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LearnApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LearnApp.Models.Car", b =>
                {
                    b.Property<int>("carId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("carId"));

                    b.Property<string>("carName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("carOwner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("datePlate")
                        .HasColumnType("date");

                    b.Property<string>("mark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("plate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("carId");

                    b.ToTable("Car");
                });
#pragma warning restore 612, 618
        }
    }
}
