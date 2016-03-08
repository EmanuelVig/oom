using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Object
{
    public class helicopter : FlyingMachine
    {
        public helicopter(int length, string name) : base(length, name)
        {
            Speed = 200;
        }

        public helicopter()
        {
            Speed = 200;
        }
        public override int Speed { get; set; }
    }
}
