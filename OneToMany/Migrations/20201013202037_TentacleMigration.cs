using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OneToMany.Migrations
{
    public partial class TentacleMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tentacles",
                columns: table => new
                {
                    TentacleId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Num_Suction_Cups = table.Column<int>(nullable: false),
                    Has_Boxing_Glove = table.Column<bool>(nullable: false),
                    Length = table.Column<int>(nullable: false),
                    OctopusId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tentacles", x => x.TentacleId);
                    table.ForeignKey(
                        name: "FK_Tentacles_Octopi_OctopusId",
                        column: x => x.OctopusId,
                        principalTable: "Octopi",
                        principalColumn: "OctopusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tentacles_OctopusId",
                table: "Tentacles",
                column: "OctopusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tentacles");
        }
    }
}
