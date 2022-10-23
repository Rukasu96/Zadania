using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lekcja12.Migrations
{
    public partial class characterTypetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "Characters");

            migrationBuilder.CreateTable(
                name: "CharacterTypes",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTypes", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "CharacterCharacterType",
                columns: table => new
                {
                    CharactersId = table.Column<int>(type: "int", nullable: false),
                    TypesKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterCharacterType", x => new { x.CharactersId, x.TypesKey });
                    table.ForeignKey(
                        name: "FK_CharacterCharacterType_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterCharacterType_CharacterTypes_TypesKey",
                        column: x => x.TypesKey,
                        principalTable: "CharacterTypes",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterCharacterType_TypesKey",
                table: "CharacterCharacterType",
                column: "TypesKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterCharacterType");

            migrationBuilder.DropTable(
                name: "CharacterTypes");

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
