using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureMonitor
{
    class Monitor
    {
        private float temp;

        public float Temp
        {
            get
            {
                return temp;
            }
        }

        public Monitor(float temp)
        {
            this.temp = temp;
        }

        public float changeTemp(float deltaT) {
            this.temp += deltaT;
            TempArgs t = new TempArgs(deltaT);
            TemperatureChanged(this, t);
            return this.temp;
        }

        public event ChangeHandler TemperatureChanged;
        public delegate void ChangeHandler(object sender, TempArgs e);
    }
}
