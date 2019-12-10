using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4
{
    class Running : Session
    {
        public override List<Exercise> Exercises { get; set; }
        public override List<Gear> Gear { get; set; }
    }
}
