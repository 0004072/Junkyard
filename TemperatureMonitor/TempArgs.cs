using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureMonitor
{
    class TempArgs : EventArgs
    {
        private float deltaT;

        public float DeltaT
        {
            get
            {
                return deltaT;
            }
        }

        public TempArgs(float deltaT)
        {
            this.deltaT = deltaT;
        }
    }
}
