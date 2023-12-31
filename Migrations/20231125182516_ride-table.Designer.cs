﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniRideHubBackend.Data;

#nullable disable

namespace UniRideHubBackend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231125182516_ride-table")]
    partial class ridetable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UniRideHubBackend.Models.Ride", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("destination")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("fare")
                        .HasColumnType("int");

                    b.Property<string>("mid_routes")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("source")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("total_Seats")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Rides");
                });

            modelBuilder.Entity("UniRideHubBackend.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("mobile")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("rides_completed")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
