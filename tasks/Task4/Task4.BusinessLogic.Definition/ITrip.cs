using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.BusinessLogic.Definition
{
    public interface ITrip
    {
        bool DestinationJourney(IMove move, int distance);
        int Time { get; set; }
        void SaveVehicle<TVehicle>(TVehicle value);
        TVehicle GetVehicle<TVehicle>(TVehicle value);
    }
}
