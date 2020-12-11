﻿// <auto-generated />
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datos.Migrations
{
    [DbContext(typeof(PersonaContext))]
    [Migration("20201211035308_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entidad.Actitudes", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Idpersona")
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Pregunta1")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Pregunta2")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Pregunta3")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Pregunta4")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Pregunta5")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Pregunta6")
                        .HasColumnType("varchar(10)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(4)");

                    b.HasKey("Codigo");

                    b.HasIndex("Idpersona");

                    b.ToTable("Actitudes");
                });

            modelBuilder.Entity("Entidad.Conocimientos", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Idpersona")
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Pregunta1")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Pregunta2")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Pregunta3")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Pregunta4")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Pregunta5")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Pregunta6")
                        .HasColumnType("varchar(10)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(4)");

                    b.HasKey("Codigo");

                    b.HasIndex("Idpersona");

                    b.ToTable("Conocimientos");
                });

            modelBuilder.Entity("Entidad.ListaChequeo", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Pregunta1")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Pregunta2")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Pregunta3")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Pregunta4")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Pregunta5")
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Pregunta6")
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Pregunta7")
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Pregunta8")
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Pregunta9")
                        .HasColumnType("varchar(12)");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<string>("nit")
                        .HasColumnType("varchar(15)");

                    b.HasKey("Codigo");

                    b.HasIndex("nit");

                    b.ToTable("ListaChequeos");
                });

            modelBuilder.Entity("Entidad.Persona", b =>
                {
                    b.Property<string>("Identificacion")
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Apellidos")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Idrestaurante")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("NivelEducativo")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Nombres")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("PaisProcedencia")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Sexo")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Telefono")
                        .HasColumnType("varchar(15)");

                    b.HasKey("Identificacion");

                    b.HasIndex("Idrestaurante");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Entidad.Practicas", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Idpersona")
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Pregunta1")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Pregunta2")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Pregunta3")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Pregunta4")
                        .HasColumnType("varchar(10)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(4)");

                    b.HasKey("Codigo");

                    b.HasIndex("Idpersona");

                    b.ToTable("Practicas");
                });

            modelBuilder.Entity("Entidad.Restaurante", b =>
                {
                    b.Property<string>("NIT")
                        .HasColumnType("varchar(15)");

                    b.Property<int>("AñoFuncionamiento")
                        .HasColumnType("int");

                    b.Property<int>("CantidadPersonal")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Propietario")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Sedes")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("NIT");

                    b.ToTable("Restaurantes");
                });

            modelBuilder.Entity("Entidad.Usuario", b =>
                {
                    b.Property<string>("User")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Entidad.Actitudes", b =>
                {
                    b.HasOne("Entidad.Persona", null)
                        .WithMany()
                        .HasForeignKey("Idpersona");
                });

            modelBuilder.Entity("Entidad.Conocimientos", b =>
                {
                    b.HasOne("Entidad.Persona", null)
                        .WithMany()
                        .HasForeignKey("Idpersona");
                });

            modelBuilder.Entity("Entidad.ListaChequeo", b =>
                {
                    b.HasOne("Entidad.Restaurante", null)
                        .WithMany()
                        .HasForeignKey("nit");
                });

            modelBuilder.Entity("Entidad.Persona", b =>
                {
                    b.HasOne("Entidad.Restaurante", null)
                        .WithMany()
                        .HasForeignKey("Idrestaurante");
                });

            modelBuilder.Entity("Entidad.Practicas", b =>
                {
                    b.HasOne("Entidad.Persona", null)
                        .WithMany()
                        .HasForeignKey("Idpersona");
                });
#pragma warning restore 612, 618
        }
    }
}