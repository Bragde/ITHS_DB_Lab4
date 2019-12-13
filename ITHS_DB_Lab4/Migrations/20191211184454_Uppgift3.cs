using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHS_DB_Lab4.Migrations
{
    public partial class Uppgift3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            // Copy Name column to FirstName
            migrationBuilder.Sql($@"UPDATE Person
                                    SET FirstName = Name;");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Person");

            migrationBuilder.AlterColumn<int>(
                name: "PainLevel",
                table: "SessionExercise",
                nullable: true,
                defaultValue: 5,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Person",
                nullable: true);
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

            migrationBuilder.AlterColumn<int>(
                name: "PainLevel",
                table: "SessionExercise",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true,
                oldDefaultValue: 5);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Person",
                nullable: false,
                defaultValue: "");
        }
    }
}
