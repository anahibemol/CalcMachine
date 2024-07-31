using CalcMachine;

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
                    Programa.MainMenu();
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
                double RadIn = Programa.E.ToRad(AnIn); //Radian of the internal angle
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
                       value2 = Programa.E.ToRad(value2);
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
