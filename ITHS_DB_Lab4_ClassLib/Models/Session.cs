using System.Collections.Generic;

namespace ITHS_DB_Lab4_DbModel.Models
{
    public class Session
    {
        //protected Session()
        //{
        //    SessionExercise = new List<SessionExercise>();
        //    SessionGear = new List<SessionGear>();
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Time { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }

        public virtual List<SessionExercise> SessionExercise { get; set; }
        public virtual List<SessionGear> SessionGear { get; set; }

        public override string ToString()
        {
            return $@"{this.Name} {this.Description} {this.Time}";
        }
    }
}