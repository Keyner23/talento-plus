using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TalentoPlus.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Documento = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    Apellidos = table.Column<string>(type: "text", nullable: true),
                    FechaNacimiento = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    Telefono = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Cargo = table.Column<string>(type: "text", nullable: true),
                    Salario = table.Column<string>(type: "text", nullable: true),
                    FechaIngreso = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    NivelEducativo = table.Column<string>(type: "text", nullable: true),
                    PerfilProfesional = table.Column<string>(type: "text", nullable: true),
                    Departamento = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Documento);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
