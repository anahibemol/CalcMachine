namespace CalcMachine
{
        public static class Trigonometric
        {
            public static void Open()
            {

                Console.WriteLine(@"
                Write the following commands for what the object is:

                |1 or IDS     - Gets the Sin, Cos, Tg, Sec, Cossec and Ctg.
                |2 or BACK    - Goes Back to Main Menu.
                |__________________________________________________________");
                string? Switch = Console.ReadLine() ?? "0";
                Switch = Switch.ToUpper();

                switch(Switch)
                {
                case "IDS" or "1":
                    Ids();
                break;

                case "BACK" or "2":
                    Programa.MainMenu();
                break;               
                }
            
                if (Switch is not "BACK") { Trigonometric.Open(); }

            }

            public static void Ids()
            {
                Console.WriteLine("Write your angle (in degrees)");
                double angle = Convert.ToDouble(Console.ReadLine());
                double radian = (angle * (Math.PI)) / 180; //converts the degrees to radians
                Programa.E.ClearLine(2, 0);
                Console.WriteLine($"{angle}° in radians is: {radian}");

                Console.WriteLine($"The Sine of {angle}° is {Math.Sin(radian)}");
                Console.WriteLine($"The Cosine of {angle}° is {Math.Cos(radian)}");
                Console.WriteLine($"The Tangent of {angle}° is {Math.Tan(radian)}");
                Console.WriteLine($"The Cosecant of {angle}° is {1/(Math.Sin(radian))}");
                Console.WriteLine($"The Secant of {angle}° is {1/(Math.Cos(radian))}");
                Console.WriteLine($"The Cotangent of {angle}° is {1/(Math.Tan(radian))}");                
            }
        }

}