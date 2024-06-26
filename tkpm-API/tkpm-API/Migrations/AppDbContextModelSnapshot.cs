﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tkpm_API.Data;

#nullable disable

namespace tkpm_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("tkpm_API.Entities.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PlatformCost")
                        .HasColumnType("float");

                    b.Property<double>("Surcharge")
                        .HasColumnType("float");

                    b.Property<double>("TollCost")
                        .HasColumnType("float");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<double>("TripCost")
                        .HasColumnType("float");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TripId")
                        .IsUnique();

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("tkpm_API.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "HCM"
                        });
                });

            modelBuilder.Entity("tkpm_API.Entities.OperatedTrip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BookingTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerLocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("OperatedTrips");
                });

            modelBuilder.Entity("tkpm_API.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            Name = "CUSTOMER"
                        },
                        new
                        {
                            Id = 3,
                            Name = "DRIVER"
                        },
                        new
                        {
                            Id = 4,
                            Name = "OPERATOR"
                        });
                });

            modelBuilder.Entity("tkpm_API.Entities.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BookingTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<string>("EndPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("tkpm_API.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.UseTptMappingStrategy();

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "NVC",
                            Email = "admin@gmail.com",
                            FullName = "admin",
                            IdentityCard = "079212345678",
                            Password = "123",
                            PhoneNumber = "0123456789",
                            RoleId = 1,
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("tkpm_API.Entities.VehicleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehicleTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Motor Bike"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Car"
                        });
                });

            modelBuilder.Entity("tkpm_API.Entities.Driver", b =>
                {
                    b.HasBaseType("tkpm_API.Entities.User");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<int>("RegisterLocationId")
                        .HasColumnType("int");

                    b.Property<int>("RegisterVehicleId")
                        .HasColumnType("int");

                    b.HasIndex("RegisterLocationId");

                    b.HasIndex("RegisterVehicleId");

                    b.ToTable("Drivers", null, t =>
                        {
                            t.Property("Id")
                                .HasColumnName("DriverId");
                        });
                });

            modelBuilder.Entity("tkpm_API.Entities.Bill", b =>
                {
                    b.HasOne("tkpm_API.Entities.Trip", "Trip")
                        .WithOne("Bill")
                        .HasForeignKey("tkpm_API.Entities.Bill", "TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("tkpm_API.Entities.OperatedTrip", b =>
                {
                    b.HasOne("tkpm_API.Entities.VehicleType", "VehicleType")
                        .WithMany("OperatedTrips")
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("tkpm_API.Entities.Trip", b =>
                {
                    b.HasOne("tkpm_API.Entities.User", "Customer")
                        .WithMany("Trips")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("tkpm_API.Entities.VehicleType", "VehicleType")
                        .WithMany("Trips")
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("tkpm_API.Entities.User", b =>
                {
                    b.HasOne("tkpm_API.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("tkpm_API.Entities.Driver", b =>
                {
                    b.HasOne("tkpm_API.Entities.User", null)
                        .WithOne()
                        .HasForeignKey("tkpm_API.Entities.Driver", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tkpm_API.Entities.Location", "Location")
                        .WithMany("Drivers")
                        .HasForeignKey("RegisterLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tkpm_API.Entities.VehicleType", "VehicleType")
                        .WithMany("Drivers")
                        .HasForeignKey("RegisterVehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("tkpm_API.Entities.Location", b =>
                {
                    b.Navigation("Drivers");
                });

            modelBuilder.Entity("tkpm_API.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("tkpm_API.Entities.Trip", b =>
                {
                    b.Navigation("Bill")
                        .IsRequired();
                });

            modelBuilder.Entity("tkpm_API.Entities.User", b =>
                {
                    b.Navigation("Trips");
                });

            modelBuilder.Entity("tkpm_API.Entities.VehicleType", b =>
                {
                    b.Navigation("Drivers");

                    b.Navigation("OperatedTrips");

                    b.Navigation("Trips");
                });
#pragma warning restore 612, 618
        }
    }
}
