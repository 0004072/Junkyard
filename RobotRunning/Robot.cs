using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;

namespace RobotRunning
{
    class Robot
    {

        [DllImport("User32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("User32.dll")]
        public static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);

        private byte life, strength;
        private Random random = new Random();
        private Bitmap bulletHole = new Bitmap("bullethole.png");
        public byte Life
        {
            get
            {
                return life;
            }

            set
            {
                life = value;
            }
        }

        public byte Strength
        {
            get
            {
                return strength;
            }

            set
            {
                strength = value;
            }
        }

        public void shoot() {
            while (true) {
                if (this.life <= 0) {
                    this.life = 0;
                    Console.WriteLine("Robot is dead!");
                    return;
                }

                if (this.strength >= 50) {
                    Console.Write("Shoot?(y/n)");
                    bool toShoot = Console.ReadLine().ToLower().Equals("y");
                    if (!toShoot)
                        continue;
                    for (int i = 1; i <= 50; i++) {
                        this.mimicShooting();
                        this.strength -= 1;
                        Thread.Sleep(200);
                    }
                    this.life -= 5;
                }

                if (this.strength < 50) {
                    while (true) {
                        Console.Write("Give me strength (0 - 50) :");
                        string input = Console.ReadLine();
                        if (Regex.IsMatch(input, @"^[\d]{1,2}$")) {
                            byte dose = byte.Parse(input);
                            if (dose <= 50)
                            {
                                this.strength += dose;
                                break;
                            }
                        }
                        Console.WriteLine("Invalid Dose! Retry!");
                    }
                }
            }
        }

        private void mimicShooting() {
            Console.WriteLine("Shoot!");
            IntPtr desktopPtr = GetDC(IntPtr.Zero);
            Graphics g = Graphics.FromHdc(desktopPtr);

            //Pen p = new Pen(Color.White);
            int x = random.Next(0, 1000);
            int y = random.Next(10, 1000);
            g.DrawImage(bulletHole, x, y);
            //g.DrawRectangle(p, new Rectangle(x, y, 100, 100));

            //Console.ReadKey();

            g.Dispose();
            ReleaseDC(IntPtr.Zero, desktopPtr);
        }
    }
}
