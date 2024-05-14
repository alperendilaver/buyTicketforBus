﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using buyticketforbus.Repositories.Context;

#nullable disable

namespace buyticketforbus.Migrations
{
    [DbContext(typeof(CombinedContext))]
    [Migration("20240512135549_drivershosts")]
    partial class drivershosts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PassengerStation", b =>
                {
                    b.Property<int>("passengersPassengerId")
                        .HasColumnType("int");

                    b.Property<int>("stationsStationId")
                        .HasColumnType("int");

                    b.HasKey("passengersPassengerId", "stationsStationId");

                    b.HasIndex("stationsStationId");

                    b.ToTable("PassengerStation");
                });

            modelBuilder.Entity("buyticketforbus.Data.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("buyticketforbus.Data.Bus", b =>
                {
                    b.Property<int>("BusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Plaka")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("koltukSayisi")
                        .HasColumnType("int");

                    b.HasKey("BusId");

                    b.ToTable("buses");
                });

            modelBuilder.Entity("buyticketforbus.Data.Driver", b =>
                {
                    b.Property<int>("DriverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Gender")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("GovernmentId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("DriverId");

                    b.HasIndex("TourId");

                    b.ToTable("drivers");
                });

            modelBuilder.Entity("buyticketforbus.Data.HostofBus", b =>
                {
                    b.Property<int>("HostsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Gender")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("GovernmentId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("tourId")
                        .HasColumnType("int");

                    b.HasKey("HostsId");

                    b.HasIndex("tourId")
                        .IsUnique();

                    b.ToTable("hosts");
                });

            modelBuilder.Entity("buyticketforbus.Data.Passenger", b =>
                {
                    b.Property<int>("PassengerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Gender")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("GovernmentId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("KoltukNo")
                        .HasColumnType("int");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("depertureStation")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("finishStation")
                        .HasColumnType("int");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PassengerId");

                    b.ToTable("passengers");
                });

            modelBuilder.Entity("buyticketforbus.Data.Station", b =>
                {
                    b.Property<int>("StationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("arrivedTime")
                        .HasColumnType("int");

                    b.Property<int>("departureTime")
                        .HasColumnType("int");

                    b.Property<int>("kacinciDurak")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<int>("tourId")
                        .HasColumnType("int");

                    b.HasKey("StationId");

                    b.HasIndex("tourId");

                    b.ToTable("stations");
                });

            modelBuilder.Entity("buyticketforbus.Data.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PassengerId")
                        .HasColumnType("int");

                    b.Property<string>("pnrNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<int>("tourId")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("TicketId");

                    b.HasIndex("PassengerId");

                    b.HasIndex("tourId");

                    b.HasIndex("userId");

                    b.ToTable("tickets");
                });

            modelBuilder.Entity("buyticketforbus.Data.Tour", b =>
                {
                    b.Property<int>("tourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("departureTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("expectedArrivedTime")
                        .HasColumnType("int");

                    b.Property<int>("finishStation")
                        .HasColumnType("int");

                    b.Property<int>("firstStation")
                        .HasColumnType("int");

                    b.HasKey("tourId");

                    b.HasIndex("BusId");

                    b.ToTable("tours");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("buyticketforbus.Data.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("buyticketforbus.Data.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("buyticketforbus.Data.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("buyticketforbus.Data.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PassengerStation", b =>
                {
                    b.HasOne("buyticketforbus.Data.Passenger", null)
                        .WithMany()
                        .HasForeignKey("passengersPassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("buyticketforbus.Data.Station", null)
                        .WithMany()
                        .HasForeignKey("stationsStationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("buyticketforbus.Data.Driver", b =>
                {
                    b.HasOne("buyticketforbus.Data.Tour", "tour")
                        .WithMany("drivers")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tour");
                });

            modelBuilder.Entity("buyticketforbus.Data.HostofBus", b =>
                {
                    b.HasOne("buyticketforbus.Data.Tour", "tour")
                        .WithOne("hostofBus")
                        .HasForeignKey("buyticketforbus.Data.HostofBus", "tourId");

                    b.Navigation("tour");
                });

            modelBuilder.Entity("buyticketforbus.Data.Station", b =>
                {
                    b.HasOne("buyticketforbus.Data.Tour", "tour")
                        .WithMany("stations")
                        .HasForeignKey("tourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tour");
                });

            modelBuilder.Entity("buyticketforbus.Data.Ticket", b =>
                {
                    b.HasOne("buyticketforbus.Data.Passenger", "passenger")
                        .WithMany()
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("buyticketforbus.Data.Tour", "tour")
                        .WithMany()
                        .HasForeignKey("tourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("buyticketforbus.Data.AppUser", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("passenger");

                    b.Navigation("tour");

                    b.Navigation("user");
                });

            modelBuilder.Entity("buyticketforbus.Data.Tour", b =>
                {
                    b.HasOne("buyticketforbus.Data.Bus", "bus")
                        .WithMany()
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bus");
                });

            modelBuilder.Entity("buyticketforbus.Data.Tour", b =>
                {
                    b.Navigation("drivers");

                    b.Navigation("hostofBus")
                        .IsRequired();

                    b.Navigation("stations");
                });
#pragma warning restore 612, 618
        }
    }
}
