using CarMD;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Car myCar = new Car();

        void ShowScreen(int posX, int posY, string car)
        {
            string lineX = "";

            for(int y = 0; y < posY; y++)
            {
                Console.WriteLine();
            }

            for(int x = 0; x < posX; x++)
            {
                lineX = lineX + " ";
            }

            Console.WriteLine(lineX + car);
        }

        while(true) {
            Console.Clear();

            ShowScreen(myCar.GetPosX(), myCar.GetPosY(), myCar.GetCarProject());

            string key = Console.ReadLine();

            switch (key) {
                case "1": myCar.GoUp(); break;
                case "2": myCar.GoDown(); break;
                case "3": myCar.GoLeft(); break;
                case "4": myCar.GoRight(); break;
                case "0": break;
            }
        }
    }
}