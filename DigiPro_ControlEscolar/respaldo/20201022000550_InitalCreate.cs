using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiPro_ControlEscolar.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetAlumnosMaterias",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Alumnoid = table.Column<int>(nullable: false),
                    Materiaid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetAlumnosMaterias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    ApPaterno = table.Column<string>(nullable: true),
                    ApMaterno = table.Column<string>(nullable: true),
                    DetAlumnosMateriasid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => x.id);
                    table.ForeignKey(
                        name: "FK_Alumno_DetAlumnosMaterias_DetAlumnosMateriasid",
                        column: x => x.DetAlumnosMateriasid,
                        principalTable: "DetAlumnosMaterias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Materia",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApPaterno = table.Column<string>(nullable: true),
                    Costo = table.Column<decimal>(nullable: false),
                    DetAlumnosMateriasid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia", x => x.id);
                    table.ForeignKey(
                        name: "FK_Materia_DetAlumnosMaterias_DetAlumnosMateriasid",
                        column: x => x.DetAlumnosMateriasid,
                        principalTable: "DetAlumnosMaterias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumno_DetAlumnosMateriasid",
                table: "Alumno",
                column: "DetAlumnosMateriasid");

            migrationBuilder.CreateIndex(
                name: "IX_DetAlumnosMaterias_Alumnoid",
                table: "DetAlumnosMaterias",
                column: "Alumnoid");

            migrationBuilder.CreateIndex(
                name: "IX_DetAlumnosMaterias_Materiaid",
                table: "DetAlumnosMaterias",
                column: "Materiaid");

            migrationBuilder.CreateIndex(
                name: "IX_Materia_DetAlumnosMateriasid",
                table: "Materia",
                column: "DetAlumnosMateriasid");

            migrationBuilder.AddForeignKey(
                name: "FK_DetAlumnosMaterias_Alumno_Alumnoid",
                table: "DetAlumnosMaterias",
                column: "Alumnoid",
                principalTable: "Alumno",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetAlumnosMaterias_Materia_Materiaid",
                table: "DetAlumnosMaterias",
                column: "Materiaid",
                principalTable: "Materia",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alumno_DetAlumnosMaterias_DetAlumnosMateriasid",
                table: "Alumno");

            migrationBuilder.DropForeignKey(
                name: "FK_Materia_DetAlumnosMaterias_DetAlumnosMateriasid",
                table: "Materia");

            migrationBuilder.DropTable(
                name: "DetAlumnosMaterias");

            migrationBuilder.DropTable(
                name: "Alumno");

            migrationBuilder.DropTable(
                name: "Materia");
        }
    }
}
