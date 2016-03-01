using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Definition;
using Task3.Implementation;

namespace Task3.Infrastucutr
{
    public class UnityRegistration : UnityContainerExtension
    {
        protected override void Initialize()
        {
            this.Container.RegisterType<ITrip, Trip>();
        }
    }
}
