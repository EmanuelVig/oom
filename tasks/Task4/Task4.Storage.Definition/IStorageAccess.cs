using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Storage.Definition
{
    public interface IStorageAccess<TObject>
    {
        TObject SelectAll();
        int StoreValue(TObject value);   
    }
}
