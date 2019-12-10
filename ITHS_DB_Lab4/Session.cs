using System.Collections.Generic;

namespace ITHS_DB_Lab4
{
    abstract class Session
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Time { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }

        public abstract List<Exercise> Exercises { get; set; }
        public abstract List<Gear> Gear { get; set; }
    }
}