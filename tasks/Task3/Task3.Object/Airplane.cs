using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Object
{
    public class Airplane : FlyingMachine
    {
        public Airplane(int length, string name) :base(length, name)
        {
            Speed = 1000;
        }
    
        public Airplane()
        {
            Speed = 1000;
        }
        public override int Speed { get; set; }        
    }
}
