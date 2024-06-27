using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LOCADORABASE.Migrations
{
    public partial class pio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LOCADORABASE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmeEmprestado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEmprestimo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOCADORABASE", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LOCADORABASE");
        }
    }
}
