using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4_DbModel.Models
{
    public class SessionGear
    {
        public SessionGear(int sessionId, int gearId)
        {
            SessionId = sessionId;
            GearId = gearId;
        }

        public int SessionId { get; set; }
        public Session Session { get; set; }

        public int GearId { get; set; }
        public Gear Gear { get; set; }
    }
}
