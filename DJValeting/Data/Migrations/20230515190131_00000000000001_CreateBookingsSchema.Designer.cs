﻿// <auto-generated />
using System;
using DJValeting.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DJValeting.Migrations
{
    [DbContext(typeof(BusinessDbContext))]
    [Migration("20230515190131_00000000000001_CreateBookingsSchema")]
    partial class _00000000000001_CreateBookingsSchema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DJValeting.Model.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Approved")
                        .HasColumnType("bit");

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlexibilityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleSizeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FlexibilityId");

                    b.HasIndex("VehicleSizeId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("DJValeting.Model.Flexibility", b =>
                {
                    b.Property<int>("FlexibilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlexibilityId"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FlexibilityId");

                    b.ToTable("Flexibilities");

                    b.HasData(
                        new
                        {
                            FlexibilityId = 1,
                            DisplayOrder = 1,
                            Name = "+/- 1 Day"
                        },
                        new
                        {
                            FlexibilityId = 2,
                            DisplayOrder = 2,
                            Name = "+/- 2 Days"
                        },
                        new
                        {
                            FlexibilityId = 3,
                            DisplayOrder = 3,
                            Name = "+/- 3 Days"
                        });
                });

            modelBuilder.Entity("DJValeting.Model.VehicleSize", b =>
                {
                    b.Property<int>("VehicleSizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleSizeId"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleSizeId");

                    b.ToTable("VehicleSizes");

                    b.HasData(
                        new
                        {
                            VehicleSizeId = 1,
                            DisplayOrder = 1,
                            Name = "Small"
                        },
                        new
                        {
                            VehicleSizeId = 2,
                            DisplayOrder = 2,
                            Name = "Medium"
                        },
                        new
                        {
                            VehicleSizeId = 3,
                            DisplayOrder = 3,
                            Name = "Large"
                        },
                        new
                        {
                            VehicleSizeId = 4,
                            DisplayOrder = 4,
                            Name = "Van"
                        });
                });

            modelBuilder.Entity("DJValeting.Model.Booking", b =>
                {
                    b.HasOne("DJValeting.Model.Flexibility", "Flexibility")
                        .WithMany("Bookings")
                        .HasForeignKey("FlexibilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DJValeting.Model.VehicleSize", "VehicleSize")
                        .WithMany("Bookings")
                        .HasForeignKey("VehicleSizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flexibility");

                    b.Navigation("VehicleSize");
                });

            modelBuilder.Entity("DJValeting.Model.Flexibility", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("DJValeting.Model.VehicleSize", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
