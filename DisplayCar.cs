using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarMD
{
    internal class DisplayCar
    {
        public DisplayCar() { }

        public void Display(Car car)
        {
            int posX = car.GetPosX();
            int posY = car.GetPosY();

            bool engineStatus = car.GetEngineStatus();

            string[] carDisplay = car.GetCarProject();


            Console.WriteLine("CarMD v. 0.1 - 09/06/2023");
            Console.WriteLine("Car Engine: " + engineStatus);


            string lineX = "";

            for (int y = 0; y < posY; y++)
            {
                Console.WriteLine();
            }

            for (int x = 0; x < posX; x++)
            {
                lineX = lineX + " ";
            }

            for (int i = 0; i < carDisplay.Length; i++)
            {
                Console.WriteLine(lineX + carDisplay[i]);
            }
        }
    }
}
