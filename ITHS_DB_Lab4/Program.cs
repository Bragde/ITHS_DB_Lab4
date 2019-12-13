using System;
using System.Collections.Generic;
using System.Linq;

namespace ITHS_DB_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

                
            
            // Run to populate database
            //Database.AddDevSeed();

            /*
             
                        // Copy Name column to FirstName
            migrationBuilder.Sql($@"UPDATE Person
                                    SET FirstName = Name;");

            //Split Name on blankspace. Leave the first name in FirstName 
            //   and send the rest to LastName. 
            using (var db = new ExersiceContext())
            {
                foreach (var person in db.Person)
                {
                    var nameParts = person.FirstName.Split(" ");
                    person.FirstName = nameParts[0];
                    if (nameParts.Length < 2)
                        person.LastName = "";
                    else
                    {
                        for (int i = 1; i < nameParts.Length; i++)
                        {
                            person.LastName += nameParts[i] + " ";
                        }
                    }
                }
            }

            */
        }
    }
}
