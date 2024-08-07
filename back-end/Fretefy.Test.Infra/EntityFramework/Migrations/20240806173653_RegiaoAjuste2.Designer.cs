﻿// <auto-generated />
using System;
using Fretefy.Test.Infra.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240806173653_RegiaoAjuste2")]
    partial class RegiaoAjuste2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.Cidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cidade");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1f1fd04b-5498-443b-83d5-6883e37af8ae"),
                            Nome = "Rio Branco",
                            UF = "AC"
                        },
                        new
                        {
                            Id = new Guid("d72438e3-0af9-4a8a-bfe1-1ea0e7a33724"),
                            Nome = "Maceió",
                            UF = "AL"
                        },
                        new
                        {
                            Id = new Guid("9d7d5b63-db4c-4a42-861e-975eb01b1acc"),
                            Nome = "Macapá",
                            UF = "AP"
                        },
                        new
                        {
                            Id = new Guid("15b2c28a-3bb2-43ec-a8f2-a4fc253fd880"),
                            Nome = "Manaus",
                            UF = "AM"
                        },
                        new
                        {
                            Id = new Guid("46ad8d62-58dd-4859-a995-fb8fc7b33d46"),
                            Nome = "Salvador",
                            UF = "BA"
                        },
                        new
                        {
                            Id = new Guid("3c4e9be4-1174-4c4d-92fb-982de270b3d1"),
                            Nome = "Fortaleza",
                            UF = " CE"
                        },
                        new
                        {
                            Id = new Guid("872c9496-5ab3-423c-a57b-ad361a747603"),
                            Nome = "Brasília",
                            UF = "DF"
                        },
                        new
                        {
                            Id = new Guid("87100fe9-c0bb-41b9-924d-bf99be9ca641"),
                            Nome = "Vitória",
                            UF = "ES"
                        },
                        new
                        {
                            Id = new Guid("e4ac3d0c-8235-49a1-a30a-01b396e58ea9"),
                            Nome = "Goiânia",
                            UF = "GO"
                        },
                        new
                        {
                            Id = new Guid("aff71efc-453f-43d7-9053-8b2a0a1da6cd"),
                            Nome = "São Luís",
                            UF = "MA"
                        },
                        new
                        {
                            Id = new Guid("98fd704d-5031-42a9-bda0-d687a0ae9951"),
                            Nome = "Cuiabá",
                            UF = "MT"
                        },
                        new
                        {
                            Id = new Guid("ec66700a-51b1-4fe3-bea5-de3d4a059a6a"),
                            Nome = "Campo Grande",
                            UF = "MS"
                        },
                        new
                        {
                            Id = new Guid("021ff6e7-dddb-4f8a-982c-f14a1df43423"),
                            Nome = "Belo Horizonte",
                            UF = "MG"
                        },
                        new
                        {
                            Id = new Guid("89ea735e-4a46-4780-a492-1a813fa44b6b"),
                            Nome = "Belém",
                            UF = "PA"
                        },
                        new
                        {
                            Id = new Guid("720d1e80-3fad-4e69-93ef-4bd06bffe209"),
                            Nome = "João Pessoa",
                            UF = "PB"
                        },
                        new
                        {
                            Id = new Guid("69ae9df7-46ab-439e-8fcb-ca5f6f3bb2b1"),
                            Nome = "Curitiba",
                            UF = "PR"
                        },
                        new
                        {
                            Id = new Guid("fb42a5c1-269a-4fed-911c-885177ba42ae"),
                            Nome = "Recife",
                            UF = "PE"
                        },
                        new
                        {
                            Id = new Guid("a3fe2cd4-a538-46ee-89db-16d0c684fc7a"),
                            Nome = "Teresina",
                            UF = "PI"
                        },
                        new
                        {
                            Id = new Guid("186feaa7-e992-4e18-98a6-608644616f7f"),
                            Nome = "Rio de Janeiro",
                            UF = "RJ"
                        },
                        new
                        {
                            Id = new Guid("2278d0d5-f595-46ad-bba3-ad3517deffdb"),
                            Nome = "Natal",
                            UF = "RN"
                        },
                        new
                        {
                            Id = new Guid("15a29ee1-73ac-4553-8650-1ee0961a2c9a"),
                            Nome = "Porto Alegre",
                            UF = "RS"
                        },
                        new
                        {
                            Id = new Guid("26aa6f88-061f-417b-9932-31ff56dbe049"),
                            Nome = "Porto Velho",
                            UF = "RO"
                        },
                        new
                        {
                            Id = new Guid("40229fac-b50a-4198-83d8-2b2cc0076344"),
                            Nome = "Boa Vista",
                            UF = "RR"
                        },
                        new
                        {
                            Id = new Guid("06071b07-f06e-4700-81f9-9be1edaddfc5"),
                            Nome = "Florianópolis",
                            UF = "SC"
                        },
                        new
                        {
                            Id = new Guid("a866ca9c-d36a-46e7-b102-e9588ace6b01"),
                            Nome = "São Paulo",
                            UF = "SP"
                        },
                        new
                        {
                            Id = new Guid("ba94204c-bfdd-42a3-94d0-0d4a44a0657f"),
                            Nome = "Aracaju",
                            UF = "SE"
                        },
                        new
                        {
                            Id = new Guid("883a68cc-4838-4bc3-9fb9-e04258bffc5f"),
                            Nome = "Palmas",
                            UF = "TO"
                        });
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.CidadeRegiao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeCidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("RegioesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RegioesId");

                    b.ToTable("CidadeRegioes");
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.Regiao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ativo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Regioes");
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.UF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UFs");
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.CidadeRegiao", b =>
                {
                    b.HasOne("Fretefy.Test.Domain.Entities.Regiao", "Regioes")
                        .WithMany("CidadeRegioes")
                        .HasForeignKey("RegioesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Regioes");
                });

            modelBuilder.Entity("Fretefy.Test.Domain.Entities.Regiao", b =>
                {
                    b.Navigation("CidadeRegioes");
                });
#pragma warning restore 612, 618
        }
    }
}
