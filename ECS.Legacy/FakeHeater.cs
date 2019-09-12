using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy
{
    class FakeHeater : IHeater
    {
        private bool turnOn_;

        public void TurnOn()
        {
            turnOn_ = true;
        }
        

        public void TurnOff()
        {
            turnOn_ = false;
        }

        public bool RunSelfTest()
        {
            return turnOn_;
        }
    }
}
