﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurantes",
                columns: table => new
                {
                    NIT = table.Column<string>(type: "varchar(15)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(20)", nullable: true),
                    Propietario = table.Column<string>(type: "varchar(20)", nullable: true),
                    Direccion = table.Column<string>(type: "varchar(25)", nullable: true),
                    CantidadPersonal = table.Column<int>(type: "int", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    Sedes = table.Column<int>(type: "int", nullable: false),
                    AñoFuncionamiento = table.Column<int>(type: "int", nullable: false),
                    Especialidad = table.Column<string>(type: "nvarchar(25)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurantes", x => x.NIT);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    User = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.User);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Identificacion = table.Column<string>(type: "varchar(12)", nullable: false),
                    Nombres = table.Column<string>(type: "varchar(20)", nullable: true),
                    Apellidos = table.Column<string>(type: "varchar(20)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Sexo = table.Column<string>(type: "varchar(10)", nullable: true),
                    Telefono = table.Column<string>(type: "varchar(15)", nullable: true),
                    Email = table.Column<string>(type: "varchar(15)", nullable: true),
                    EstadoCivil = table.Column<string>(type: "varchar(15)", nullable: true),
                    PaisProcedencia = table.Column<string>(type: "varchar(15)", nullable: true),
                    NivelEducativo = table.Column<string>(type: "varchar(15)", nullable: true),
                    Idrestaurante = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Identificacion);
                    table.ForeignKey(
                        name: "FK_Personas_Restaurantes_Idrestaurante",
                        column: x => x.Idrestaurante,
                        principalTable: "Restaurantes",
                        principalColumn: "NIT",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Actitudes",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pregunta1 = table.Column<string>(type: "varchar(10)", nullable: true),
                    Pregunta2 = table.Column<string>(type: "varchar(10)", nullable: true),
                    Pregunta3 = table.Column<string>(type: "varchar(10)", nullable: true),
                    Pregunta4 = table.Column<string>(type: "varchar(50)", nullable: true),
                    Pregunta5 = table.Column<string>(type: "varchar(10)", nullable: true),
                    Pregunta6 = table.Column<string>(type: "varchar(10)", nullable: true),
                    Idpersona = table.Column<string>(type: "varchar(12)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actitudes", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Actitudes_Personas_Idpersona",
                        column: x => x.Idpersona,
                        principalTable: "Personas",
                        principalColumn: "Identificacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Conocimientos",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pregunta1 = table.Column<string>(type: "varchar(10)", nullable: true),
                    Pregunta2 = table.Column<string>(type: "varchar(10)", nullable: true),
                    Pregunta3 = table.Column<string>(type: "varchar(10)", nullable: true),
                    Pregunta4 = table.Column<string>(type: "varchar(50)", nullable: true),
                    Pregunta5 = table.Column<string>(type: "varchar(10)", nullable: true),
                    Pregunta6 = table.Column<string>(type: "varchar(10)", nullable: true),
                    Idpersona = table.Column<string>(type: "varchar(12)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conocimientos", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Conocimientos_Personas_Idpersona",
                        column: x => x.Idpersona,
                        principalTable: "Personas",
                        principalColumn: "Identificacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Practicas",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pregunta1 = table.Column<string>(type: "varchar(10)", nullable: true),
                    Pregunta2 = table.Column<string>(type: "varchar(10)", nullable: true),
                    Pregunta3 = table.Column<string>(type: "varchar(10)", nullable: true),
                    Pregunta4 = table.Column<string>(type: "varchar(10)", nullable: true),
                    Idpersona = table.Column<string>(type: "varchar(12)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Practicas", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Practicas_Personas_Idpersona",
                        column: x => x.Idpersona,
                        principalTable: "Personas",
                        principalColumn: "Identificacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actitudes_Idpersona",
                table: "Actitudes",
                column: "Idpersona");

            migrationBuilder.CreateIndex(
                name: "IX_Conocimientos_Idpersona",
                table: "Conocimientos",
                column: "Idpersona");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Idrestaurante",
                table: "Personas",
                column: "Idrestaurante");

            migrationBuilder.CreateIndex(
                name: "IX_Practicas_Idpersona",
                table: "Practicas",
                column: "Idpersona");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actitudes");

            migrationBuilder.DropTable(
                name: "Conocimientos");

            migrationBuilder.DropTable(
                name: "Practicas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Restaurantes");
        }
    }
}
