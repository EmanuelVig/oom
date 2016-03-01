using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Definition
{
    public interface ITrip
    {
        bool DestinationJourney(IMove move, int distance);
        int Time { get; set; }
    }
}
