﻿// <auto-generated />
using CodeAlongGr10.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeAlongGr10.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarPerson", b =>
                {
                    b.Property<string>("CarsRegNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PeopleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CarsRegNumber", "PeopleId");

                    b.HasIndex("PeopleId");

                    b.ToTable("CarPerson");

                    b.HasData(
                        new
                        {
                            CarsRegNumber = "ABC-123",
                            PeopleId = "c2fdfbce-ee16-4bde-be11-762854a8f654"
                        });
                });

            modelBuilder.Entity("CodeAlongGr10.Models.Car", b =>
                {
                    b.Property<string>("RegNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegNumber");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            RegNumber = "ABC-123",
                            Brand = "SAAB",
                            CarModel = "93"
                        });
                });

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
                            Id = "c2fdfbce-ee16-4bde-be11-762854a8f654",
                            Age = 34,
                            Name = "Jonathan Krall",
                            PhoneNumber = "0737090202"
                        },
                        new
                        {
                            Id = "47e00f99-b7a7-4c9a-8f3a-220ae409dbd1",
                            Age = 59,
                            Name = "Sven Svensson",
                            PhoneNumber = "123456"
                        },
                        new
                        {
                            Id = "7ee8a988-beff-4aaa-9bff-f92980fd48b3",
                            Age = 26,
                            Name = "Anna Andersson",
                            PhoneNumber = "845621"
                        });
                });

            modelBuilder.Entity("CarPerson", b =>
                {
                    b.HasOne("CodeAlongGr10.Models.Car", null)
                        .WithMany()
                        .HasForeignKey("CarsRegNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAlongGr10.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
