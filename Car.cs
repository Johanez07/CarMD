using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMD
{
    internal class Car
    {
        private bool _engineStatus = false;

        private int _posX = 0;
        private int _posY = 0;
        private string[] _carProject = { "  ______", " /|_||_\\`.__", "(   _    _ _\\", "=`-(_)--(_)-'"};

        public Car() { }

        public bool GetEngineStatus() { return this._engineStatus; }
        public int GetPosX() { return this._posX; }
        public int GetPosY() { return this._posY; }
        public string[] GetCarProject()
        {
            return this._carProject;
        }

        public void GoLeft()
        {
            this._posX--;
        }

        public void GoRight()
        {
            this._posX++;
        }

        public void GoUp()
        {
            this._posY--;
        }

        public void GoDown()
        {
            this._posY++;
        }

        public void RunEngine()
        {
            this._engineStatus = true;
            Console.Beep();
        }

    }
}
