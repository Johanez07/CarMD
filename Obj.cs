using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarMD
{
    internal class Obj
    {
        public int id;
        public string name;

        public int x;
        public int y;

        private int screenX;
        private int screenY;

        string[] txt = {
            "|\\---/|",
            "| o_o |",
            " \\_^_/"
        };



        public Obj(char[,] pixels, int screenX, int screenY, int id, string name, int x, int y)
        {
            this.id = id;
            this.name = name;
            this.x = x;
            this.y = y;
            this.screenX = screenX;
            this.screenY = screenY;

            SetPixels(pixels, this.x, this.y, true);
        }

        public void Move(char[,] pixels, int x, int y)
        {
            SetPixels(pixels, this.x, this.y, false);

            this.x += x;
            this.y += y;

            SetPixels(pixels, this.x, this.y, true);
        }

        private void SetPixels(char[,] pixels, int x, int y, bool set)
        {
            for (int txtY = 0; txtY < txt.Length; txtY++)
            {
                for (int txtX = 0; txtX < txt[txtY].Length; txtX++)
                {
                    int pixelsX = this.x + txtX;
                    int pixelsY = this.y + txtY;

                    bool check1 = (pixelsX < screenX) && (pixelsX >= 0);
                    bool check2 = (pixelsY < screenY) && (pixelsY >= 0);

                    if (check1 && check2)
                    {
                        char sign = '\0';

                        if (set) sign = txt[txtY][txtX];

                        pixels[this.x + txtX, this.y + txtY] = sign;
                    }
                }
            }
        }
    }
}
