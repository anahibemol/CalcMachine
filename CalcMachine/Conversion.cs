namespace CalcMachine
{
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
                    Programa.MainMenu();
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
}