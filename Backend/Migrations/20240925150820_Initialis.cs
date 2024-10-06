using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class Initialis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirHumiditySensorEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<double>(type: "double precision", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirHumiditySensorEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PumpEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PumpEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemperatureSensorEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<double>(type: "double precision", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemperatureSensorEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaterLevelSensorEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<double>(type: "double precision", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Location = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterLevelSensorEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PumpId = table.Column<int>(type: "integer", nullable: true),
                    TemperatureSensorId = table.Column<int>(type: "integer", nullable: true),
                    WaterLevelSensorId = table.Column<int>(type: "integer", nullable: true),
                    AirHumiditySensorId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemData_AirHumiditySensorEntity_AirHumiditySensorId",
                        column: x => x.AirHumiditySensorId,
                        principalTable: "AirHumiditySensorEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SystemData_PumpEntity_PumpId",
                        column: x => x.PumpId,
                        principalTable: "PumpEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SystemData_TemperatureSensorEntity_TemperatureSensorId",
                        column: x => x.TemperatureSensorId,
                        principalTable: "TemperatureSensorEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SystemData_WaterLevelSensorEntity_WaterLevelSensorId",
                        column: x => x.WaterLevelSensorId,
                        principalTable: "WaterLevelSensorEntity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SoilMoistureSensorEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<double>(type: "double precision", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Location = table.Column<string>(type: "text", nullable: true),
                    SystemDataEntityId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoilMoistureSensorEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoilMoistureSensorEntity_SystemData_SystemDataEntityId",
                        column: x => x.SystemDataEntityId,
                        principalTable: "SystemData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ValveEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: true),
                    SystemDataEntityId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValveEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValveEntity_SystemData_SystemDataEntityId",
                        column: x => x.SystemDataEntityId,
                        principalTable: "SystemData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SoilMoistureSensorEntity_SystemDataEntityId",
                table: "SoilMoistureSensorEntity",
                column: "SystemDataEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemData_AirHumiditySensorId",
                table: "SystemData",
                column: "AirHumiditySensorId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemData_PumpId",
                table: "SystemData",
                column: "PumpId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemData_TemperatureSensorId",
                table: "SystemData",
                column: "TemperatureSensorId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemData_WaterLevelSensorId",
                table: "SystemData",
                column: "WaterLevelSensorId");

            migrationBuilder.CreateIndex(
                name: "IX_ValveEntity_SystemDataEntityId",
                table: "ValveEntity",
                column: "SystemDataEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SoilMoistureSensorEntity");

            migrationBuilder.DropTable(
                name: "ValveEntity");

            migrationBuilder.DropTable(
                name: "SystemData");

            migrationBuilder.DropTable(
                name: "AirHumiditySensorEntity");

            migrationBuilder.DropTable(
                name: "PumpEntity");

            migrationBuilder.DropTable(
                name: "TemperatureSensorEntity");

            migrationBuilder.DropTable(
                name: "WaterLevelSensorEntity");
        }
    }
}
