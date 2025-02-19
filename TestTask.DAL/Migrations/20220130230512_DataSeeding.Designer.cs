﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestTask.DAL;

namespace TestTask.DAL.Migrations
{
    [DbContext(typeof(TaxContext))]
    [Migration("20220130230512_DataSeeding")]
    partial class DataSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestTask.Core.Models.Fee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FeeValue")
                        .HasColumnType("int");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("Zipcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Fees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FeeValue = 100,
                            StateId = 1,
                            Zipcode = "90011"
                        },
                        new
                        {
                            Id = 2,
                            FeeValue = 120,
                            StateId = 1,
                            Zipcode = "90044"
                        },
                        new
                        {
                            Id = 3,
                            FeeValue = 130,
                            StateId = 1,
                            Zipcode = "90201"
                        },
                        new
                        {
                            Id = 4,
                            FeeValue = 110,
                            StateId = 1,
                            Zipcode = "90650"
                        },
                        new
                        {
                            Id = 5,
                            FeeValue = 90,
                            StateId = 1,
                            Zipcode = "91331"
                        },
                        new
                        {
                            Id = 6,
                            FeeValue = 80,
                            StateId = 2,
                            Zipcode = "10001"
                        },
                        new
                        {
                            Id = 7,
                            FeeValue = 140,
                            StateId = 2,
                            Zipcode = "10002"
                        },
                        new
                        {
                            Id = 8,
                            FeeValue = 70,
                            StateId = 2,
                            Zipcode = "10003"
                        },
                        new
                        {
                            Id = 9,
                            FeeValue = 84,
                            StateId = 2,
                            Zipcode = "10004"
                        },
                        new
                        {
                            Id = 10,
                            FeeValue = 96,
                            StateId = 2,
                            Zipcode = "10005"
                        },
                        new
                        {
                            Id = 11,
                            FeeValue = 36,
                            StateId = 3,
                            Zipcode = "32004"
                        },
                        new
                        {
                            Id = 12,
                            FeeValue = 58,
                            StateId = 3,
                            Zipcode = "32006"
                        },
                        new
                        {
                            Id = 13,
                            FeeValue = 64,
                            StateId = 3,
                            Zipcode = "32007"
                        },
                        new
                        {
                            Id = 14,
                            FeeValue = 98,
                            StateId = 3,
                            Zipcode = "32008"
                        },
                        new
                        {
                            Id = 15,
                            FeeValue = 115,
                            StateId = 3,
                            Zipcode = "32009"
                        });
                });

            modelBuilder.Entity("TestTask.Core.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "CA"
                        },
                        new
                        {
                            Id = 2,
                            Code = "NY"
                        },
                        new
                        {
                            Id = 3,
                            Code = "FL"
                        });
                });

            modelBuilder.Entity("TestTask.Core.Models.Tax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Coefficient")
                        .HasColumnType("float");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Taxes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Coefficient = 1.05,
                            StateId = 1,
                            VehicleId = 1
                        },
                        new
                        {
                            Id = 2,
                            Coefficient = 1.2,
                            StateId = 1,
                            VehicleId = 2
                        },
                        new
                        {
                            Id = 3,
                            Coefficient = 1.25,
                            StateId = 1,
                            VehicleId = 3
                        },
                        new
                        {
                            Id = 4,
                            Coefficient = 0.90000000000000002,
                            StateId = 2,
                            VehicleId = 1
                        },
                        new
                        {
                            Id = 5,
                            Coefficient = 1.5,
                            StateId = 2,
                            VehicleId = 2
                        },
                        new
                        {
                            Id = 6,
                            Coefficient = 1.5,
                            StateId = 2,
                            VehicleId = 3
                        },
                        new
                        {
                            Id = 7,
                            Coefficient = 1.1000000000000001,
                            StateId = 3,
                            VehicleId = 1
                        },
                        new
                        {
                            Id = 8,
                            Coefficient = 1.5,
                            StateId = 3,
                            VehicleId = 2
                        },
                        new
                        {
                            Id = 9,
                            StateId = 3,
                            VehicleId = 3
                        });
                });

            modelBuilder.Entity("TestTask.Core.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Passenger"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Truck"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Trailer"
                        });
                });

            modelBuilder.Entity("TestTask.Core.Models.Fee", b =>
                {
                    b.HasOne("TestTask.Core.Models.State", "State")
                        .WithMany("Fees")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("TestTask.Core.Models.Tax", b =>
                {
                    b.HasOne("TestTask.Core.Models.State", "State")
                        .WithMany("Taxes")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestTask.Core.Models.Vehicle", "Vehicle")
                        .WithMany("Taxes")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("TestTask.Core.Models.State", b =>
                {
                    b.Navigation("Fees");

                    b.Navigation("Taxes");
                });

            modelBuilder.Entity("TestTask.Core.Models.Vehicle", b =>
                {
                    b.Navigation("Taxes");
                });
#pragma warning restore 612, 618
        }
    }
}
