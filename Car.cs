﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Car : Vehicle
    {
        private bool engineIsRunning = false;
        public Car() : base ("Car")
        {
            
        }

        public void StartEngine()
        { this.engineIsRunning = true; }

        public void StopEngine()
        { this.engineIsRunning = false; }
    }
}
