using System.Collections.Generic;

namespace ITHS_DB_Lab4_DbModel.Models
{
    public class Gear
    {
        public Gear(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public List<SessionGear> SessionGear { get; set; }
    }
}