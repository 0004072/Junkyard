using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenSegDisplay
{
    class Character
    {
        private Digit digit;
        private int initPoint;

        internal Digit Value
        {
            get
            {
                return digit;
            }

            set
            {
                this.digit = value;
            }
        }

        public int InitPoint
        {
            get
            {
                return initPoint;
            }

            set
            {
                initPoint = value;
            }
        }

        public Character(Digit d, int i) {
            this.digit = d;
            this.initPoint = i;
        }
    }
}
