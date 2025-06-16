using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coreuygulama.Migrations
{
    /// <inheritdoc />
    public partial class createDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turlers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kitapturu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turlers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Yazarlars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    YazarBilgi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazarlars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplars",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kitapadi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    basimyili = table.Column<int>(type: "int", nullable: false),
                    turid = table.Column<int>(type: "int", nullable: false),
                    turlerid = table.Column<int>(type: "int", nullable: false),
                    YazarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplars", x => x.id);
                    table.ForeignKey(
                        name: "FK_Kitaplars_Turlers_turlerid",
                        column: x => x.turlerid,
                        principalTable: "Turlers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitaplars_Yazarlars_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Yazarlars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplars_turlerid",
                table: "Kitaplars",
                column: "turlerid");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplars_YazarId",
                table: "Kitaplars",
                column: "YazarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kitaplars");

            migrationBuilder.DropTable(
                name: "Turlers");

            migrationBuilder.DropTable(
                name: "Yazarlars");
        }
    }
}
