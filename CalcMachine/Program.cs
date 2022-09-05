using System;

namespace CalcMachine
{

    public static class Programa
    {

        public static class Basic
        {
             public static void Open()
            {

                Console.WriteLine(@"
                Write the following commands for what your needs are:

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
                    Other.Open();
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

            public static class Other
            {
            public static void Open()            
                {

                Console.WriteLine(@"
                Write the command for the desired Polygon:

                |1 or ISOSCELES - A Triangle with two equal sides. (WIP)
                |2 or TRIRECT   - A Triangle with a 90° angle.
                |3 or TRAPEZIUM - A Quadrilateral with only 1 pair of parallel lines.
                |4 or RECTANGLE - A Square without all sides being equal.
                |5 or BACK      - Goes Back to Geometry Menu.
                |____________________________________________________________________");                    
                string? Switch = Console.ReadLine() ?? "0";
                if (Switch == "1") { Switch= "ISOSCELES"; }
                if (Switch == "2") { Switch= "TRIRECT";   }
                if (Switch == "3") { Switch= "TRAPEZIUM"; }
                if (Switch == "4") { Switch= "RECTANGLE"; }
                if (Switch == "5") { Switch= "BACK";      }
                Switch = Switch.ToUpper();

                switch(Switch)
                {
                case "ISOSCELES":
                    Isosceles();
                break;
                case "TRIRECT":
                    Trirect();
                break;
                case "TRAPEZIUM":
                    Trapezium();
                break;
                case "RECTANGLE":
                    Rectangle();
                break;
                case "BACK":
                    Geometric.Open();
                break;               
                }
            
                if (Switch is not "BACK") { Geometric.Other.Open(); }

                
                }
            
            public static void Isosceles()
            {
                Console.WriteLine("Write the value you know and then what it is (LEGS or BASE)");
                double value = Convert.ToDouble(Console.ReadLine());
                string property = Console.ReadLine() ?? "LEGS";
                Console.WriteLine("Write the value of the angle you know and where is it (LEGS or BASE)");
                double value2 = Convert.ToDouble(Console.ReadLine());
                       value2 = E.ToRad(value2);
                string property2 = Console.ReadLine() ?? "LEGS";
                if (property == "LEGS")
                {
                    if (property2 == "LEGS")
                    {
                        double Base = (2*(Math.Sin(value2/2)*value));
                        double Height = Math.Sqrt(Math.Pow(value, 2)-(Math.Pow(Base, 2))/2);
                        double Area = (Base*Height)/2;

                        Console.WriteLine("With the info you gave, we can determine:");
                        Console.WriteLine($"The Leg has a lenght of {value}");
                        Console.WriteLine($"The Base has a lenght of {Base}");

                        Console.WriteLine($"The Height is {Height}");
                        Console.WriteLine($"The Area is {Area}");
                        Console.WriteLine($"The Angles are {value2}, {90/value2}, {90/value2}");
                    }
                    if (property2 == "BASE")
                    {
                        double Base = (2*(Math.Cos(value2)*value));
                        double Height = Math.Sqrt(Math.Pow(value, 2)-(Math.Pow(Base, 2))/2);
                        double Area = (Base*Height)/2;

                        Console.WriteLine("With the info you gave, we can determine:");
                        Console.WriteLine($"The Leg has a lenght of {value}");
                        Console.WriteLine($"The Base has a lenght of {Base}");
                        
                        Console.WriteLine($"The Height is {Height}");
                        Console.WriteLine($"The Area is {Area}");
                        Console.WriteLine($"The Angles are {180-(2*(value2))}, {value2}, {value2}");
                    }
                }
                if (property == "BASE")
                {
                    if (property2 == "LEGS")
                    {
                        double Leg = (2*(Math.Sin(value2/2)/value));
                        double Height = Math.Sqrt(Math.Pow(Leg, 2)-(Math.Pow(value, 2))/2);
                        double Area = (value*Height)/2;

                        Console.WriteLine("With the info you gave, we can determine:");
                        Console.WriteLine($"The Leg has a lenght of {Leg}");
                        Console.WriteLine($"The Base has a lenght of {value}");

                        Console.WriteLine($"The Height is {Height}");
                        Console.WriteLine($"The Area is {Area}");
                        Console.WriteLine($"The Angles are {value2}, {90/value2}, {90/value2}");
                    }
                    if (property2 == "BASE")
                    {
                        double Leg = (2*(Math.Cos(value2)/value));
                        double Height = Math.Sqrt(Math.Pow(Leg, 2)-(Math.Pow(value, 2))/2);
                        double Area = (value*Height)/2;
                                                
                        Console.WriteLine("With the info you gave, we can determine:");
                        Console.WriteLine($"The Leg has a lenght of {Leg}");
                        Console.WriteLine($"The Base has a lenght of {value}");

                        Console.WriteLine($"The Height is {Height}");
                        Console.WriteLine($"The Area is {Area}");
                        Console.WriteLine($"The Angles are {180-(2*(value2))}, {value2}, {value2}");
                    }
                }
            }

            public static void Trirect()
            {
                Console.WriteLine("Write the value you know and then what it is (LEGs or HIP)");
                double value = Convert.ToDouble(Console.ReadLine());
                double unknown = 0;
                string property = Console.ReadLine() ?? "LEGS";

                property = property.ToUpper();

                if (property == "LEGS")
                {
                    unknown = Math.Pow(value, 2) + Math.Pow(value, 2);

                    Console.WriteLine(@$"
                    About the Triangle:
                    |Legs       = { value } each.
                    |Hipotenuse = { unknown }.
                    |Area       = { Math.Pow(value, 2)/2 }.
                    |Perimeter  = { value*2 + unknown}.
                    |___________________________________");
                }

                if (property == "HIP")
                {
                    unknown = Math.Sqrt(value/2);

                    Console.WriteLine(@$"
                    About the Triangle:
                    |Legs       = { unknown } each.
                    |Hipotenuse = { value }.
                    |Area       = { Math.Pow(unknown, 2)/2 }.
                    |Perimeter  = { unknown*2 + value}.
                    |___________________________________");
                }


                
            }

            public static void Trapezium()
            {
                Console.WriteLine("Write the value of the Lower Base");
                double LowerBase = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Write the value of the Upper Base");
                double UpperBase = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Write the value of the slope on the side");
                double Slope1 = Convert.ToDouble(Console.ReadLine());
                double Slope2 = 0;
                Console.WriteLine("Are the two Slopes equal (Y/N)");
                string Equal = Console.ReadLine() ?? "N"; Equal = Equal.ToUpper();
                if (Equal == "Y") {Slope2 = Slope1;}
                else
                {
                    Console.WriteLine("Write the value of the Other Slope");
                    Slope2 = Convert.ToDouble(Console.ReadLine());
                }

                double Perimeter = Slope1 + Slope2 + LowerBase + UpperBase;
                double AvgSlope = (Slope1+Slope2)/2;
                double AvgDif = Math.Abs((LowerBase-UpperBase)/2);
                double Height = Math.Sqrt(Math.Pow(AvgSlope, 2) - Math.Pow(AvgDif,2));
                double Area = (Height*((UpperBase+LowerBase)/2));
                
            }
            

            public static void Rectangle()
            {
                Console.WriteLine("Write the value of one of the sides");
                double value = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Write the other value that you know and what it is (SIDE or DIAGONAL");
                double value2 = Convert.ToDouble(Console.ReadLine());
                double unknown = 0;
                string property = Console.ReadLine() ?? "SIDE";

                if (property == "SIDE")
                {
                    unknown = Math.Sqrt(value*value + value2*value2); 
                    
                    Console.WriteLine(@$"
                    About the Rectanglee:
                    |Side 1     = { value }
                    |Side 2     = { value2 }.
                    |Area       = { value * value2 }.
                    |Perimeter  = { value*2 + value2*2 }.
                    |Diagonal   = { unknown } each.
                    |___________________________________");                    
                }

                if (property == "DIAGONAL")
                {
                    unknown = Math.Sqrt(value2*value2 - value*value); 

                    Console.WriteLine(@$"
                    About the Rectanglee:
                    |Side 1     = { value }
                    |Side 2     = { unknown }.
                    |Area       = { value * unknown }.
                    |Perimeter  = { value*2 + unknown*2 }.
                    |Diagonal   = { value2 } each.
                    |___________________________________");     
                }
            }

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
                Write the following commands for what you want:

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
                    Listing();
                break;

                case "BACK":
                    MainMenu();
                break;               
                }
            
                if (Switch is not "BACK") { Statitics.Open(); }

            }

            public static void Listing()
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

        public static class Conversion
        {
            public static void Open()
            {

                Console.WriteLine(@"
                Write the following commands for the type of measure:

                |1 or LONG   - For Lenght Conversions.
                |2 or HEAVY  - For Weight Conversions.
                |3 or FAST   - For Speed Conversions.
                |4 or HOT    - For Temperature Conversions.
                |5 or BACK   - Goes Back to Main Menu.
                |___________________________________________________");
                string? Switch = Console.ReadLine() ?? "0";
                if (Switch == "1") { Switch= "LONG"; }
                if (Switch == "2") { Switch= "HEAVY"; }
                if (Switch == "3") { Switch= "FAST"; }
                if (Switch == "4") { Switch= "HOT"; }
                if (Switch == "5") { Switch= "BACK"; }
                Switch = Switch.ToUpper();

                switch(Switch)
                {
                case "LONG":
                    Lenght();
                break;
                case "HEAVY":
                    Weight();
                break;
                case "FAST":
                    Speed();
                break;
                case "HOT":
                    Temperature();
                break;
                case "BACK":
                    MainMenu();
                break;               
                }
            
                if (Switch is not "BACK") { Conversion.Open(); }                
            }
        
            public static void Lenght()
            {
                Console.WriteLine(@"
                Supported Measures:

                |MILIMIMETER       - 1/1000th of a Meter. 
                |CENTIMETER        - 1/100th of a Meter.  
                |DECIMETER         - 1/10th of a Meter.
                |METER             - Standard Unit, about 1.0936 yard
                |KILOMETER         - 1000 Meters.
                |INCH              - About 2.54 Centimeters.
                |FOOT              - 12 inches, About 30,4 Centimeters. 
                |YARD              - 3 feet, About 0.91 Meters.
                |MILE              - 5280 feet, About 1.6 Kilometers.
                |NAUTICAL MILE     - One Minute Arc of Latitude, About 1.82km    
                |____________________________________________________________");

                Console.WriteLine("Write the number of units and then the type of unit");
                double number = Convert.ToDouble(Console.ReadLine());
                string unit   = Console.ReadLine() ?? "METER";
                unit = unit.ToUpper();
                unit = unit.Trim();

                Console.WriteLine(@$"
                From the {number} of the unit {unit} you inputed:

                |MILIMIMETER       - {ConverterBoiler(1, unit, number, 1)} 
                |CENTIMETER        - {ConverterBoiler(1, unit, number, 2)}   
                |DECIMETER         - {ConverterBoiler(1, unit, number, 3)}   
                |METER             - {ConverterBoiler(1, unit, number, 4)}   
                |KILOMETER         - {ConverterBoiler(1, unit, number, 5)}   
                |INCH              - {ConverterBoiler(1, unit, number, 6)}   
                |FOOT              - {ConverterBoiler(1, unit, number, 7)}   
                |YARD              - {ConverterBoiler(1, unit, number, 8)}   
                |MILE              - {ConverterBoiler(1, unit, number, 9)}   
                |NAUTICAL MILE     - {ConverterBoiler(1, unit, number, 10)}      
                |____________________________________________________________________________");                
                
            }
            public static void Weight()
            {
                Console.WriteLine(@"
                Supported Measures:

                |MILIGRAM          - 1/1000th of a Gramr. 
                |GRAM              - 1/1000th of a Kilogram.  
                |KILOGRAM          - Standard Unit.
                |TON               - 1000 Kilograms.
                |OUNCE             - About 28.35 Grams.
                |POUND             - About 0.45 Kilograms.
                |LONG TON          - 2240 Pounds.
                |SHORT TON         - 2000 Pounds.
                |STONE             - About 0.157 Kilograms.  
                |__________________________________________");

                Console.WriteLine("Write the number of units and then the type of unit");
                double number = Convert.ToDouble(Console.ReadLine());
                string unit   = Console.ReadLine() ?? "KILOGRAM";
                unit = unit.ToUpper();
                unit = unit.Trim();

                Console.WriteLine(@$"
                From the {number} of the unit {unit} you inputed:

                |MILIGRAM   - {ConverterBoiler(2, unit, number, 1)} 
                |GRAM       - {ConverterBoiler(2, unit, number, 2)}   
                |KILOGRAM   - {ConverterBoiler(2, unit, number, 3)}   
                |TON        - {ConverterBoiler(2, unit, number, 4)}   
                |OUNCE      - {ConverterBoiler(2, unit, number, 5)}   
                |POUND      - {ConverterBoiler(2, unit, number, 6)}   
                |LONG TON   - {ConverterBoiler(2, unit, number, 7)}   
                |SHORT TON  - {ConverterBoiler(2, unit, number, 8)}   
                |STONE      - {ConverterBoiler(2, unit, number, 9)}       
                |____________________________________________________________________________");   

            }
            public static void Speed()
            {
                Console.WriteLine(@"
                Supported Measures:

                |KILOMETER / HOUR  - About 3.6 Meters/Second.
                |METER / SECOND    - Standard Unit.  
                |FEET / SECOND     - About 3.21 Meters/Second.
                |MILE / HOUR       - About 2.24 Meters/Second.
                |KNOT              - About 1.94 Meters/Second.
                |MACH              - Soundspeed, 343 Meters/Second.
                |________________________________________________");

                Console.WriteLine("Write the number of units and then the type of unit");
                double number = Convert.ToDouble(Console.ReadLine());
                string unit   = Console.ReadLine() ?? "METER / SECOND";
                unit = unit.ToUpper();
                unit = unit.Trim();

                Console.WriteLine(@$"
                From the {number} of the unit {unit} you inputed:

                |KILOMETER / HOUR  - {ConverterBoiler(3, unit, number, 1)} 
                |METER / SECOND    - {ConverterBoiler(3, unit, number, 2)}   
                |FEET / SECOND     - {ConverterBoiler(3, unit, number, 3)}   
                |MILE / HOUR       - {ConverterBoiler(3, unit, number, 4)}   
                |KNOT              - {ConverterBoiler(3, unit, number, 5)}   
                |MACH              - {ConverterBoiler(3, unit, number, 6)}         
                |____________________________________________________________________________");   
            }
            public static void Temperature()
            {
                Console.WriteLine(@"
                Supported Measures:

                |CELSIUS    - 0 K - 273,15 = -273,1 °C
                |KELVIN     - Standard Unit.  
                |FARENHEIT  - (0 °C x 9/5) + 32 = 32 °F
                |_______________________________________");

                Console.WriteLine("Write the number of units and then the type of unit");
                double number = Convert.ToDouble(Console.ReadLine());
                string unit   = Console.ReadLine() ?? "KILOGRAM";
                unit = unit.ToUpper();
                unit = unit.Trim();

                Console.WriteLine(@$"
                From the {number} of the unit {unit} you inputed:

                |CELSIUS   - {ConverterBoiler(4, unit, number, 1)} 
                |KELVIN    - {ConverterBoiler(4, unit, number, 2)}   
                |FARENHEIT - {ConverterBoiler(4, unit, number, 3)}           
                |____________________________________________________________________________"); 
            }

            public static double ConverterBoiler(int Type, string Unit, double Number, int Ar)
            {
                string Typer = Convert.ToString(Type);
                switch (Typer)
                {
                    case "1":
                        //first, convert to Meter.
                        if (Unit == "MILIMETER")     { Number = Number/1000;    }
                        if (Unit == "CENTIMETER")    { Number = Number/100;     }
                        if (Unit == "DECIMETER")     { Number = Number/10;      }
                        if (Unit == "METER")         { Number = Number*1;       }
                        if (Unit == "KILOMETER")     { Number = Number*1000;    }
                        if (Unit == "INCH")          { Number = Number*0.0254d; }
                        if (Unit == "FOOT")          { Number = Number*0.3048d; }
                        if (Unit == "YARD")          { Number = Number*0.91d;   }
                        if (Unit == "MILE")          { Number = Number*1609;    }
                        if (Unit == "NAUTICALMILE")  { Number = Number*1852;    }

                        double[] Lenghts = new double[]
                        {
                            0,
                            Number*1000,
                            Number*100,
                            Number*10,
                            Number,
                            Number/1000,
                            Number*39.37d,
                            Number*328d,
                            Number*1.095,
                            Number/1609,
                            Number/1852,
                        };
                    return Lenghts[Ar];

                    case "2":
                        //first, convert to Kilogram.
                        if (Unit == "MILIGRAM")   { Number = Number/1000000;}
                        if (Unit == "GRAM")       { Number = Number/1000;   }
                        if (Unit == "KILOGRAM")   { Number = Number/1;      }
                        if (Unit == "TON")        { Number = Number*1000;   }
                        if (Unit == "OUNCE")      { Number = Number*0.028d; }
                        if (Unit == "POUND")      { Number = Number*0.45d;  }
                        if (Unit == "LONGTON")    { Number = Number*1016;   }
                        if (Unit == "SHORTTON")   { Number = Number*907;    }
                        if (Unit == "STONE")      { Number = Number*6.35d;  }

                        double[] Weights = new double[]
                        {
                            0,
                            Number*1000000,
                            Number*1000,
                            Number,
                            Number/1000,
                            Number/135.27d,
                            Number/2.205d,
                            Number/1016,
                            Number/907.2d,
                            Number*0.157d,
                        };
                    return Weights[Ar];
                    
                    case "3":
                        //first, convert to Meters / Second
                        if (Unit == "KILOMETER/HOUR")   { Number = Number/3.6d;  }
                        if (Unit == "METER/SECOND")     { Number = Number/1;     }
                        if (Unit == "FEET/SECOND")      { Number = Number*0.30d; }
                        if (Unit == "MILE/HOUR")        { Number = Number*0.44d; }
                        if (Unit == "KNOT")             { Number = Number*0.51d; }
                        if (Unit == "MACH")             { Number = Number*343;   }
                    double[] Speeds = new double[]
                    {
                        0,
                        Number*3.6d,
                        Number,
                        Number/0.30d,
                        Number/0.44d,
                        Number/0.51d,
                        Number/343,
                    };

                    return Speeds[Ar];

                    case "4":
                        //First, convert to Celsius
                        if (Unit == "CELSIUS")   { Number = Number/1;  }
                        if (Unit == "KELVIN")    { Number = Number-273.15;     }
                        if (Unit == "FARENHEIT") { Number = (Number*9/5) + 32; }
                    double[] Temperatures = new double[]
                    {
                        0,
                        Number,
                        Number + 273.15d,
                        (Number-32)*5/9,
                    };

                    return Temperatures[Ar];
                    
                    default:
                    return 0;
                }
             
            }
        }
 
        public static class Other
        {
            public static void Prime()
            {
                Console.WriteLine("Write your number");
                    int num = Convert.ToInt32(Console.ReadLine() ?? "2");
                    for(int n = 2; n <= num; n++)
                    {                
                        int primecheck = 0;
                        for(int i = 1; i < n; i++)
                        {
                            if(n % i == 0) {primecheck = primecheck+1; }
                        }
                        if (primecheck > 1) {Console.WriteLine($"{n} is not prime"); }
                        else                {Console.WriteLine($"{n} is prime"); }
                    }
            }
        }

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

