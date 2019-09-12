using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy
{
    class FakeTempSensor : ITempSensor
    {
        public int _fakeTemp;

        public int GetTemp()
        {
            return 3;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
