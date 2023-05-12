﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Exceptions
{
    public class InvalidWeaponException : Exception
    {
        public InvalidWeaponException()
        {
            Console.WriteLine("This weapon is not valid for this hero");
        }
    }
}
