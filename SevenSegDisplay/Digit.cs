using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenSegDisplay
{
    public enum Digits {
        ONE = 1,
        TWO = 2,
        THREE = 3,
        FOUR = 4,
        FIVE = 5,
        SIX = 6,
        SEVEN = 7,
        EIGHT = 8,
        NINE = 9,
        ZERO = 0
    }

    class Digit
    {
        private Segment[] segments;
        private Digits value;

        public Digits Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public Digit(Digits v, Segment[] segs) {
            this.Value = v;
            this.segments = segs;
        }
    }
}
