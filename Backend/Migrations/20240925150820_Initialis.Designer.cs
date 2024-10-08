﻿// <auto-generated />
using System;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240925150820_Initialis")]
    partial class Initialis
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Backend.Model.Entitys.AirHumiditySensorEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.Property<double>("Value")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("AirHumiditySensorEntity");
                });

            modelBuilder.Entity("Backend.Model.Entitys.PumpEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("PumpEntity");
                });

            modelBuilder.Entity("Backend.Model.Entitys.SoilMoistureSensorEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("SystemDataEntityId")
                        .HasColumnType("integer");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.Property<double>("Value")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("SystemDataEntityId");

                    b.ToTable("SoilMoistureSensorEntity");
                });

            modelBuilder.Entity("Backend.Model.Entitys.SystemDataEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AirHumiditySensorId")
                        .HasColumnType("integer");

                    b.Property<int?>("PumpId")
                        .HasColumnType("integer");

                    b.Property<int?>("TemperatureSensorId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("WaterLevelSensorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AirHumiditySensorId");

                    b.HasIndex("PumpId");

                    b.HasIndex("TemperatureSensorId");

                    b.HasIndex("WaterLevelSensorId");

                    b.ToTable("SystemData");
                });

            modelBuilder.Entity("Backend.Model.Entitys.TemperatureSensorEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.Property<double>("Value")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("TemperatureSensorEntity");
                });

            modelBuilder.Entity("Backend.Model.Entitys.ValveEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<int?>("SystemDataEntityId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SystemDataEntityId");

                    b.ToTable("ValveEntity");
                });

            modelBuilder.Entity("Backend.Model.Entitys.WaterLevelSensorEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.Property<double>("Value")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("WaterLevelSensorEntity");
                });

            modelBuilder.Entity("Backend.Model.Entitys.SoilMoistureSensorEntity", b =>
                {
                    b.HasOne("Backend.Model.Entitys.SystemDataEntity", null)
                        .WithMany("SoilMoistureSensors")
                        .HasForeignKey("SystemDataEntityId");
                });

            modelBuilder.Entity("Backend.Model.Entitys.SystemDataEntity", b =>
                {
                    b.HasOne("Backend.Model.Entitys.AirHumiditySensorEntity", "AirHumiditySensor")
                        .WithMany()
                        .HasForeignKey("AirHumiditySensorId");

                    b.HasOne("Backend.Model.Entitys.PumpEntity", "Pump")
                        .WithMany()
                        .HasForeignKey("PumpId");

                    b.HasOne("Backend.Model.Entitys.TemperatureSensorEntity", "TemperatureSensor")
                        .WithMany()
                        .HasForeignKey("TemperatureSensorId");

                    b.HasOne("Backend.Model.Entitys.WaterLevelSensorEntity", "WaterLevelSensor")
                        .WithMany()
                        .HasForeignKey("WaterLevelSensorId");

                    b.Navigation("AirHumiditySensor");

                    b.Navigation("Pump");

                    b.Navigation("TemperatureSensor");

                    b.Navigation("WaterLevelSensor");
                });

            modelBuilder.Entity("Backend.Model.Entitys.ValveEntity", b =>
                {
                    b.HasOne("Backend.Model.Entitys.SystemDataEntity", null)
                        .WithMany("Valves")
                        .HasForeignKey("SystemDataEntityId");
                });

            modelBuilder.Entity("Backend.Model.Entitys.SystemDataEntity", b =>
                {
                    b.Navigation("SoilMoistureSensors");

                    b.Navigation("Valves");
                });
#pragma warning restore 612, 618
        }
    }
}
