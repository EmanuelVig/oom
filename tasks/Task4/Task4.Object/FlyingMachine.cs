using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.BusinessLogic.Definition;

namespace Task4.Object
{
    public abstract class FlyingMachine : IMove
    {
        public FlyingMachine()
        {
        }
        public FlyingMachine(int length, string name)
        {
            Length = length;
            Name = name;
        }
        public int Maxheight { get; set; }
        public int MaxFuel { get; set; }
        public int MaxPassagers { get; set; }

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
