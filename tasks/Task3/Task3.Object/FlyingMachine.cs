using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Definition;

namespace Task3.Object
{
    public abstract class FlyingMachine:IMove
    {
        public FlyingMachine()
        {
        }
        public FlyingMachine(int length, string name)
        {
            Length = length;
            Name = name;
        }
        public int Length { get; set; }
        public string Name { get; set; }
        private bool inFlyMode = false;
        public abstract int Speed { get; set; }

        public bool GetFlyStatus()
        {
            return this.inFlyMode;
        }

        public void TakeOf()
        {
            inFlyMode = true;
        }

        public void Land()
        {
            inFlyMode = false;
        }      
    }
}
