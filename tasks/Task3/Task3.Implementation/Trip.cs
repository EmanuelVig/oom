using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Definition;

namespace Task3.Implementation
{
    public class Trip : ITrip
    {
        public int Time { get; set; }

        public bool DestinationJourney(IMove move,int distance)
        {
            move.TakeOf();
            move.Land();
            Time = distance / move.Speed;
            return true;
        }
    }
}
