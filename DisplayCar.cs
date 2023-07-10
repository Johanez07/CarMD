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
            StringBuilder screenBuffer = new StringBuilder();

            for(int prePosY = 0; prePosY < (screenY+2); prePosY++)
            {
                for (int prePosX = 0; prePosX < (screenX+2); prePosX++)
                {
                    int posX = prePosX - 1;
                    int posY = prePosY - 1;

                    if (prePosY == 0) screenBuffer.Append("-");
                    else if (prePosY == screenY+1) screenBuffer.Append("-");
                    else if (prePosX == 0) screenBuffer.Append("|");
                    else if (prePosX == screenX+1) screenBuffer.Append("|");
                    else if(pixels[posX, posY]!='\0') screenBuffer.Append(pixels[posX, posY]);
                    else screenBuffer.Append(" ");


                }
                screenBuffer.AppendLine();
            }

            Console.Write(screenBuffer.ToString());
        }
    }
}
