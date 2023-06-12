using CarMD;
using System.Runtime.ConstrainedExecution;
using System.Windows.Input;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Car myCar = new Car();
        DisplayCar screen = new DisplayCar();

        while(true) {
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
        }

    }
}