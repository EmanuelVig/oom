using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Serialization.Defintion
{
    public interface IJsonSerialization
    {
        TObject GetObject<TObject>();
        bool SaveObject<TObject>(TObject value);              
    }
}
