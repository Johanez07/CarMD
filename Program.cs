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
        int screenX = 75;
        int screenY = 15;

        char[,] pixels = new char[screenX, screenY];
        char[,] colPixels = new char[screenX, screenY];

        string[] objTxt = {
            "|\\---/|",
            "| o_o |",
            " \\_^_/"
        };

        Obj obj = new Obj(pixels, screenX, screenY, 0, "cat", 1, 1, true, objTxt);

        string[] objTxt2 = {
            "^..^      /",
            "/_/\\_____/",
            "   /\\   /\\",
            "  /  \\ /  \\"
        };

        Obj obj2 = new Obj(pixels, screenX, screenY, 0, "dog", 5, 5, true, objTxt2);


        DisplayCar screen = new DisplayCar(screenX, screenY);

        while(true)
        {
            Console.WriteLine("CarMD v. 0.2 - 13/06/2023");
            Console.WriteLine("Screen Size: " + screenX + ", " + screenY);
            Console.WriteLine("TestObj: " + obj.x + ", " + obj.y + "   " + obj.name + " isOnScreen: " + obj.isOnScreenBool + " test: "+ obj.testString);
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
            Console.Clear();
        }

    }
}
