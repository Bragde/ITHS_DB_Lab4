using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4
{
    class Running : Session
    {
        public Running()
        {
            this.Exercises = new List<Exercise>();
        }
        public Running(List<Exercise> exercises)
        {
            this.Exercises = exercises;
        }
        public override List<Exercise> Exercises { get; set; }
        public override List<Gear> Gear { get; set; }
    }
}
