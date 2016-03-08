using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.BusinessLogic.Definition;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            section.Configure(container);
            var trip = container.Resolve<ITrip>();
            List<IMove> move = new List<IMove>();
            move.Add(new Object.Airplane(1, "Airplane"));
            move.Add(new Object.helicopter(1, "helicopter"));
            foreach (var item in move)
            {
                item.TakeOf();
                item.Land();
                trip.DestinationJourney(item, 2000);
                Console.WriteLine("the flights took {0}", trip.Time);
                trip = container.Resolve<ITrip>();
                trip.SaveVehicle<IMove>(item);
            }
        }
    }
}
