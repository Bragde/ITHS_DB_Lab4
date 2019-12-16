using System.Collections.Generic;

namespace ITHS_DB_Lab4_DbModel
{
    public abstract class Session
    {
        protected Session(string name, string description, float time, int personId)
        {
            Name = name;
            Description = description;
            Time = time;
            PersonId = personId;

            SessionExercise = new List<SessionExercise>();
            SessionGear = new List<SessionGear>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Time { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }

        public abstract List<SessionExercise> SessionExercise { get; set; }
        public abstract List<SessionGear> SessionGear { get; set; }

        public override string ToString()
        {
            return $@"{this.Name} {this.Description} {this.Time}";
        }
    }
}