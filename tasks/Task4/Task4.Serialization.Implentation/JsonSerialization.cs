using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Serialization.Defintion;
using Task4.Storage.Definition;

namespace Task4.Serialization.Implentation
{
    public class JsonSerialization: IJsonSerialization
    {
        private readonly IStorageAccess<string> _storage;
        public JsonSerialization(IStorageAccess<string> storage)
        {
            _storage = storage;
        }

        public TObject GetObject<TObject>()
        {
           return JsonConvert.DeserializeObject<TObject>(_storage.SelectAll());
        }

        public bool SaveObject<TObject>(TObject value)
        {
            try
            {
                _storage.StoreValue(JsonConvert.SerializeObject(value));
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
