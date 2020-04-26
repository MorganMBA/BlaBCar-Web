﻿// <auto-generated />
using System;
using BlaBCar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlaBCar.Migrations
{
    [DbContext(typeof(BlaBCarContext))]
    partial class BlaBCarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlaBCar.Models.Reservation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomBooker");

                    b.Property<string>("TelephoneBooker");

                    b.HasKey("Id");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("BlaBCar.Models.Trajet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AgeChauffeur");

                    b.Property<bool>("Animaux");

                    b.Property<bool>("Bagage");

                    b.Property<DateTime>("DateDepart");

                    b.Property<long>("DureeTrajet");

                    b.Property<bool>("Fumeur");

                    b.Property<bool>("Handicape");

                    b.Property<string>("LieuArrive");

                    b.Property<string>("LieuDepart");

                    b.Property<long>("NbrePlaceDispo");

                    b.Property<long>("NbreReservation");

                    b.Property<string>("NomChauffeur");

                    b.Property<long?>("ReservationId");

                    b.Property<string>("TelephoneChauffeur");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("Trajets");
                });

            modelBuilder.Entity("BlaBCar.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlaBCar.Models.Trajet", b =>
                {
                    b.HasOne("BlaBCar.Models.Reservation")
                        .WithMany("Trajets")
                        .HasForeignKey("ReservationId");
                });
#pragma warning restore 612, 618
        }
    }
}
