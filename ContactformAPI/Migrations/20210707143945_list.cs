using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactformAPI.Migrations
{
    public partial class list : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactformDetails",
                columns: table => new
                {
                    ContactformDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Theme = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactformDetails", x => x.ContactformDetailId);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Theme = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserContactforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    UserTelephone = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContactforms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactformDbs",
                columns: table => new
                {
                    ContactformDbId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DbMessage = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Theme = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    UserContactformId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactformDbs", x => x.ContactformDbId);
                    table.ForeignKey(
                        name: "FK_ContactformDbs_UserContactforms_UserContactformId",
                        column: x => x.UserContactformId,
                        principalTable: "UserContactforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactformDbs_UserContactformId",
                table: "ContactformDbs",
                column: "UserContactformId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactformDbs");

            migrationBuilder.DropTable(
                name: "ContactformDetails");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropTable(
                name: "UserContactforms");
        }
    }
}
