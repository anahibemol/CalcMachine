namespace CalcMachine
{
           public static class Function
        {
            public static void Open()
            {

                Console.WriteLine(@"
                Write the following commands for what the function is:

                |1 or LINEAR     - Function with One Degree.
                |2 or QUAD       - Function with Two Degrees.
                |3 or CUBIC      - Function with Three Degrees.
                |4 or BACK       - Goes Back to Main Menu.
                |___________________________________________________");
                string? Switch = Console.ReadLine() ?? "0";
                if (Switch == "1") { Switch= "LINEAR"; }
                if (Switch == "2") { Switch= "QUAD"; }
                if (Switch == "3") { Switch= "CUBIC"; }
                if (Switch == "4") { Switch= "BACK"; }
                Switch = Switch.ToUpper();

                switch(Switch)
                {
                case "LINEAR":
                    Process(1);
                break;
                case "QUAD":
                    Process(2);
                break;
                case "CUBIC":
                    Process(3);
                break;
                case "BACK":
                    Programa.MainMenu();
                break;               
                }
            
                if (Switch is not "BACK") { Function.Open(); }

            }

            public static void Process(int degree)
            {
                double a = 0; double b = 0; double c = 0; double d = 0; double x = 0; double fx = 0;
                Console.WriteLine("Which exponent/degree is the highest on your function ? (3 / 2 / 1)");
                string Switch = Convert.ToString(degree);
                
                switch (Switch)
                {
                case "3":      
                Console.WriteLine("Your function is on the format: f(x) = ax³ + bx² + cx + d");
                Console.WriteLine("Input, respectivelly, the values of a, b, c and d");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                d = Convert.ToDouble(Console.ReadLine());

                XorY();
                void Cubic()
                {
                if (fx==0)
                {
                fx = a*(x*x*x) + b*(x*x) + c*(x) + d;
                Console.WriteLine($"the function f(x) = {a}x³ + {b}x² + {c}x + {d} at f({x})is: {fx}");
                }
                if (x==0)
                {
                x = 0;
                Console.WriteLine($"To be added");  
                }

                }
                Cubic();
                break;

                case "2":
                Console.WriteLine("Your function is on the format: f(x) = aX² + bX + c");
                Console.WriteLine("Input, respectivelly, the values of a, b and c");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());

                XorY();
                void Quadratic()
                {
                if (fx==0)
                {
                    fx = a*(x*x) + b*(x) + c;
                    Console.WriteLine($"the function f(x) = {a}x² + {b}x + {c} at f({x})is: {fx}");
                }
                if (x==0)
                {
                    double Δ  = (b*b)-(4*a*c);
                    double X1 = (-b + Δ)/(2*a);
                    double X2 = (-b + Δ)/(2*a);
                    Console.WriteLine($"the two roots for the function f(x) = {a}x² + {b}x + {c} at f(x) = {fx} are : {X1} and {X2}");     
                }

                }
                Quadratic();
                break;

                case "1":
                Console.WriteLine("Your function is on the format: f(x) = aX + b");
                Console.WriteLine("Input, respectivelly, the values of a and b");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());

                XorY();
                void Linear()
                {
                if (fx==0)
                {
                    fx = a*(x) + b;
                    Console.WriteLine($"the function f(x) = {a}x + {b} at f({x})is: {fx}");
                }
                if (x==0)
                {
                    x = (fx-b)/a;
                    Console.WriteLine($"the x of the function f(x) = {a}x + {b} at f(x) = {fx} is: {x}");
                }

                }
                Linear();
                break;
                }
                void XorY()
                {
                Console.WriteLine("Do you know the x or the f(x) ?");
                string? YorX = Convert.ToString(Console.ReadLine());
                switch (YorX)
                {
                    case "x":
                    Console.WriteLine("Write your x");
                    x = Convert.ToDouble(Console.ReadLine());
                    break;

                    case "f(x)":
                    Console.WriteLine("Write your f(x)");
                    fx = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                }               
            }
        }

}