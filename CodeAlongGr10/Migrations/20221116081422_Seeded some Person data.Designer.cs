﻿// <auto-generated />
using CodeAlongGr10.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeAlongGr10.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221116081422_Seeded some Person data")]
    partial class SeededsomePersondata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodeAlongGr10.Models.Person", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = "6bde87a5-aed6-410a-85b5-244d5cb7a9ab",
                            Age = 34,
                            Name = "Jonathan Krall",
                            PhoneNumber = "0737090202"
                        },
                        new
                        {
                            Id = "75214a5e-c148-4b52-b659-30e45225ca32",
                            Age = 59,
                            Name = "Sven Svensson",
                            PhoneNumber = "123456"
                        },
                        new
                        {
                            Id = "311d092f-507e-4a1a-ba13-c1be9741f626",
                            Age = 26,
                            Name = "Anna Andersson",
                            PhoneNumber = "845621"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
