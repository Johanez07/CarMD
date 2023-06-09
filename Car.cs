using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMD
{
    internal class Car
    {
        private int posX = 0;
        private int posY = 0;
        private string carProject = "[o{}{}o]";

        public Car() { }

        public int GetPosX() { return this.posX; }
        public int GetPosY() { return this.posY; }
        public string GetCarProject()
        {
            return this.carProject;
        }

        public void GoLeft()
        {
            this.posX--;
        }

        public void GoRight()
        {
            this.posX++;
        }

        public void GoUp()
        {
            this.posY--;
        }

        public void GoDown()
        {
            this.posY++;
        }

    }
}
