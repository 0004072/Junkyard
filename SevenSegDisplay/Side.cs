using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenSegDisplay
{
    public enum Axis
    {
        H, V
    }

    class Side
    {
        private Sides sideName;
        private int offsetH, offsetV;

        public Side(Sides name, int oh, int ov) {
            this.sideName = name;
            this.offsetH = oh;
            this.offsetV = ov;
        }
    }
}
