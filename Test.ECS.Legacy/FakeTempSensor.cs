using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy
{
    public class FakeTempSensor : ITempSensor
    {
        public int _fakeTemp;

        public FakeTempSensor(int fakeTemp=0)
        {
            _fakeTemp = fakeTemp;
        }

        public void SetTemp(int temp)
        {
            _fakeTemp = temp;
        }

        public int GetTemp()
        {
            return _fakeTemp;
        }

        public bool RunSelfTest()
        {
            return true;
        }

    }
}
