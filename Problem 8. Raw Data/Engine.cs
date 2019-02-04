using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_8._Raw_Data
{
    public class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }

        public Engine()
        {

        }
        public  Engine(int engineSpeed, int enginePower):this()
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }
    }
}
