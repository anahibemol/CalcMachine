using static System.Int32;

 static void programa()
{       
    Console.WriteLine("Select the type of calculator you want to use");
    Console.WriteLine(@"
      1 - Arithmetic 
      2 - Trigonometric
      3 - Geometric
      4 - Function
      5 - Statistics
      9 - Special");

    string CalculatorCore = Console.ReadLine() ?? "1";
    
    Console.Clear();
    switch(CalculatorCore)
    {
 case "1":
    ArithmeticCalc();
  break;
 case "2":
    TrigonometricCalc();
  break;
 case "3":
    PolygonCalc();
  break;
 case "4":
    FunctionCalc();
  break;
 case "5":
    StatCalc();
  break;
 case "9":
    SpecialCalc();
  break;
    }

}
programa();
//Main Modules Below

 static void ArithmeticCalc()
 {
 bool onoff = true;
 while (onoff is true)
  {

  Console.WriteLine("How many operations will happen (type 0 if you want to do the max number of operations)");
int StdHowlong = Int32.MaxValue;
int HowLong = Convert.ToInt32(Console.ReadLine());
  if (HowLong is 0) {HowLong = StdHowlong;}

  Console.WriteLine(@"The following symbols represent the operations, keep that in mind for later
 
  + - Addition         (x+y) 
  - - Subtraction      (x-y)
  X - Multiplication   (x*y) 
  / - Division         (x/y)
  ^ - Exponentiation   (x^y)");

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
  Console.WriteLine("Write the opeartion");
 string? Iop = Convert.ToString(Console.ReadLine());
  if (Iop is not null) {operationList.Add(Iop);} //Guarantees nullable exception will not happen
  ClearLine(2, 0);

  Console.WriteLine($"({i} remaining!) Write your number");
 double Inum = Convert.ToDouble(Console.ReadLine()); //Gets the following numbers 
  ClearLine(2, 0);
  
  InumberList.Add(Inum);
  LogList.Add(Inum);  
  
 double Onum = 0; //just declaring Onum beforehand to avoid errors
  if (Iop is not null) {Onum = OperationSwitch(Iop, InumberList[^1], InumberList[^2]);} 
  // ^ Receives the values to be used in the operations
 double OperationSwitch(string OpSwitch, double num1, double num2)
  
 {
  if (OnumberList is not null)
  {
   switch(OpSwitch)
    {
      case "+":     
      Onum = num2+num1;
      OnumberList.Add(Onum);
      break;
      case "-":     
      Onum = num2-num1;
      OnumberList.Add(Onum);
      break;
      case "X":     
      Onum = num2*num1;
      OnumberList.Add(Onum);
      break;     
      case "/":     
      Onum = num2/num1;
      OnumberList.Add(Onum);
      break;
      case "^":     
      Onum = Math.Pow(num2, num1);
      OnumberList.Add(Onum);
      break;
    }
  }
   return 0;
 }
    
  InumberList[^1] = OnumberList[^1];
}
 int Log()
{
if (i <= 0 && OnumberList is not null)
{
Console.WriteLine($"The final result is: {OnumberList[^1]}");


Console.WriteLine($"The inputed  numbers are:  {string.Join(" ", LogList)}");
Console.WriteLine($"The inputed operations are: {string.Join(" ", operationList)}");
Console.WriteLine($"The outputed numbers are:    {string.Join(" ", OnumberList)}");

}
return 0;
}
Log();

  Console.WriteLine("Do you want to use it again ? (Y/N) (type 0 to go back to the opening menu)");
  string? YN = Convert.ToString(Console.ReadLine());
  if (YN is not null && YN is "Y") {onoff = true;}
  if (YN is not null && YN is "N") {onoff = false;}
  if (YN is "0") {programa();}
  }
 }

 static void TrigonometricCalc()
 {
 bool onoff = true;
 while (onoff is true)
  {
  Console.WriteLine("Write your angle (in degrees)");
 double angle = Convert.ToDouble(Console.ReadLine());
 double radian = (angle * (Math.PI)) / 180; //converts the degrees to radians
   ClearLine(2, 0);
  Console.WriteLine($"{angle}° in radians is: {radian}");

  Console.WriteLine($"The Sine of {angle}° is {Math.Sin(radian)}");
  Console.WriteLine($"The Cosine of {angle}° is {Math.Cos(radian)}");
  Console.WriteLine($"The Tangent of {angle}° is {Math.Tan(radian)}");
  Console.WriteLine($"The Cosecant of {angle}° is {1/(Math.Sin(radian))}");
  Console.WriteLine($"The Secant of {angle}° is {1/(Math.Cos(radian))}");
  Console.WriteLine($"The Cotangent of {angle}° is {1/(Math.Tan(radian))}");

  Console.WriteLine("Do you want to use it again ? (Y/N) (type 0 to go back to the opening menu)");
 string? YN = Convert.ToString(Console.ReadLine());
  if (YN is not null && YN is "Y") {onoff = true;}
  if (YN is not null && YN is "N") {onoff = false;}
  if (YN is "0") {programa();}
  }
 }

 static void PolygonCalc()
 {
 bool onoff = true; //looping mechanism
 while (onoff is true)
  {

  Console.WriteLine("Is your Polygon a Circle? (Y/N)");
 string? regular = "" ?? "Y";
  regular = Console.ReadLine();
  switch(regular)
  {
  case "Y":
    Console.WriteLine("How many sides does it have?");
   int n = Convert.ToInt32(Console.ReadLine()); //using the n-gon as guideline

   double AngleIn = (180*(n-2))/n;
   double AngleEx = 360 - AngleIn;
   double RadianIn = (AngleIn * (Math.PI)) / 180;
   double area = 0;
   double side = 0;
   double apothem = 0;
    Console.WriteLine("Write the value of the known value and then what it is");
    Console.WriteLine("(supported properties are: side, apothem, area)");
   double value  = Convert.ToDouble(Console.ReadLine());
   string? property = "" ?? "side length";
    property = Console.ReadLine();
    
  if (property == "apothem")
    {area = Math.Tan(Math.PI/n)*(n*Math.Pow(value,2)); side = (2*value)/Math.Tan(RadianIn/2); apothem = value;}

  if (property == "side")
    {apothem = (value*(Math.Tan(RadianIn/2)/2)); area = ((value*n)*apothem); side = value;}

  if (property == "area")
    {apothem = Math.Sqrt(value*Math.Tan(RadianIn/2)/n);side = (2*apothem)/Math.Tan(RadianIn/2); area = value;}

    Console.WriteLine($"The area is: {area}");
    Console.WriteLine($"The side is: {side}");
    Console.WriteLine($"The apothem is: {apothem}");
    Console.WriteLine($"The polyhon has {n} sides");
    Console.WriteLine($"The number of diagonals is {0.5*(n*(n-3))}");
    Console.WriteLine($"Each of the internal angles has {AngleIn}°, totalizing {AngleIn*n} degrees");
    Console.WriteLine($"In addition, the external angle has {AngleEx}° totalizing {AngleEx*n}°");
   break;
  case "N":
   Console.WriteLine("Write the value and what it is (Radius, Circunference, Area)");
    double  Cvalue    = Convert.ToDouble(Console.ReadLine());
    string? Cproperty = Convert.ToString(Console.ReadLine());
    double  Carea     = 0;
    double  Clength   = 0;
    double  Cradius   = 0;
  if (Cproperty == "Radius")
  {Cradius = Cvalue; Clength = (2*Math.PI)*Cvalue; Carea = (Math.PI*(Cvalue*Cvalue));}
  if (Cproperty == "Circunference")
  {Clength = Cvalue; Cradius = Clength/(2*(Math.PI)); Carea = (Math.PI*(Cradius*Cradius));}
  if (Cproperty == "Area")
  {Carea = Cvalue; Cradius = Math.Sqrt(Cvalue/Math.PI); Clength = (2*Math.PI)*Cradius;}
   
  Console.WriteLine($"The radius is {Cradius}");
  Console.WriteLine($"The circunference is {Clength}");
  Console.WriteLine($"The area is {Carea}");
  break;
  }
    Console.WriteLine("Do you want to use it again ? (Y/N) (type 0 to go back to the opening menu)");
   string? YN = Convert.ToString(Console.ReadLine());
    if (YN is not null && YN is "Y") {onoff = true;}
    if (YN is not null && YN is "N") {onoff = false;}
    if (YN is "0") {programa();}
  }
 }
 
 static void FunctionCalc()
 {
 bool onoff = true; //looping mechanism
 while (onoff is true)
  {
    double a = 0; double b = 0; double c = 0; double d = 0; double x = 0; double fx = 0;
    Console.WriteLine("Which exponent/degree is the highest on your function ? (3 / 2 / 1)");
    string? PowSwitch = Convert.ToString(Console.ReadLine());
    
    switch (PowSwitch)
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


    Console.WriteLine("Do you want to use it again ? (Y/N) (type 0 to go back to the opening menu)");
   string? YN = Convert.ToString(Console.ReadLine());
    if (YN is not null && YN is "Y") {onoff = true;}
    if (YN is not null && YN is "N") {onoff = false;}
    if (YN is "0") {programa();}
  }
 }

 static void StatCalc()
 {
 bool onoff = true; //looping mechanism
 while (onoff is true)
  {

    Console.WriteLine("Write the number of elements of the dataset");
   int HowLong = Convert.ToInt32(Console.ReadLine());  
    List<double> dataSet = new List<double>(){};

  for (int i = HowLong; i>0; i--) //loop for getting the elements of the statistics
   {
      Console.WriteLine($"({i} remaining!) Write your number");
     double y = Convert.ToDouble(Console.ReadLine());
      dataSet.Add(y);
   }
    dataSet.Sort();
   double average = dataSet.Average();       //gets the average of the dataset
   double median = dataSet[dataSet.Count/2]; //gets the median of the dataset

   double MeanDeviator(int bessel)
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

    Console.WriteLine($"For the set of data {string.Join(" ", dataSet)}:");

    Console.WriteLine($"The average is {average}");
    Console.WriteLine($"The mode is {mode}");
    Console.WriteLine($"The median is {median}");
    Console.WriteLine($"The mean deviation is {MeanDeviator(0)} ({MeanDeviator(1)} with Bessel's correction)");
    Console.WriteLine($"The largest number is {dataSet[^1]}");
    Console.WriteLine($"The smallest number is {dataSet[0]}");

    

    Console.WriteLine("Do you want to use it again ? (Y/N) (type 0 to go back to the opening menu)");
   string? YN = Convert.ToString(Console.ReadLine());
    if (YN is not null && YN is "Y") {onoff = true;}
    if (YN is not null && YN is "N") {onoff = false;}
    if (YN is "0") {programa();}
  }
 }

 static void SpecialCalc()
 {
  Console.WriteLine("Select the number of the wanted function");
  Console.WriteLine(@"
  1 - Pythagorean Theorem
  2 - Logarithm");
  string? Switcher = Convert.ToString(Console.ReadLine());

  switch (Switcher)
  {
    case "1":
    Console.WriteLine("Do you know the hipotenuse? (Y/N)");
    string? pytSwitcher = Convert.ToString(Console.ReadLine());
    double leg1 = 0; double leg2 = 0; double hip = 0;
      switch (pytSwitcher)
      {
        case "Y":
         Console.WriteLine("Write, respectively, the values of the known leg and the hipotenuse");
          leg1 = Convert.ToDouble(Console.ReadLine());
          hip  = Convert.ToDouble(Console.ReadLine());
          leg2 = Math.Sqrt((hip*hip) - (leg1*leg1));

         Console.WriteLine($"The second leg of {leg1}² + leg² = {hip}² is: {leg2}");
                  
        break;

        case "N":
         Console.WriteLine("Write the value of the two legs");
          leg1 = Convert.ToDouble(Console.ReadLine());
          leg2 = Convert.ToDouble(Console.ReadLine());
          hip = Math.Sqrt((leg1*leg1)+(leg2*leg2));

         Console.WriteLine($"The hipotenuse of {leg1}² + {leg2}² = hip² is: {hip}");
        break;
      }
    break;

    case "2":
    Console.WriteLine("Write the Logarithm and the Base");
     double LogX = Convert.ToDouble(Console.ReadLine()); //the result of the base powered by the logarithm 
     double LogBase = Convert.ToDouble(Console.ReadLine()); //the number to be powered by the logarithm to become X
    Console.WriteLine($"The Logarithm of {LogX} with a {LogBase} base is {Math.Log(LogX, LogBase)}");
    break;
  }
 }
 //Global Functions Below
 static void ClearLine(int pedro, int joao)
{
    Console.SetCursorPosition(0, Console.CursorTop - pedro);
    Console.Write(new string(' ', Console.WindowWidth));
    Console.SetCursorPosition(0, Console.CursorTop - joao);
}
