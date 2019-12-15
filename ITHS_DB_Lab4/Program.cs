using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ITHS_DB_Lab4
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
                    .Where(g => !g.SessionGear.Exists(sg => sg.GearId == g.Id))
                    .ToList();

                foreach (var g in gear) Console.WriteLine($@"{g.Name}");
                Console.WriteLine();
            }

            using (var db = new ExersiceContext())
            {
                Console.WriteLine("HUR MÅNGA GÅNGER VARJE UTRUSTNING HAR ANVÄNDS\n");

                var query = db.Gear
                    .GroupJoin(db.SessionGear,
                        g => g.Id,
                        sg => sg.GearId,
                        (g, gCol) =>
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

                //var join = db.SessionExercise
                //    .Join(db.Session, se => se.SessionId, s => s.Id, (se, s) => new { se, s })
                //    .Join(db.Person, ses => ses.s.PersonId, p => p.Id, (ses, p) => new { ses, p })
                //    .Join(db.Exercise, sesp => sesp.ses.se.ExerciseId, e => e.Id, (sesp, e) => new { sesp, e })
                //    .OrderByDescending(x => x.)
                //    .GroupBy(gr => gr.sesp.ses.se.PainLevel)
                //    .Select(m => new
                //    {
                //        FirstName = m.,
                //        LastName = m.sesp.p.LastName,
                //        ExerciseName = m.e.Name,
                //        SessionName = m.sesp.ses.s.Name,
                //        Time = m.sesp.ses.s.Time,
                //        PainLevel = m.sesp.ses.se.PainLevel
                //    })
                //    //.GroupBy(m => m.PainLevel)
                //    //.OrderByDescending(m => m.)
                //    .Take(1)
                //    .ToList();

                // Query syntax
                // Join tables
                var qJoin = from p in db.Person
                            join s in db.Session on p.Id equals s.PersonId
                            join se in db.SessionExercise on s.Id equals se.SessionId
                            join e in db.Exercise on se.ExerciseId equals e.Id
                            select new
                            {
                                name = p.FirstName + p.LastName,
                                exercise = e.Name,
                                session = s.Name,
                                pain = se.PainLevel
                            };
                // Order
                var qOrder = from j in qJoin
                             orderby j.pain descending;

                //var query_2 = from se in db.SessionExercise
                //              join s in db.Session on se.SessionId equals s.Id
                //              join p in db.Person on s.PersonId equals p.Id
                //              join e in db.Exercise on se.ExerciseId equals e.Id
                //              orderby se.PainLevel descending
                //              select new
                //              {

                //              }
                //              group g by se.PainLevel
                //              select new
                //              {
                //                  name = p.FirstName + p.LastName,
                //                  exercise = e.Name,
                //                  session = s.Name,
                //                  pain = se.PainLevel
                //              };
                //var query_3 = from s in query_2
                //              group s by s.pain into g
                //              select new
                //              {
                //                  key = g.Key,
                //                  val = g.ToList()
                //              };

                //foreach (var item in query)
                //{
                //    Console.WriteLine($"" +
                //        $"{item}");
                //}
                //Console.WriteLine();
            }
        }
    }
}
