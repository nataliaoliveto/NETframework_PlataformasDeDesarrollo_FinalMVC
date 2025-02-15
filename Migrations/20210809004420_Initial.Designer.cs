﻿// <auto-generated />
using System;
using Final.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Final.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210809004420_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Final.Models.Alojamiento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("aBarrio")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("aCantPersonas")
                        .HasColumnType("int");

                    b.Property<string>("aCiudad")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("aCodigo")
                        .HasColumnType("int");

                    b.Property<int>("aEstrellas")
                        .HasColumnType("int");

                    b.Property<bool>("aTV")
                        .HasColumnType("bit");

                    b.Property<int>("cHabitaciones")
                        .HasColumnType("int");

                    b.Property<double>("cPrecioxDia")
                        .HasColumnType("float");

                    b.Property<int>("cbanios")
                        .HasColumnType("int");

                    b.Property<double>("hPrecioxPersona")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Alojamiento");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Tipo = "Hotel",
                            aBarrio = "Palermo",
                            aCantPersonas = 300,
                            aCiudad = "CABA",
                            aCodigo = 1,
                            aEstrellas = 4,
                            aTV = true,
                            cHabitaciones = 0,
                            cPrecioxDia = 0.0,
                            cbanios = 0,
                            hPrecioxPersona = 150.0
                        },
                        new
                        {
                            id = 2,
                            Tipo = "Hotel",
                            aBarrio = "Palermo",
                            aCantPersonas = 200,
                            aCiudad = "CABA",
                            aCodigo = 2,
                            aEstrellas = 5,
                            aTV = true,
                            cHabitaciones = 0,
                            cPrecioxDia = 0.0,
                            cbanios = 0,
                            hPrecioxPersona = 200.0
                        },
                        new
                        {
                            id = 3,
                            Tipo = "Hotel",
                            aBarrio = "Belgrano",
                            aCantPersonas = 200,
                            aCiudad = "CABA",
                            aCodigo = 3,
                            aEstrellas = 4,
                            aTV = true,
                            cHabitaciones = 0,
                            cPrecioxDia = 0.0,
                            cbanios = 0,
                            hPrecioxPersona = 150.0
                        },
                        new
                        {
                            id = 4,
                            Tipo = "Hotel",
                            aBarrio = "Retiro",
                            aCantPersonas = 400,
                            aCiudad = "CABA",
                            aCodigo = 4,
                            aEstrellas = 3,
                            aTV = true,
                            cHabitaciones = 0,
                            cPrecioxDia = 0.0,
                            cbanios = 0,
                            hPrecioxPersona = 100.0
                        },
                        new
                        {
                            id = 5,
                            Tipo = "Hotel",
                            aBarrio = "San Nicolas",
                            aCantPersonas = 350,
                            aCiudad = "CABA",
                            aCodigo = 5,
                            aEstrellas = 3,
                            aTV = true,
                            cHabitaciones = 0,
                            cPrecioxDia = 0.0,
                            cbanios = 0,
                            hPrecioxPersona = 90.0
                        },
                        new
                        {
                            id = 6,
                            Tipo = "Cabania",
                            aBarrio = "La Falda",
                            aCantPersonas = 5,
                            aCiudad = "Cordoba",
                            aCodigo = 6,
                            aEstrellas = 3,
                            aTV = true,
                            cHabitaciones = 2,
                            cPrecioxDia = 50.0,
                            cbanios = 1,
                            hPrecioxPersona = 0.0
                        },
                        new
                        {
                            id = 7,
                            Tipo = "Cabania",
                            aBarrio = "La Falda",
                            aCantPersonas = 10,
                            aCiudad = "Cordoba",
                            aCodigo = 7,
                            aEstrellas = 3,
                            aTV = true,
                            cHabitaciones = 4,
                            cPrecioxDia = 50.0,
                            cbanios = 1,
                            hPrecioxPersona = 0.0
                        },
                        new
                        {
                            id = 8,
                            Tipo = "Cabania",
                            aBarrio = "Mina Clavero",
                            aCantPersonas = 6,
                            aCiudad = "Cordoba",
                            aCodigo = 8,
                            aEstrellas = 2,
                            aTV = false,
                            cHabitaciones = 4,
                            cPrecioxDia = 30.0,
                            cbanios = 2,
                            hPrecioxPersona = 0.0
                        },
                        new
                        {
                            id = 9,
                            Tipo = "Cabania",
                            aBarrio = "Mina Clavero",
                            aCantPersonas = 8,
                            aCiudad = "Cordoba",
                            aCodigo = 9,
                            aEstrellas = 2,
                            aTV = true,
                            cHabitaciones = 3,
                            cPrecioxDia = 35.0,
                            cbanios = 2,
                            hPrecioxPersona = 0.0
                        },
                        new
                        {
                            id = 10,
                            Tipo = "Cabania",
                            aBarrio = "Nono",
                            aCantPersonas = 4,
                            aCiudad = "Cordoba",
                            aCodigo = 10,
                            aEstrellas = 2,
                            aTV = false,
                            cHabitaciones = 1,
                            cPrecioxDia = 55.0,
                            cbanios = 1,
                            hPrecioxPersona = 0.0
                        });
                });

            modelBuilder.Entity("Final.Models.Reserva", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cantPersonas")
                        .HasColumnType("int");

                    b.Property<DateTime>("fDesde")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("fHasta")
                        .HasColumnType("datetime");

                    b.Property<int>("personaId")
                        .HasColumnType("int");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(16,2)");

                    b.Property<int>("propiedadId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("personaId");

                    b.HasIndex("propiedadId");

                    b.ToTable("Reserva");

                    b.HasData(
                        new
                        {
                            id = 1,
                            cantPersonas = 3,
                            fDesde = new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fHasta = new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            personaId = 5,
                            precio = 4200m,
                            propiedadId = 2
                        },
                        new
                        {
                            id = 2,
                            cantPersonas = 4,
                            fDesde = new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fHasta = new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            personaId = 2,
                            precio = 2160m,
                            propiedadId = 5
                        },
                        new
                        {
                            id = 3,
                            cantPersonas = 2,
                            fDesde = new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fHasta = new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            personaId = 3,
                            precio = 300m,
                            propiedadId = 6
                        },
                        new
                        {
                            id = 4,
                            cantPersonas = 5,
                            fDesde = new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fHasta = new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            personaId = 4,
                            precio = 4950m,
                            propiedadId = 5
                        },
                        new
                        {
                            id = 5,
                            cantPersonas = 2,
                            fDesde = new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fHasta = new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            personaId = 5,
                            precio = 4400m,
                            propiedadId = 2
                        },
                        new
                        {
                            id = 6,
                            cantPersonas = 3,
                            fDesde = new DateTime(2021, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fHasta = new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            personaId = 2,
                            precio = 6600m,
                            propiedadId = 2
                        },
                        new
                        {
                            id = 7,
                            cantPersonas = 3,
                            fDesde = new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fHasta = new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            personaId = 4,
                            precio = 930m,
                            propiedadId = 8
                        });
                });

            modelBuilder.Entity("Final.Models.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DNI")
                        .HasColumnType("int");

                    b.Property<bool>("bloqueado")
                        .HasColumnType("bit");

                    b.Property<bool>("esADMIN")
                        .HasColumnType("bit");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("id");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            id = 1,
                            DNI = 11111111,
                            bloqueado = false,
                            esADMIN = true,
                            mail = "admin@admin.com",
                            nombre = "admin",
                            password = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918"
                        },
                        new
                        {
                            id = 2,
                            DNI = 12121212,
                            bloqueado = false,
                            esADMIN = false,
                            mail = "luisjose@hotmail.com",
                            nombre = "Luis",
                            password = "9250e222c4c71f0c58d4c54b50a880a312e9f9fed55d5c3aa0b0e860ded99165"
                        },
                        new
                        {
                            id = 3,
                            DNI = 13131313,
                            bloqueado = false,
                            esADMIN = false,
                            mail = "pedropablo@hotmail.com",
                            nombre = "Pedro",
                            password = "9250e222c4c71f0c58d4c54b50a880a312e9f9fed55d5c3aa0b0e860ded99165"
                        },
                        new
                        {
                            id = 4,
                            DNI = 14141414,
                            bloqueado = false,
                            esADMIN = false,
                            mail = "leoparedes@hotmail.com",
                            nombre = "Leo",
                            password = "9250e222c4c71f0c58d4c54b50a880a312e9f9fed55d5c3aa0b0e860ded99165"
                        },
                        new
                        {
                            id = 5,
                            DNI = 22222222,
                            bloqueado = false,
                            esADMIN = false,
                            mail = "juanperez@hotmail.com",
                            nombre = "Juan",
                            password = "9250e222c4c71f0c58d4c54b50a880a312e9f9fed55d5c3aa0b0e860ded99165"
                        },
                        new
                        {
                            id = 6,
                            DNI = 33333333,
                            bloqueado = false,
                            esADMIN = true,
                            mail = "juancarlosbatman@hotmail.com",
                            nombre = "Batman",
                            password = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918"
                        });
                });

            modelBuilder.Entity("Final.Models.Reserva", b =>
                {
                    b.HasOne("Final.Models.Usuario", "persona")
                        .WithMany()
                        .HasForeignKey("personaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final.Models.Alojamiento", "propiedad")
                        .WithMany()
                        .HasForeignKey("propiedadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
