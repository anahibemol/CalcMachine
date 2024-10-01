namespace CalcMachine
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
                case "SIMPLE" or "1":
                    Simple();
                break;

                case "FULL" or "2":
                    Full();
                break;

                case "BACK" or "3":
                    Programa.MainMenu();
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
                Programa.E.ClearLine(2, 0);

                Console.WriteLine($"({i} remaining!) Write your number");
                double Inum = Convert.ToDouble(Console.ReadLine()); //Gets the following numbers 
                Programa.E.ClearLine(2, 0);
                
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

}