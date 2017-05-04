using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenSegDisplay
{
    class Pixel
    {
        private int h, v;
        private char character;

        public int H
        {
            get
            {
                return h;
            }

            set
            {
                h = value;
            }
        }

        public int V
        {
            get
            {
                return v;
            }

            set
            {
                v = value;
            }
        }

        public char Character
        {
            get
            {
                return character;
            }

            set
            {
                character = value;
            }
        }

        public Pixel(int h, int v, char c) {
            this.H = h;
            this.V = v;
            this.Character = c;
        }
    }
}
