﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4
{
    class Cycling : Session
    {
        public Cycling(string name, string description, float time, int personId) 
            : base(name, description, time, personId){}

        public override List<SessionExercise> SessionExercise { get; set; }
        public override List<SessionGear> SessionGear { get; set; }
    }
}
