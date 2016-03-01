using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Task3.Definition;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            section.Configure(container);
            var trip= container.Resolve<ITrip>();
            List<IMove> move = new List<IMove>();
            move.Add(new Task3.Object.Airplane(1, "Airplane"));
            move.Add(new Task3.Object.helicopter(1, "helicopter"));
            foreach (var item in move)
            {
                item.TakeOf();
                item.Land();
                trip.DestinationJourney(item, 2000);
                Console.WriteLine("the flights took {0}", trip.Time);
                trip = container.Resolve<ITrip>();
            }  
           
        }
    }
}
