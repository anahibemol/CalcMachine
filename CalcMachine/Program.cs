using System;
using Microsoft.VisualBasic;

namespace CalcMachine
{

    public static class Programa
    {
 

        public static void Log()
        {
            Console.WriteLine("Your log will be saved into CalcMachine/log.txt");
            string filePath = Directory.GetCurrentDirectory();

            FileStream filestream = new FileStream("log.txt", FileMode.Create);
            var streamwriter = new StreamWriter(filestream);
            streamwriter.AutoFlush = true;
            Console.SetOut(streamwriter);
            Console.SetError(streamwriter);
        }
        public static void MainMenu()
            {
            bool whiler = true;
            while (whiler is true)
            {        
            
                Console.WriteLine(@"
                Write the following commands for what you want to do:

                |1 or BASIC    - Go to the Basic Arithmetic Calculator.
                |2 or TRIG     - Go to the Trigonometric Function Calculator.
                |3 or GEO      - Go to the Geometry/Polygon Calculator.
                |4 or FUNC     - Go to the Function Calculator.
                |5 or STATS    - Go to the Statistic Calculator.
                |6 or CONVERT  - Go to the Conversion Calculator.
                |7 or OTHER    - Go to other Calculators.
                |8 or LOG      - Writes all the calculations into a file.
                |9 or EXIT     - Exits the Program.
                |_______________________________________________________");
                string OpeningMenu = Console.ReadLine() ?? "1";

                OpeningMenu = OpeningMenu.ToUpper(); //Case insensitiviness

                switch (OpeningMenu)
                {

                    case "BASIC" or "1":
                    Basic.Open();
                    break;
  
                    case "TRIG" or "2":
                    Trigonometric.Open();
                    break;

                    case "GEO" or "3":
                    Geometric.Open();
                    break;

                    case "FUNC" or "4":
                    Function.Open();
                    break;

                    case "STATS" or "5":
                    Statitics.Open();
                    break;

                    case "CONVERT" or "6":
                    Conversion.Open();
                    break;

                    case "OTHER" or "7":
                    Other.Prime();
                    break;

                    case "LOG" or "8":
                    Log();
                    break;

                    case "EXIT" or "9":
                    whiler = false;
                    break;
                }
            }
            }

        public static void Main(string[] args)
        {
            Console.WriteLine(@"
  
           /|    __     _           __               _      __         _  __     _____  |                   /     _/
          | |   /     /   \  |     /    \     /|   /   \   /    |   |  |  |\   | |      |                  /    _/
          | |  |     |     | |    |     |\   / |  |     | |     |___|  |  | \  | |__    |                 /   _/
          | |  |     |_____| |    |     | \_/  |  |_____| |     |   |  |  |  \ | |      |                /  _/
          | |   \__  |     | |___  \__  |      |  |     |  \__  |   |  |  |   \| |____  | v. Beta 2.3.0 / _/
         /  |_________________________________________________________________________|______________/_/
            ");
            Programa.MainMenu();
        }
  
        public static class E //Class for extra functions
        {
            public static double ToRad(double x) //Converts the angle value to Radian
            {                
                x = ( (x *(Math.PI) ) / 180 );

                return x;
            }
        
            public static double Inv(double x, double y) //Inverts the value
            {
                if (y == 0) { y = 1; } //standard value

                if (x != 0) { x = y/x; } //preventing divide by 0 crashes
                return x;
            }

            public static void ClearLine(int pedro, int joao)
            {
                Console.SetCursorPosition(0, Console.CursorTop - pedro);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop - joao);
            }                    
        }
  }
}

