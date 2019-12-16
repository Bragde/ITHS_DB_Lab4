using System.Collections.Generic;

namespace ITHS_DB_Lab4_DbModel
{
    public class Exercise
    {
        public Exercise(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public List<SessionExercise> SessionExercise { get; set; }
    }
}