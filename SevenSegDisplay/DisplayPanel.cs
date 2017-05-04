using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenSegDisplay
{
    class DisplayPanel
    {
        private Pixel[][] panel;
        private int width, height, margin, charSpace;

        public DisplayPanel(int width, int height, int margin, int charSpace) {
            this.Width = width;
            this.Height = height;
            this.Margin = margin;
            this.CharSpace = charSpace;
            this.panel = new Pixel[height][];
            for (int i = 0; i < panel.Length; i++) {
                this.panel[i] = new Pixel[width];
                for (int j = 0; j < panel[i].Length; j++)
                    panel[i][j] = new Pixel(i, j, ' ');
            }
        }

        public int CharSpace
        {
            get
            {
                return charSpace;
            }

            set
            {
                charSpace = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public int Margin
        {
            get
            {
                return margin;
            }

            set
            {
                margin = value;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public void display() {
            foreach (Pixel[] row in this.panel) {
                foreach (Pixel p in row) {
                    Console.Write(p.Character);
                }
                Console.WriteLine();
            }
        }

        public void putChar(Character ch) {
            foreach()
        }
    }
}
