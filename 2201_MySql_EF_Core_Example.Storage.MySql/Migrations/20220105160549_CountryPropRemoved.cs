using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2201_MySql_EF_Core_Example.Storage.Migrations
{
    public partial class CountryPropRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Customers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Customers",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
