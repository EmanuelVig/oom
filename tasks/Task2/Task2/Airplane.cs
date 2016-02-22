using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Airplane: IMove
    {
        public Airplane(int length, string name)
        {
            Length = length;
            Name = name;
        }
        public int Length { get; set; }
        public string Name { get; set; }
        private bool inFlyMode = false;

        public bool GetFlyStatus()
        {
            return this.inFlyMode;
        }

        public void TakeOf()
        {
            inFlyMode = true;
        }

        public void land()
        {
            inFlyMode = false;
        }
    }
    
    public interface IMove
    {
        void TakeOf();
        void land();
    }  
}
