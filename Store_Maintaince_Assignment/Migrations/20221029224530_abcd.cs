using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Maintaince_Assignment.Migrations
{
    public partial class abcd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bharat_State1s",
                columns: table => new
                {
                    StateId1 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName1 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bharat_State1s", x => x.StateId1);
                });

            migrationBuilder.CreateTable(
                name: "Bharat_State2s",
                columns: table => new
                {
                    StateId2 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bharat_State2s", x => x.StateId2);
                });

            migrationBuilder.CreateTable(
                name: "Bharat_City1s",
                columns: table => new
                {
                    CityId1 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State1StateId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bharat_City1s", x => x.CityId1);
                    table.ForeignKey(
                        name: "FK_Bharat_City1s_Bharat_State1s_State1StateId1",
                        column: x => x.State1StateId1,
                        principalTable: "Bharat_State1s",
                        principalColumn: "StateId1",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bharat_City2s",
                columns: table => new
                {
                    CityIdd = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State2StateId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bharat_City2s", x => x.CityIdd);
                    table.ForeignKey(
                        name: "FK_Bharat_City2s_Bharat_State1s_State2StateId1",
                        column: x => x.State2StateId1,
                        principalTable: "Bharat_State1s",
                        principalColumn: "StateId1",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bharat_Stores",
                columns: table => new
                {
                    StoreNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Ext = table.Column<int>(type: "int", nullable: false),
                    Fax = table.Column<int>(type: "int", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultFinanceCharge = table.Column<float>(type: "real", nullable: false),
                    DefaultNumberOfDays = table.Column<int>(type: "int", nullable: false),
                    CurrentAccountPeroid = table.Column<int>(type: "int", nullable: false),
                    DateOfLastArchive = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CycleBeginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State1StateId1 = table.Column<int>(type: "int", nullable: true),
                    State2StateId2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bharat_Stores", x => x.StoreNumber);
                    table.ForeignKey(
                        name: "FK_Bharat_Stores_Bharat_State1s_State1StateId1",
                        column: x => x.State1StateId1,
                        principalTable: "Bharat_State1s",
                        principalColumn: "StateId1",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bharat_Stores_Bharat_State2s_State2StateId2",
                        column: x => x.State2StateId2,
                        principalTable: "Bharat_State2s",
                        principalColumn: "StateId2",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bharat_City1s_State1StateId1",
                table: "Bharat_City1s",
                column: "State1StateId1");

            migrationBuilder.CreateIndex(
                name: "IX_Bharat_City2s_State2StateId1",
                table: "Bharat_City2s",
                column: "State2StateId1");

            migrationBuilder.CreateIndex(
                name: "IX_Bharat_Stores_State1StateId1",
                table: "Bharat_Stores",
                column: "State1StateId1");

            migrationBuilder.CreateIndex(
                name: "IX_Bharat_Stores_State2StateId2",
                table: "Bharat_Stores",
                column: "State2StateId2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bharat_City1s");

            migrationBuilder.DropTable(
                name: "Bharat_City2s");

            migrationBuilder.DropTable(
                name: "Bharat_Stores");

            migrationBuilder.DropTable(
                name: "Bharat_State1s");

            migrationBuilder.DropTable(
                name: "Bharat_State2s");
        }
    }
}
