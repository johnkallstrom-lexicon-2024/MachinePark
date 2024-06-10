using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MachinePark.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MachineType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Machine",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    MachineTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Machine_MachineType_MachineTypeId",
                        column: x => x.MachineTypeId,
                        principalTable: "MachineType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MachineType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Excavator" },
                    { 2, "Wheel Loader" },
                    { 3, "Dozer" }
                });

            migrationBuilder.InsertData(
                table: "Machine",
                columns: new[] { "Id", "MachineTypeId", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("23ac64b9-7d24-4c7c-8b85-7964c8e852ac"), 1, "Machine 4", 0 },
                    { new Guid("3a726f02-04a7-41d5-a3ae-62ca638d6906"), 3, "Machine 3", 1 },
                    { new Guid("4b7d6609-ae60-4a7f-80df-ff0740b236c0"), 2, "Machine 2", 1 },
                    { new Guid("81ce2195-afe8-4b08-98bc-542392cf508f"), 1, "Machine 1", 0 },
                    { new Guid("e9857c63-d173-4322-a75b-8ad7df9a6b2a"), 2, "Machine 5", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Machine_MachineTypeId",
                table: "Machine",
                column: "MachineTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Machine");

            migrationBuilder.DropTable(
                name: "MachineType");
        }
    }
}
