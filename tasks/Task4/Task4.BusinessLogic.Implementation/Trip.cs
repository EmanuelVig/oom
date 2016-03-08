using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.BusinessLogic.Definition;
using Task4.Serialization.Defintion;

namespace Task4.BusinessLogic.Implementation
{
    public class Trip : ITrip
    {
        private readonly IJsonSerialization _jsonSerialization;
        public Trip(IJsonSerialization jsonSerialization)
        {
            _jsonSerialization = jsonSerialization;
        }

        public int Time { get; set; }

        public bool DestinationJourney(IMove move, int distance)
        {
            move.TakeOf();
            move.Land();
            Time = distance / move.Speed;
            return true;
        }

        public void SaveVehicle<TVehicle>(TVehicle value)
        {
            _jsonSerialization.SaveObject<TVehicle>(value);
        }

        public TVehicle GetVehicle<TVehicle>(TVehicle value)
        {
          return _jsonSerialization.GetObject<TVehicle>();
        }
    }
}
