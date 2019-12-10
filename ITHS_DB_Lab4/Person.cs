using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Session> Sessions { get; set; }
    }
}
