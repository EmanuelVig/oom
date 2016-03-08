using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Storage.Definition;

namespace Task4.Storage.Implementation
{
    public class FileStorage : IStorageAccess<string>
    {        
        private readonly string _filePath;
        public FileStorage(string filePath)
        {
            _filePath = filePath;
        }
        public FileStorage()
        {
            _filePath = ConfigurationManager.AppSettings["storagePath"];
        }

        public string SelectAll()
        {
            return File.ReadAllText(_filePath);
        }

        public int StoreValue(string value)
        {
            try
            {
                File.WriteAllText(_filePath,value);
            }
            catch (Exception ex)
            {
                return 0;
            }
            return 1;
        }
    }
}
