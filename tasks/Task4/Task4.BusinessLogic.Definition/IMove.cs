﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.BusinessLogic.Definition
{
    public interface IMove
    {
        void TakeOf();
        void Land();
        int Speed { get; set; }
    }
}
