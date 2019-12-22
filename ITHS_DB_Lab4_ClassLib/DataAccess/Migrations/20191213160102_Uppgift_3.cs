using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHS_DB_Lab4_DbModel.Migrations
{
    public partial class Uppgift_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Person",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Person",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            /* Flytta Name till FirstName för att inte förlora data.
             * Sedan dropas kolumnen Name.
             * Kör migrering "MigrateData_Uppgift_3" efter denna för att justera
             * namn så att förnamn och efternamn hamnar i rätt kolumner. */

            migrationBuilder.Sql($@"UPDATE Person
                                    SET FirstName = Name");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Person");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Person");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Person",
                nullable: false,
                defaultValue: "");
        }
    }
}
