using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4_DbModel.Models
{
    public class Cycling : Session
    {
        public Cycling() : base(){}

        public override List<SessionExercise> SessionExercise { get; set; }
        public override List<SessionGear> SessionGear { get; set; }
    }
}
