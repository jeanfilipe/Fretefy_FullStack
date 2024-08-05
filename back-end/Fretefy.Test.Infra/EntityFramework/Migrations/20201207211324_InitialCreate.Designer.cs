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
    [Migration("20201207211324_InitialCreate")]
    partial class InitialCreate
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
                            Id = new Guid("afc12ff5-eacd-420a-835a-69e9b3b7821c"),
                            Nome = "Rio Branco",
                            UF = "AC"
                        },
                        new
                        {
                            Id = new Guid("a3fc3b39-3c3c-4a58-8c50-fdd19209777f"),
                            Nome = "Maceió",
                            UF = "AL"
                        },
                        new
                        {
                            Id = new Guid("ec8390ca-f9a5-4a9e-9654-9405ccbabc7c"),
                            Nome = "Macapá",
                            UF = "AP"
                        },
                        new
                        {
                            Id = new Guid("596df90c-e617-45cb-be33-826801519e46"),
                            Nome = "Manaus",
                            UF = "AM"
                        },
                        new
                        {
                            Id = new Guid("784647e2-5430-459e-898b-4c915ee4b412"),
                            Nome = "Salvador",
                            UF = "BA"
                        },
                        new
                        {
                            Id = new Guid("e3dcbced-4326-4007-94df-c33f8c77a204"),
                            Nome = "Fortaleza",
                            UF = " CE"
                        },
                        new
                        {
                            Id = new Guid("46698f17-4273-4e5c-a56d-dda97d426f26"),
                            Nome = "Brasília",
                            UF = "DF"
                        },
                        new
                        {
                            Id = new Guid("439a8192-2f0f-43a7-8a2c-ee9bbbd6c4d3"),
                            Nome = "Vitória",
                            UF = "ES"
                        },
                        new
                        {
                            Id = new Guid("bb824c5c-a427-4a95-a7b4-f8183f3f8e94"),
                            Nome = "Goiânia",
                            UF = "GO"
                        },
                        new
                        {
                            Id = new Guid("18e191f0-eef9-4451-bea1-de5f78d125f8"),
                            Nome = "São Luís",
                            UF = "MA"
                        },
                        new
                        {
                            Id = new Guid("588c12b7-703c-4944-b5ba-0fbed191eb02"),
                            Nome = "Cuiabá",
                            UF = "MT"
                        },
                        new
                        {
                            Id = new Guid("72b8cfd2-617d-435e-8f79-6e6e46aac155"),
                            Nome = "Campo Grande",
                            UF = "MS"
                        },
                        new
                        {
                            Id = new Guid("4b4077ab-47f7-44b6-bf44-56f03ca18532"),
                            Nome = "Belo Horizonte",
                            UF = "MG"
                        },
                        new
                        {
                            Id = new Guid("e7d03670-5d06-40dd-a4d8-41c4fe49a994"),
                            Nome = "Belém",
                            UF = "PA"
                        },
                        new
                        {
                            Id = new Guid("eff2ddee-6df9-4d52-80b7-1e4b1164e343"),
                            Nome = "João Pessoa",
                            UF = "PB"
                        },
                        new
                        {
                            Id = new Guid("dc5ff91b-68d1-4759-9dba-4ade4bd4740d"),
                            Nome = "Curitiba",
                            UF = "PR"
                        },
                        new
                        {
                            Id = new Guid("653fcdce-73b1-47ac-9e98-a5380bec8788"),
                            Nome = "Recife",
                            UF = "PE"
                        },
                        new
                        {
                            Id = new Guid("0a8e109c-ee00-40d6-9a01-040618746f2f"),
                            Nome = "Teresina",
                            UF = "PI"
                        },
                        new
                        {
                            Id = new Guid("6756d8f6-3f78-4886-91dd-e4753f9e72bc"),
                            Nome = "Rio de Janeiro",
                            UF = "RJ"
                        },
                        new
                        {
                            Id = new Guid("f8e6890f-e0d0-46ec-8f34-292de4b1f83b"),
                            Nome = "Natal",
                            UF = "RN"
                        },
                        new
                        {
                            Id = new Guid("ec209ffa-37ea-4587-8bc6-8afe7cd00042"),
                            Nome = "Porto Alegre",
                            UF = "RS"
                        },
                        new
                        {
                            Id = new Guid("0a8248d1-3b62-4fb7-afc8-955b1c8ebc61"),
                            Nome = "Porto Velho",
                            UF = "RO"
                        },
                        new
                        {
                            Id = new Guid("c04bb270-65a7-4577-bd4c-631fa931d0e2"),
                            Nome = "Boa Vista",
                            UF = "RR"
                        },
                        new
                        {
                            Id = new Guid("a71ac957-1859-49b7-aa65-cc9327f4a3ce"),
                            Nome = "Florianópolis",
                            UF = "SC"
                        },
                        new
                        {
                            Id = new Guid("c215fc2e-bcda-4404-8efb-4b23c4433c5b"),
                            Nome = "São Paulo",
                            UF = "SP"
                        },
                        new
                        {
                            Id = new Guid("7d73f17e-90d6-4230-a391-31520365ca67"),
                            Nome = "Aracaju",
                            UF = "SE"
                        },
                        new
                        {
                            Id = new Guid("6ab3cbd8-bcdf-4287-bee3-5885fb656d08"),
                            Nome = "Palmas",
                            UF = "TO"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
