﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy
{
    public interface ITempSensor
    {
        void SetTemp(int temp);

        int GetTemp();

        bool RunSelfTest();
    }
}
