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
        //private ITempSensor tempSensor;

        public FakeHeater()
        {
            //tempSensor = sensor;
        }

        public void TurnOn()
        {
            //tempSensor.SetTemp(tempSensor.GetTemp()+1);
            turnOn_ = true;
        }
        

        public void TurnOff()
        {
            //tempSensor.SetTemp(tempSensor.GetTemp() - 1);
            turnOn_ = false;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
