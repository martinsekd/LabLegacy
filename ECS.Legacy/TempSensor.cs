using System;

namespace ECS.Legacy
{
    internal class TempSensor : ITempSensor
    {
        private Random gen = new Random();

        public void SetTemp(int temp)
        {
            
        }

        public int GetTemp()
        {
            return gen.Next(-5, 45);
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}