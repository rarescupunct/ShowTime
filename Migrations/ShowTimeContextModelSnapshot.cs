﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShowTime.Data;

#nullable disable

namespace ShowTime.Migrations
{
    [DbContext(typeof(ShowTimeContext))]
    partial class ShowTimeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BandFestival", b =>
                {
                    b.Property<Guid>("BandsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FestivalsID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BandsId", "FestivalsID");

                    b.HasIndex("FestivalsID");

                    b.ToTable("BandFestival");
                });

            modelBuilder.Entity("ShowTime.Models.Band", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bands");
                });

            modelBuilder.Entity("ShowTime.Models.Booking", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FestivalID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FestivalID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("ShowTime.Models.Festival", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Festivals");
                });

            modelBuilder.Entity("BandFestival", b =>
                {
                    b.HasOne("ShowTime.Models.Band", null)
                        .WithMany()
                        .HasForeignKey("BandsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShowTime.Models.Festival", null)
                        .WithMany()
                        .HasForeignKey("FestivalsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShowTime.Models.Booking", b =>
                {
                    b.HasOne("ShowTime.Models.Festival", "Festival")
                        .WithMany("Bookings")
                        .HasForeignKey("FestivalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Festival");
                });

            modelBuilder.Entity("ShowTime.Models.Festival", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
