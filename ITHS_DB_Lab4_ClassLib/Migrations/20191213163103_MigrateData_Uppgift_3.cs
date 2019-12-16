using ITHS_DB_Lab4_ClassLib.DataAccessService;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHS_DB_Lab4_DbModel.Migrations
{
    public partial class MigrateData_Uppgift_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            using (var db = new ExersiceContext())
            {
                // Correct first and last name after migration.
                foreach (var person in db.Person)
                {
                    var nameParts = person.FirstName.Split(" ");
                    person.FirstName = nameParts[0];
                    if (nameParts.Length < 2) person.LastName = " ";
                    else
                    {
                        for (int i = 1; i < nameParts.Length; i++)
                        {
                            person.LastName += nameParts[i] + " ";
                        }
                    }
                }

                // Set exercise pain levels to default value if no value is set.
                foreach (var exercise in db.SessionExercise)
                {
                    if (exercise.PainLevel == null) exercise.PainLevel = 5;
                }
                db.SaveChanges();
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
