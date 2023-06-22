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

        bool collision = false;

        public bool isOnScreenBool = true;
        public string testString = "";

        string[] txt = {"[txt]"};



        public Obj(char[,] pixels, int screenX, int screenY, int id, string name, int x, int y)
        {
            conObj(pixels, screenX, screenY, id, name, x, y);
        }

        public Obj(char[,] pixels, int screenX, int screenY, int id, string name, int x, int y, bool col)
        {
            collision = true;
            conObj(pixels, screenX, screenY, id, name, x, y);
        }

        public Obj(char[,] pixels, int screenX, int screenY, int id, string name, int x, int y, bool col, string[] txt)
        {
            collision = true;
            SetTxt(txt);
            conObj(pixels, screenX, screenY, id, name, x, y);
        }


        private void conObj(char[,] pixels, int screenX, int screenY, int id, string name, int x, int y)
        {
            this.id = id;
            this.name = name;
            this.x = x;
            this.y = y;
            this.screenX = screenX;
            this.screenY = screenY;

            SetPixels(pixels, this.x, this.y, true);
        }

        public void SetTxt(string[] txt) { 
            this.txt = txt;
        }

        public void Move(char[,] pixels, int x, int y)
        {
            //if (detectCollision(pixels)) return;

            if (!isStillOnScreen(x, y))
            {
                Console.Beep();
                return;
            }

            SetPixels(pixels, this.x, this.y, false);

            this.x += x;
            this.y += y;

            SetPixels(pixels, this.x, this.y, true);
        }

        /*private bool detectCollision(char[,] pixels) {

            for (int txtY = 0; txtY < (txt.Length+2); txtY++)
            {
                for (int txtX = 0; txtX < txt[txtY].Length; txtX++)
                {
                    int pixelsX = this.x + txtX;
                    int pixelsY = this.y + txtY;

                    pixels[this.x + txtX, this.y + txtY] = '0';
                }

            }

            return true;
        }*/

        private bool isStillOnScreen(int x, int y)
        {
            for (int txtY = 0; txtY < txt.Length; txtY++)
            {
                int tempX = this.x + x;
                int firstX = tempX-1;
                int lastX = tempX+(txt[txtY].Length);

                int tempY = this.y + y;
                int firstY = tempY - 1;
                int lastY = tempY + (txt.Length);
                testString = ("1y: " + firstY.ToString() + " 2y: " + lastY.ToString());

                bool check1 = (firstX < -1) || (lastX > screenX);
                bool check2 = (firstY < -1) || (lastY > screenY);
                //bool check2 = (pixelsY < screenY) && (pixelsY > 0);

                if (check1||check2)
                {
                    this.isOnScreenBool = false;
                    return false;
                }
            }

            this.isOnScreenBool = true;
            return true;
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
