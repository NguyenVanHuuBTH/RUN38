using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HUMG.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_H38 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "H38",
                columns: table => new
                {
                    H38ID = table.Column<string>(type: "TEXT", nullable: false),
                    H38Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H38", x => x.H38ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "H38");
        }
    }
}
