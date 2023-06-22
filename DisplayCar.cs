using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace CarMD
{
    internal class DisplayCar
    {
        int screenX;
        int screenY;

        public DisplayCar(int x, int y)
        {
            screenX = x;
            screenY = y;
        }

        public void ShowScreen(char[,] pixels)
        {
            for(int prePosY = 0; prePosY < (screenY+2); prePosY++)
            {
                for (int prePosX = 0; prePosX < (screenX+2); prePosX++)
                {
                    int posX = prePosX - 1;
                    int posY = prePosY - 1;

                    if (prePosY == 0) Console.Write("-");
                    else if (prePosY == screenY+1) Console.Write("-");
                    else if (prePosX == 0) Console.Write("|");
                    else if (prePosX == screenX+1) Console.Write("|");
                    else if(pixels[posX, posY]!='\0') Console.Write(pixels[posX, posY]);
                    else Console.Write(" ");


                }

                Console.WriteLine();
            }
        }
    }
}
