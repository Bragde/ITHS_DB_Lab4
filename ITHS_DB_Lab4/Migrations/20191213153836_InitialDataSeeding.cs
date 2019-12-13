using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHS_DB_Lab4.Migrations
{
    public partial class InitialDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            using (var db = new ExersiceContext())
            {
                // ADD PERSONS
                var annaAndersson = new Person("Anna Andersson");
                var bennyBengtsson = new Person("Benny Bengtsson");
                var carinCarlsson = new Person("Carin Carlsson");
                db.Person.Add(annaAndersson);
                db.Person.Add(bennyBengtsson);
                db.Person.Add(carinCarlsson);

                // ADD EXERCISES
                var långdistans = new Exercise("Långdistans");
                var intervall = new Exercise("Intervall");
                var teräng = new Exercise("Teräng");
                var crawl = new Exercise("Crawl");
                var bröstsim = new Exercise("Bröstsim");
                db.Exercise.Add(långdistans);
                db.Exercise.Add(intervall);
                db.Exercise.Add(teräng);
                db.Exercise.Add(crawl);
                db.Exercise.Add(bröstsim);

                //ADD GEAR
                var hjälm = new Gear("Hjälm");
                var speedos = new Gear("Speedos");
                var goggels = new Gear("Goggels");
                var cyckel = new Gear("Cyckel");
                var skor = new Gear("Skor");
                db.Gear.Add(hjälm);
                db.Gear.Add(speedos);
                db.Gear.Add(goggels);
                db.Gear.Add(cyckel);
                db.Gear.Add(skor);

                // Save changes to update datbase and entitys
                db.SaveChanges();

                // ADD SESSIONS
                var session_1 = new Running("Löppass", "Genom skogen", 2.34f, annaAndersson.Id);
                db.Session.Add(session_1);

                var session_2 = new Running("Löppass", "Genom stan", 0.30f, annaAndersson.Id);
                db.Session.Add(session_2);

                var session_3 = new Running("Löppass", "På löpband", 0.45f, annaAndersson.Id);
                db.Session.Add(session_3);

                db.Session.Add(new Running("Löppass", "På löpband", 1.54f, annaAndersson.Id));

                var session_4 = new Cycling("Cyckelpass", "Genom skogen", 1.43f, bennyBengtsson.Id);
                db.Session.Add(session_4);

                db.Session.Add(new Cycling("Cyckelpass", "Genom stan", 1.23f, bennyBengtsson.Id));

                db.Session.Add(new Cycling("Cyckelpass", "Över åkern", 2.23f, bennyBengtsson.Id));

                var session_5 = new Swiming("Simmning", "I sjön", 0.45f, carinCarlsson.Id);
                db.Session.Add(session_5);

                var session_6 = new Swiming("Simmning", "I basäng", 0.30f, carinCarlsson.Id);
                db.Session.Add(session_6);

                db.Session.Add(new Swiming("Simmning", "I havet", 1.15f, carinCarlsson.Id));

                // Save changes to update datbase and entitys
                db.SaveChanges();

                // ADD EXERCISES AND GEAR TO SESSIONS
                session_1.SessionExercise.Add(new SessionExercise(session_1.Id, långdistans.Id));
                session_1.SessionGear.Add(new SessionGear(session_1.Id, skor.Id));
                session_1.SessionGear.Add(new SessionGear(session_1.Id, speedos.Id));

                session_2.SessionExercise.Add(new SessionExercise(session_2.Id, intervall.Id));

                session_3.SessionExercise.Add(new SessionExercise(session_3.Id, intervall.Id));

                session_4.SessionExercise.Add(new SessionExercise(session_4.Id, teräng.Id));
                session_4.SessionGear.Add(new SessionGear(session_4.Id, cyckel.Id));

                session_5.SessionExercise.Add(new SessionExercise(session_5.Id, crawl.Id));

                session_6.SessionGear.Add(new SessionGear(session_6.Id, goggels.Id));

                db.SaveChanges();
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
