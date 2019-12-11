using System;
using System.Collections.Generic;
using System.Linq;

namespace ITHS_DB_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ExersiceContext())
            {
                // ADD PERSONS
                var annaAndersson = new Person { Name = "Anna Andersson" };
                db.Person.Add(annaAndersson);
                var bennyBengtsson = new Person { Name = "Benny Bengtsson" };
                db.Person.Add(bennyBengtsson);
                var carinCarlsson = new Person { Name = "Carin Carlsson" };
                db.Person.Add(carinCarlsson);

                // ADD EXERCISE SESSIONS
                var session_1 = new Running() { 
                    Person = annaAndersson, 
                    Name = "Löppass", 
                    Description = "Genom skogen", 
                    Time = 2.34f};
                session_1.Exercises.Add(new Exercise { 
                    Name = "Långdistans" });
                db.Session.Add(session_1);

                var session_2 = new Running() { 
                    Person = annaAndersson, 
                    Name = "Löppass", 
                    Description = "Genom stan", 
                    Time = 0.30f};
                session_2.Exercises.Add(new Exercise { 
                    Name = "Intervall" });
                db.Session.Add(session_2);

                var session_3 = new Running(){ 
                    Person = annaAndersson, 
                    Name = "Löppass", 
                    Description = "På löpband", 
                    Time = 0.45f};
                session_3.Exercises.Add(new Exercise { 
                    Name = "Intervall" });
                db.Session.Add(session_3);

                db.Session.Add(new Running{ 
                    Person = annaAndersson, 
                    Name = "Löppass", 
                    Description = "På löpband", 
                    Time = 1.54f });

                var session_4 = new Cycling(){ 
                    Person = bennyBengtsson, 
                    Name = "Cyckelpass", 
                    Description = "Genom skogen", 
                    Time = 1.43f};
                session_4.Exercises.Add(new Exercise{ 
                    Name = "Teräng"});
                db.Session.Add(session_4);

                db.Session.Add(new Cycling{ 
                    Person = bennyBengtsson, 
                    Name = "Cyckelpass", 
                    Description = "Genom stan", 
                    Time = 1.54f});

                db.Session.Add(new Cycling{ 
                    Person = bennyBengtsson, 
                    Name = "Cyckelpass ", 
                    Description = "Över åkern", 
                    Time = 2.23f});

                var session_5 = new Swiming{ 
                    Person = carinCarlsson, 
                    Name = "Simmning", 
                    Description = "I sjön", 
                    Time = 0.45f};
                session_5.Exercises.Add(new Exercise{ 
                    Name = "Crawl"});
                db.Session.Add(session_5);

                db.Session.Add(new Swiming{ 
                    Person = carinCarlsson, 
                    Name = "Simmning ", 
                    Description = "I basäng", 
                    Time = 0.30f });

                db.Session.Add(new Swiming{ 
                    Person = carinCarlsson, 
                    Name = "Simmning ", 
                    Description = "I havet", 
                    Time = 1.15f});

                db.SaveChanges();
            }
        }
    }
}
