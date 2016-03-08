using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.BusinessLogic.Definition;
using Task4.BusinessLogic.Implementation;
using Task4.Serialization.Defintion;
using Task4.Serialization.Implentation;
using Task4.Storage.Definition;
using Task4.Storage.Implementation;

namespace Task4.Infostructure
{
    public class UnityRegistration : UnityContainerExtension
    {
        protected override void Initialize()
        {
            this.Container.RegisterType(typeof(IStorageAccess<>), typeof(FileStorage), new InjectionConstructor());
            this.Container.RegisterType<IJsonSerialization, JsonSerialization>();
            this.Container.RegisterType<ITrip, Trip>();            
        }
    }
}
