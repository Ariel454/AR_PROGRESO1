using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AR_PROGRESO1.Migrations
{
    public partial class ARBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ARAURA",
                columns: table => new
                {
                    arCodigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    arCalificacionFinal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    arNombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    arCorreo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    arCodigoPostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    arEstudianteNuevo = table.Column<bool>(type: "bit", nullable: false),
                    arFechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    arPromedioConducta = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARAURA", x => x.arCodigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ARAURA");
        }
    }
}
