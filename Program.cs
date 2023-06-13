using CarMD;
using System.Runtime.ConstrainedExecution;
using System.Windows.Input;
using System.Threading;
using static Program;


internal class Program
{
    //public char[,] pixels = new char[60, 5];

    private static void Main(string[] args)
    {
        int screenX = 50;
        int screenY = 15;

        char[,] pixels = new char[screenX, screenY];


        Obj obj = new Obj(pixels, screenX, screenY, 0, "cat", 1, 1);


        //Car myCar = new Car();
        DisplayCar screen = new DisplayCar(screenX, screenY);

        while(true)
        {
            Console.Clear();
            Console.WriteLine("CarMD v. 0.2 - 13/06/2023");
            Console.WriteLine("Screen Size: " + screenX + ", " + screenY);
            Console.WriteLine("TestObj: " +obj.x+", "+obj.y+"   " + obj.name);
            screen.ShowScreen(pixels);


            System.ConsoleKey userInput = Console.ReadKey(true).Key;

            switch (userInput)
            {
                case ConsoleKey.UpArrow: obj.Move(pixels, 0, -1); break;
                case ConsoleKey.DownArrow: obj.Move(pixels, 0, 1); break;
                case ConsoleKey.LeftArrow: obj.Move(pixels, -1, 0); break;
                case ConsoleKey.RightArrow: obj.Move(pixels, 1, 0); break;
                case ConsoleKey.E: break;
            }


        }






        /*while(true) {
            Console.Clear();

            screen.Display(myCar);

            System.ConsoleKey userInput = Console.ReadKey(true).Key;

            switch (userInput) {
                case ConsoleKey.UpArrow: myCar.GoUp(); break;
                case ConsoleKey.DownArrow: myCar.GoDown(); break;
                case ConsoleKey.LeftArrow: myCar.GoLeft(); break;
                case ConsoleKey.RightArrow: myCar.GoRight(); break;
                case ConsoleKey.R: myCar.RunEngine(); break;
                case ConsoleKey.E: break;
            }
        }*/

    }
}
