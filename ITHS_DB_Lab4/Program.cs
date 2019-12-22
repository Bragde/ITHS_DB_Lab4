using ITHS_DB_Lab4_ClassLib.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ITHS_DB_Lab4_DbModel
{
    class Program
    {
        static void Main(string[] args)
        {
            // UPPGIFT 4 - HÄMTA DATA
            using (var db = new ExersiceContext())
            {
                Console.WriteLine("SAMTLIGA PERSONER OCH DERAS TRÄNINGSPASS\n");

                var persons = db.Person
                              .OrderBy(p => p.FirstName)
                              .ThenBy(p => p.LastName)
                              .Include(p => p.Sessions)
                              .ToList();

                foreach (var p in persons)
                {
                    Console.WriteLine(p);
                    var sessions = p.Sessions;
                    foreach (var s in sessions)
                    {
                        Console.WriteLine($"\t{s}");
                    }
                    Console.WriteLine();
                }
            }

            using (var db = new ExersiceContext())
            {
                Console.WriteLine("ALL UTRUSTNING SOM INTE ANVÄNDS\n");

                var gear = db.Gear
                           .Include(g => g.SessionGear)
                           .Where(g => !g.SessionGear
                           .Exists(sg => sg.GearId == g.Id))
                           .ToList();

                foreach (var g in gear) Console.WriteLine($@"{g.Name}");
                Console.WriteLine();
            }

            using (var db = new ExersiceContext())
            {
                Console.WriteLine("HUR MÅNGA GÅNGER VARJE UTRUSTNING HAR ANVÄNDS\n");

                var query = db.Gear
                            .GroupJoin(db.SessionGear, g => g.Id, sg => sg.GearId, (g, gCol) =>
                            new
                            {
                                Name = g.Name,
                                Count = gCol.Count()
                            });

                foreach (var col in query)
                {
                    Console.WriteLine($@"{col.Name} {col.Count}");
                }
                Console.WriteLine();
            }

            using (var db = new ExersiceContext())
            {
                Console.WriteLine("VILKEN ÖVNING SOM HAR VARIT JOBBIGAST\n");

                // Join tables
                var qJoin = from se in db.SessionExercise
                            join s in db.Session on se.SessionId equals s.Id
                            join p in db.Person on s.PersonId equals p.Id
                            join e in db.Exercise on se.ExerciseId equals e.Id
                            select new
                            {
                                Name = p.FirstName + p.LastName,
                                Session = s.Name,
                                Pain = se.PainLevel,
                                Exercise = e.Name
                            };

                // Group, order then take 1
                var qGroup = (from i in qJoin
                             group i by i.Pain into gr
                             orderby gr.Key descending
                             select gr).Take(1);

                foreach (var painGroup in qGroup)
                {
                    Console.WriteLine($"Pain level: {painGroup.Key}");
                    foreach (var session in painGroup)
                    {
                        Console.WriteLine($"" +
                            $"{session.Name} " +
                            $"{session.Session} " +
                            $"{session.Exercise}");
                    }
                }
            }
        }
    }
}
