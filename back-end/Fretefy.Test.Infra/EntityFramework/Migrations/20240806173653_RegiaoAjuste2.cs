using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    public partial class RegiaoAjuste2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CidadeRegioes_Regioes_RegioesId",
                table: "CidadeRegioes");

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("03d698ca-1956-4e17-907f-15785675777e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1d694995-a1b7-49fc-9301-16e9fb50bb19"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1d7beb95-a8a7-4e2e-baff-fc3ac99f9c3a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2650f17e-d0ec-4d98-abc6-d561bdc555e9"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("268d7048-02b1-4d78-b424-8f1b79c15b2a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("28dd60eb-1106-4615-b51b-725ada1e2685"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2e932bff-d40f-4bcb-841b-038087d5a043"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("370a19c4-af1c-48e4-a45b-be8092211ebb"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("3ab8684b-11c5-4b15-ab09-4c6802f5c968"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("498c53da-3c46-4c4f-89f8-923e2646d6fa"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4e8916f2-1ab0-448c-8976-2f7321b1d961"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("540870de-02a7-4991-84ad-f056cb30932b"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5b0a4d05-0d7e-4f58-b99a-e64da0062146"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5d1f71d1-3e91-46ca-a261-82f7be9ca125"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a0c3fa1d-5f65-4b56-81ef-e584a7faf60f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("aa7b9b1a-f4e5-44ea-8458-c28c9658ac28"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ac1bb9ef-e9ff-457f-ba17-d8449a9f7e42"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("b46edf50-9c76-4282-a9f1-fc77e136fe4c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("b642b18b-4aa6-49ee-98a5-e5a9f6c594ea"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c050115a-dbc4-49a9-87a6-5adc0907e055"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c71a78a4-9b78-48fb-a18a-b9086bca2637"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ca4f32bd-2c1b-4c83-b816-f055a4790f02"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ebc854e7-cd51-4df2-8ecb-16475fb86a8f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f006e663-f9ca-472f-ba52-6d442bfdb00c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f223621e-e5e2-40b2-8458-f7b875c13883"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f9102ac8-534f-4e47-a12d-e684721fcd33"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("fb8eb055-7424-491c-9fa4-d596f70a9a53"));

            migrationBuilder.AlterColumn<int>(
                name: "RegioesId",
                table: "CidadeRegioes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("1f1fd04b-5498-443b-83d5-6883e37af8ae"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a866ca9c-d36a-46e7-b102-e9588ace6b01"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("06071b07-f06e-4700-81f9-9be1edaddfc5"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("40229fac-b50a-4198-83d8-2b2cc0076344"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("26aa6f88-061f-417b-9932-31ff56dbe049"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("15a29ee1-73ac-4553-8650-1ee0961a2c9a"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("2278d0d5-f595-46ad-bba3-ad3517deffdb"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("186feaa7-e992-4e18-98a6-608644616f7f"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a3fe2cd4-a538-46ee-89db-16d0c684fc7a"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("fb42a5c1-269a-4fed-911c-885177ba42ae"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("69ae9df7-46ab-439e-8fcb-ca5f6f3bb2b1"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("720d1e80-3fad-4e69-93ef-4bd06bffe209"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ba94204c-bfdd-42a3-94d0-0d4a44a0657f"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("89ea735e-4a46-4780-a492-1a813fa44b6b"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ec66700a-51b1-4fe3-bea5-de3d4a059a6a"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("98fd704d-5031-42a9-bda0-d687a0ae9951"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("aff71efc-453f-43d7-9053-8b2a0a1da6cd"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e4ac3d0c-8235-49a1-a30a-01b396e58ea9"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("87100fe9-c0bb-41b9-924d-bf99be9ca641"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("872c9496-5ab3-423c-a57b-ad361a747603"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("3c4e9be4-1174-4c4d-92fb-982de270b3d1"), "Fortaleza", " CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("46ad8d62-58dd-4859-a995-fb8fc7b33d46"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("15b2c28a-3bb2-43ec-a8f2-a4fc253fd880"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("9d7d5b63-db4c-4a42-861e-975eb01b1acc"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("d72438e3-0af9-4a8a-bfe1-1ea0e7a33724"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("021ff6e7-dddb-4f8a-982c-f14a1df43423"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("883a68cc-4838-4bc3-9fb9-e04258bffc5f"), "Palmas", "TO" });

            migrationBuilder.AddForeignKey(
                name: "FK_CidadeRegioes_Regioes_RegioesId",
                table: "CidadeRegioes",
                column: "RegioesId",
                principalTable: "Regioes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CidadeRegioes_Regioes_RegioesId",
                table: "CidadeRegioes");

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("021ff6e7-dddb-4f8a-982c-f14a1df43423"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("06071b07-f06e-4700-81f9-9be1edaddfc5"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("15a29ee1-73ac-4553-8650-1ee0961a2c9a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("15b2c28a-3bb2-43ec-a8f2-a4fc253fd880"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("186feaa7-e992-4e18-98a6-608644616f7f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1f1fd04b-5498-443b-83d5-6883e37af8ae"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2278d0d5-f595-46ad-bba3-ad3517deffdb"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("26aa6f88-061f-417b-9932-31ff56dbe049"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("3c4e9be4-1174-4c4d-92fb-982de270b3d1"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("40229fac-b50a-4198-83d8-2b2cc0076344"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("46ad8d62-58dd-4859-a995-fb8fc7b33d46"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("69ae9df7-46ab-439e-8fcb-ca5f6f3bb2b1"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("720d1e80-3fad-4e69-93ef-4bd06bffe209"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("87100fe9-c0bb-41b9-924d-bf99be9ca641"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("872c9496-5ab3-423c-a57b-ad361a747603"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("883a68cc-4838-4bc3-9fb9-e04258bffc5f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("89ea735e-4a46-4780-a492-1a813fa44b6b"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("98fd704d-5031-42a9-bda0-d687a0ae9951"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("9d7d5b63-db4c-4a42-861e-975eb01b1acc"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a3fe2cd4-a538-46ee-89db-16d0c684fc7a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a866ca9c-d36a-46e7-b102-e9588ace6b01"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("aff71efc-453f-43d7-9053-8b2a0a1da6cd"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ba94204c-bfdd-42a3-94d0-0d4a44a0657f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d72438e3-0af9-4a8a-bfe1-1ea0e7a33724"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e4ac3d0c-8235-49a1-a30a-01b396e58ea9"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ec66700a-51b1-4fe3-bea5-de3d4a059a6a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("fb42a5c1-269a-4fed-911c-885177ba42ae"));

            migrationBuilder.AlterColumn<int>(
                name: "RegioesId",
                table: "CidadeRegioes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("b642b18b-4aa6-49ee-98a5-e5a9f6c594ea"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("370a19c4-af1c-48e4-a45b-be8092211ebb"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("268d7048-02b1-4d78-b424-8f1b79c15b2a"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("540870de-02a7-4991-84ad-f056cb30932b"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("3ab8684b-11c5-4b15-ab09-4c6802f5c968"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ca4f32bd-2c1b-4c83-b816-f055a4790f02"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("b46edf50-9c76-4282-a9f1-fc77e136fe4c"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("4e8916f2-1ab0-448c-8976-2f7321b1d961"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("5d1f71d1-3e91-46ca-a261-82f7be9ca125"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("fb8eb055-7424-491c-9fa4-d596f70a9a53"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f006e663-f9ca-472f-ba52-6d442bfdb00c"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f9102ac8-534f-4e47-a12d-e684721fcd33"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f223621e-e5e2-40b2-8458-f7b875c13883"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c050115a-dbc4-49a9-87a6-5adc0907e055"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("5b0a4d05-0d7e-4f58-b99a-e64da0062146"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("2e932bff-d40f-4bcb-841b-038087d5a043"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c71a78a4-9b78-48fb-a18a-b9086bca2637"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("498c53da-3c46-4c4f-89f8-923e2646d6fa"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("aa7b9b1a-f4e5-44ea-8458-c28c9658ac28"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("28dd60eb-1106-4615-b51b-725ada1e2685"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ac1bb9ef-e9ff-457f-ba17-d8449a9f7e42"), "Fortaleza", " CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("1d694995-a1b7-49fc-9301-16e9fb50bb19"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("1d7beb95-a8a7-4e2e-baff-fc3ac99f9c3a"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("2650f17e-d0ec-4d98-abc6-d561bdc555e9"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("03d698ca-1956-4e17-907f-15785675777e"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ebc854e7-cd51-4df2-8ecb-16475fb86a8f"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a0c3fa1d-5f65-4b56-81ef-e584a7faf60f"), "Palmas", "TO" });

            migrationBuilder.AddForeignKey(
                name: "FK_CidadeRegioes_Regioes_RegioesId",
                table: "CidadeRegioes",
                column: "RegioesId",
                principalTable: "Regioes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
