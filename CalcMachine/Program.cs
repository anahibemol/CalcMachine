namespace CalcMachine
{

    public static class Programa
    {

        public static class Basic
        {
             public static void Open()
            {

                Console.WriteLine(@"
                Write the following commands for what the object is:

                |1 or SIMPLE - Does only one operation.
                |2 or FULL   - Does how many operations you want.
                |3 or BACK   - Goes Back to Main Menu.
                |__________________________________________________________");
                string? Switch = Console.ReadLine() ?? "0";
                if (Switch == "1") { Switch = "SIMPLE"; }
                if (Switch == "2") { Switch = "FULL"; }
                if (Switch == "3") { Switch = "BACK"; }
                Switch = Switch.ToUpper();

                Console.WriteLine(@"
                Symbol Sheet:

                |+   -> a + b = c
                |-   -> a - b = c
                |*   -> a * b = c
                |/   -> a / b = c
                |^   -> a ^ b = c
                |Log -> LogA(base B) = C
                |__________________________________________________________");

                switch(Switch)
                {
                case "SIMPLE":
                    Simple();
                break;

                case "FULL":
                    Full();
                break;

                case "BACK":
                    MainMenu();
                break;               
                }
            
                if (Switch is not "BACK") { Basic.Open(); }

            }

             public static void Simple()
             {
                Console.WriteLine("Write the two numbers and then the operation symbol");
                double  num1 = 0;
                double  num2 = 0;
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());    
                string  symb = Console.ReadLine() ?? "+";
                double res  = 0;
                if (symb == "X" ^ symb == "x") {symb = "*";}

                switch (symb)
                {
                 case "+":
                    res = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {res}");
                 break;

                 case "-":
                    res = num1 - num2; 
                    Console.WriteLine($"{num1} - {num2} = {res}");
                 break;

                 case "*":
                    res = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {res}");
                 break;

                 case "/":
                    res = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {res}");
                 break;

                 case "^":
                    res = Math.Pow(num1, num2);
                    Console.WriteLine($"{num1}^{num2} = {res}");
                 break;

                 case "log":
                    res = Math.Log(num1, num2);
                    Console.WriteLine($"The Logarithm {num1} of base {num2} is {res}");
                 break;

                 default: Console.WriteLine("Invalid Operation"); break;
                }
             }

             public static void Full()
             {
                Console.WriteLine("Type how many operations will happen ");
                int HowLong = Convert.ToInt32(Console.ReadLine());

                List<double> InumberList = new List<double>() {}; //Inputs the user-selected number
                List<double> LogList = new List<double>() {}; //List for the log
                List<string> operationList = new List<string>() {}; //Lists the operations
                List<double> OnumberList = new List<double>() {}; //Output of the Input
                int i = HowLong+1;

                for(i = HowLong+1; i > HowLong; i--) //Bootstrap for getting the first Item of the Input
                {
                Console.WriteLine($"Write your first number"); 
                double Inum = Convert.ToDouble(Console.ReadLine()); //Gets the first Number
                InumberList.Add(Inum); 
                LogList.Add(Inum);
                }

                for(i = HowLong-1; i > 0; i--) // i = Howlong-1 accounting for the first number being added by the bootstrap
                {
                Console.WriteLine("Write the operation");
                string Iop = Console.ReadLine() ?? "+";
                operationList.Add(Iop); //Guarantees nullable exception will not happen
                E.ClearLine(2, 0);

                Console.WriteLine($"({i} remaining!) Write your number");
                double Inum = Convert.ToDouble(Console.ReadLine()); //Gets the following numbers 
                E.ClearLine(2, 0);
                
                InumberList.Add(Inum);
                LogList.Add(Inum);  
                
                double Onum = 0; //just declaring Onum beforehand to avoid errors
                Onum = OperationSwitch(Iop, InumberList[^1], InumberList[^2]);
                // ^ Receives the values to be used in the operations
                double OperationSwitch(string OpSwitch, double num1, double num2)
                
                {
                if (OnumberList is not null)
                {
                switch(OpSwitch)
                    {
                    case "+": Onum = num2+num1; OnumberList.Add(Onum); break;
                                      
                    case "-": Onum = num2-num1; OnumberList.Add(Onum); break; 
                    
                    case "X": Onum = num2*num1; OnumberList.Add(Onum); break; 
                                                               
                    case "/": Onum = num2/num1; OnumberList.Add(Onum); break;        
                    
                    case "^": Onum = Math.Pow(num2, num1); OnumberList.Add(Onum); break;  
                    
                    case "log": Onum = Math.Log(num2, num1); OnumberList.Add(Onum); break;
                    }
                }
                return 0;
                }
                    
                InumberList[^1] = OnumberList[^1];
                }

                if (i <= 0 && OnumberList is not null)
                {
                Console.WriteLine($"The final result is: {OnumberList[^1]}");

                Console.WriteLine($"The inputed  numbers are:  {string.Join(" ", LogList)}");
                Console.WriteLine($"The inputed operations are: {string.Join(" ", operationList)}");
                Console.WriteLine($"The outputed numbers are:    {string.Join(" ", OnumberList)}");

                }
                
             }
        }

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
                if (Switch == "1") { Switch = "STAT"; }
                if (Switch == "2") { Switch = "BACK"; }
                Switch = Switch.ToUpper();

                switch(Switch)
                {
                case "IDS":
                    Ids();
                break;

                case "BACK":
                    MainMenu();
                break;               
                }
            
                if (Switch is not "BACK") { Trigonometric.Open(); }

            }

            public static void Ids()
            {
                Console.WriteLine("Write your angle (in degrees)");
                double angle = Convert.ToDouble(Console.ReadLine());
                double radian = (angle * (Math.PI)) / 180; //converts the degrees to radians
                E.ClearLine(2, 0);
                Console.WriteLine($"{angle}° in radians is: {radian}");

                Console.WriteLine($"The Sine of {angle}° is {Math.Sin(radian)}");
                Console.WriteLine($"The Cosine of {angle}° is {Math.Cos(radian)}");
                Console.WriteLine($"The Tangent of {angle}° is {Math.Tan(radian)}");
                Console.WriteLine($"The Cosecant of {angle}° is {1/(Math.Sin(radian))}");
                Console.WriteLine($"The Secant of {angle}° is {1/(Math.Cos(radian))}");
                Console.WriteLine($"The Cotangent of {angle}° is {1/(Math.Tan(radian))}");                
            }
        }

        public static class Geometric
        {
            public static void Open()
            {

                Console.WriteLine(@"
                Write the following commands for what the object is:

                |1 or POLYGON - Your Object is a Regular Polygon.
                |2 or CIRCLE  - Your Object is a Circle.
                |3 or OTHER   - Your Object is neither of the above. (WIP)
                |4 or BACK    - Goes Back to Main Menu.
                |___________________________________________________");
                string? Switch = Console.ReadLine() ?? "0";
                if (Switch == "1") { Switch= "POLYGON"; }
                if (Switch == "2") { Switch= "CIRCLE"; }
                if (Switch == "3") { Switch= "OTHER"; }
                if (Switch == "4") { Switch= "BACK"; }
                Switch = Switch.ToUpper();

                switch(Switch)
                {
                case "POLYGON":
                    Polygon();
                break;
                case "CIRCLE":
                    Circle();
                break;
                case "OTHER":
                    Other();
                break;
                case "BACK":
                    MainMenu();
                break;               
                }
            
                if (Switch is not "BACK") { Geometric.Open(); }

            }

            public static void Polygon()
            {

                Console.WriteLine("How many sides does it have?");
                int n = Convert.ToInt32(Console.ReadLine()); //using the n-gon as guideline

                if (n >= 3)
                {

                const double Pi = 1*(Math.PI); //Alias Shorthand
                double AnIn = (180*(n-2))/n; //Internal Angle
                double AnEx = 360 - AnIn;    //External Angle
                double RadIn = E.ToRad(AnIn); //Radian of the internal angle
                double area = 0;    //Initial Value, use it as error if it passes to the end
                double side = 0;    //^
                double apothem = 0; //^

                Console.WriteLine("Write the value of the known value and then what it is");
                Console.WriteLine("(supported properties are: side, apothem, area)");
                double value  = Convert.ToDouble(Console.ReadLine());
                string property = Console.ReadLine() ?? "side length";
                    
                if (property == "apothem")
                { area = Math.Tan(Pi/n)*(n*Math.Pow(value,2)); side = (2*value)/Math.Tan(RadIn/2); apothem = value; }

                if (property == "side")
                { apothem = (value*(Math.Tan(RadIn/2)/2)); area = ((value*n)*apothem); side = value; }

                if (property == "area")
                { apothem = Math.Sqrt(value*Math.Tan(RadIn/2)/n);side = (2*apothem)/Math.Tan(RadIn/2); area = value; }

                
                    Console.WriteLine($"The area is: {area}");
                    Console.WriteLine($"The side is: {side}");
                    Console.WriteLine($"The apothem is: {apothem}");
                    Console.WriteLine($"The polyhon has {n} sides");
                    Console.WriteLine($"The number of diagonals is {0.5*(n*(n-3))}");
                    Console.WriteLine($"Each of the internal angles has {AnIn}°, totalizing {AnIn*n} degrees");
                    Console.WriteLine($"In addition, the external angle has {AnEx}° totalizing {AnEx*n}°");
                }

                else { Console.WriteLine ("Not a valid Polygon (less than two sides)"); }

            }

            public static void Circle()
                {

                const double Pi = 1*(Math.PI); //Alias Shorthand

                Console.WriteLine("Write the value and what it is (Radius, Circunference, Area)");
                    double  Cvalue    = Convert.ToDouble(Console.ReadLine());
                    string  Cproperty = Console.ReadLine() ?? "RADIUS";
                    double  Carea     = 0;
                    double  Clength   = 0;
                    double  Cradius   = 0;
                if (Cproperty.ToUpper() == "RADIUS")
                {Cradius = Cvalue; Clength = (2*Pi)*Cvalue; Carea = (Pi*(Cvalue*Cvalue));}
                if (Cproperty.ToUpper() == "CIRCUNFERENCE")
                {Clength = Cvalue; Cradius = Clength/(2*(Pi)); Carea = (Pi*(Cradius*Cradius));}
                if (Cproperty.ToUpper() == "AREA")
                {Carea = Cvalue; Cradius = Math.Sqrt(Cvalue/Pi); Clength = (2*Pi)*Cradius;}
                
                Console.WriteLine($"The radius is {Cradius}");
                Console.WriteLine($"The circunference is {Clength}");
                Console.WriteLine($"The area is {Carea}");
                }

            public static void Other()            
                {

                Console.WriteLine(@"
                Write the command for the desired Polygon:

                |1 or ISOSCELES - A Triangle with two equal sides.
                |2 or TRAPEZIUM - A Quadrilateral with only 1 pair of parallel lines.
                |3 or DIAMOND   - A Square without all angles being 90°.
                |4 or RETANGLE  - A Square without all sides being equal.
                |5 or BACK      - Goes Back to Geometry Menu.
                |____________________________________________________________________");                    

                }
            
        }

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
                    MainMenu();
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

        public static class Statitics
        {
            public static void Open()
            {

                Console.WriteLine(@"
                Write the following commands for what the object is:

                |1 or STAT    - Starts the Calculator.
                |2 or BACK    - Goes Back to Main Menu.
                |___________________________________________________");
                string? Switch = Console.ReadLine() ?? "0";
                if (Switch == "1") { Switch = "STAT"; }
                if (Switch == "2") { Switch = "BACK"; }
                Switch = Switch.ToUpper();

                switch(Switch)
                {
                case "STAT":
                    Liszt();
                break;

                case "BACK":
                    MainMenu();
                break;               
                }
            
                if (Switch is not "BACK") { Statitics.Open(); }

            }

            public static void Liszt()
            {

                Console.WriteLine("Write the number of elements of the dataset");
                int HowLong = Convert.ToInt32(Console.ReadLine());  
                List<double> dataSet = new List<double>(){};

                for (int i = HowLong; i>0; i--) //loop for getting the elements of the statistics
                {
                    string word = "first"; if (i != HowLong) { word = "next"; }
                    Console.WriteLine($"({i} remaining!) Write the {word} number");
                    double y = Convert.ToDouble(Console.ReadLine());
                    dataSet.Add(y);
                }

                dataSet.Sort();
                double average = dataSet.Average();       //gets the average of the dataset
                double median = dataSet[dataSet.Count/2]; //gets the median of the dataset

            double MeanDeviator(int bessel) //Just the algorithm, bessel is for alternate method
            {
                double sum = 0; //sets standard sum
                double meandev = 0; //sets standard mean deviation
                foreach(var item in dataSet)
                {
                sum += Math.Pow((item - average),2);
                }
                meandev = Math.Sqrt((sum)/(dataSet.Count - bessel));
                return meandev;
            }

                /* */ dynamic mode = dataSet.GroupBy(i=>i).OrderByDescending(grp=>grp.Count())
                /* */                   .Select(grp=>grp.Key).First();

                if (dataSet[0] != dataSet[1]) {mode = "inexistent";}
                int n = 0;
                Console.WriteLine("For the set of data:");

                while (n < dataSet.Count()) 
                {
                     Console.Write($"N{n+1}: ");
                     Console.Write($"{dataSet[n]}\n");
                     n++;
                }
                Console.WriteLine();
                Console.WriteLine($"The average is {average}");
                Console.WriteLine($"The mode is {mode}");
                Console.WriteLine($"The median (middle number) is {median}");
                Console.WriteLine($"The mean deviation is {MeanDeviator(0)} ({MeanDeviator(1)} with Bessel's correction)");
                Console.WriteLine($"The largest number is {dataSet[^1]}");
                Console.WriteLine($"The smallest number is {dataSet[0]}");                
            }
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
                |6 or EXIT     - Exits the Program.
                |_______________________________________________________");
                string OpeningMenu = Console.ReadLine() ?? "1";

                if (OpeningMenu == "1") { OpeningMenu = "BASIC"; }
                if (OpeningMenu == "2") { OpeningMenu = "TRIG"; }
                if (OpeningMenu == "3") { OpeningMenu = "GEO"; }
                if (OpeningMenu == "4") { OpeningMenu = "FUNC"; }
                if (OpeningMenu == "5") { OpeningMenu = "STATS"; }
                if (OpeningMenu == "6") { OpeningMenu = "EXIT";  }
                OpeningMenu = OpeningMenu.ToUpper(); //Case insensitiviness

                switch (OpeningMenu)
                {

                    case "BASIC":
                    Basic.Open();
                    break;
  
                    case "TRIG":
                    Trigonometric.Open();
                    break;

                    case "GEO":
                    Geometric.Open();
                    break;

                    case "FUNC":
                    Function.Open();
                    break;

                    case "STATS":
                    Statitics.Open();
                    break;
                    
                    case "EXIT":
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
          | |   \__  |     | |___  \__  |      |  |     |  \__  |   |  |  |   \| |____  | v. Beta 2.1.0 / _/
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

