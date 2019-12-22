using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4_DbModel.Models
{
    public class SessionExercise
    {
        public SessionExercise(int sessionId, int exerciseId)
        {
            SessionId = sessionId;
            ExerciseId = exerciseId;
        }

        public int Id { get; set; }
        public int? Repetitions { get; set; }
        public int? PainLevel { get; set; }

        public int SessionId { get; set; }
        public Session Session { get; set; }

        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
    }
}
