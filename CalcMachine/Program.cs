using static System.Int32;

  static void programa()
  {
        
    Console.WriteLine("Select the type of calculator you want to use");
    Console.WriteLine(@"
      1-Arithmetic 
      2-Trigonometric
      3-Geometric
      4-Algebraic
      5-Function
      6-Statistics WIP
      9-Special");

    string CalculatorCore = Console.ReadLine() ?? "1";
    
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
    AlgebraCalc();
  break;
 case "5":
    FunctionCalc();
  break;
 case "6":
    StatCalc();
  break;
 case "9":
    SpecialCalc();
  break;
    }

  }

programa();

UseAgain();

static void ArithmeticCalc()
{
 Console.WriteLine("Write The Two Numbers you wish to calculate");
 
 double num1 = Convert.ToDouble(Console.ReadLine());
 double num2 = Convert.ToDouble(Console.ReadLine());
 
 Console.WriteLine("Select the number of the wanted Operation");
 Console.WriteLine(@"
   1 - Addition         (x+y) 
   2 - Subtraction      (x-y)
   3 - Multiplication   (x*y) 
   4 - Division         (x/y)
   5 - Exponentiation   (x^y)");
 string SpecialArit = Console.ReadLine() ?? "1";

   switch(SpecialArit) 
   {
 case "1":
    double res = num1 + num2;
    Console.WriteLine($"The Result of {num1} + {num2} is {res}");
   break;
 case "2":
    Console.WriteLine($"The Result of {num1} - {num2} is {num1 - num2}");
    break;
 case "3":
    Console.WriteLine($"The Result of {num1} * {num2} is {num1 * num2}");
    break;
 case "4":
    Console.WriteLine($"The Result of {num1} / {num2} is {num1 / num2}");
    break;
 case "5":
    Console.WriteLine($"The Result of {num1} ^ {num2} is {Math.Pow(num1, num2)}");
    break;
 default:
    Console.WriteLine("Invalid option");
    break;

 }
}

static void TrigonometricCalc()
{
   Console.WriteLine("Write the value of the angle");
   int num1 = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Select the number of the wanted trigonometric function");
   Console.WriteLine(@"
     1 - Sine (Sin)       
     2 - Cosine (Cos)
     3 - Tangent (Tan)
     4 - Cosecant (Cossec)
     5 - Secant (Sec)
     6 - Cotangent (Cotan)
     7 - All");
   string SpecialTrig = Console.ReadLine() ?? "1";
   double radian3 = (num1 * (Math.PI)) / 180; //converts the angle to radians
   
   switch(SpecialTrig) 
   {
 case "1":
   Console.WriteLine($"The Sine of {num1} is {Math.Sin(radian3)}");
   break;
 case "2":
   Console.WriteLine($"The Cosine of {num1} is {Math.Cos(radian3)}");
   break;
 case "3":
   Console.WriteLine($"The Tangent of {num1} is {Math.Tan(radian3)}");
   break;
 case "4":
   Console.WriteLine($"The Cosecant of {num1} is {1/(Math.Sin(radian3))}");
   break;
 case "5":
   Console.WriteLine($"The Secant of {num1} is {1/(Math.Cos(radian3))}");
   break;
 case "6":
   Console.WriteLine($"The Coangent of {num1} is {1/(Math.Tan(radian3))}");
   break;
       
   case "7":
   Console.WriteLine($"The Sine of {num1} is {Math.Sin(radian3)}");
   Console.WriteLine($"The Cosine of {num1} is {Math.Cos(radian3)}");
   Console.WriteLine($"The Tangent of {num1} is {Math.Tan(radian3)}");
   Console.WriteLine($"The Cosecant of {num1} is {1/(Math.Sin(radian3))}");
   Console.WriteLine($"The Secant of {num1} is {1/(Math.Cos(radian3))}");
   Console.WriteLine($"The Coangent of {num1} is {1/(Math.Tan(radian3))}");
   break;
 }
}

static void PolygonCalc()
{
  Console.WriteLine("Select the type of Polygon you want to calculate");
  Console.WriteLine(@"
    1 - Square
    2 - Rectangle
    3 - Triangle (Equilateral)
    4 - Triangle (Isoceles)
    5 - Circle
    6 - Hexagon
    ");
 string SpecialGeo = Console.ReadLine() ?? "1"; 
 switch (SpecialGeo)
 {
   case "1":
   static void SquareCalc()
   {
   Console.WriteLine("Write the length of the Side");
    double Side = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine(@$"
    1-The Square has a Side of {Side}
    2-The Square has a area of {Side*Side}
    3-The Square has a diagonal of {Math.Sqrt(2*(Side*Side))}
    4-The Square has a apothem of {Side/2}
    ");
   }
   SquareCalc();
   break;
   case "2":
   static void RectangleCalc()
   {
   Console.WriteLine("Write the length and the height of the Retangle");
    double Length = Convert.ToDouble(Console.ReadLine());   
    double Height = Convert.ToDouble(Console.ReadLine()); 
   Console.WriteLine(@$"
    1-The Rectangle has a length of {Length} and a height of {Height}
    2-The Rectangle has a area of {Length*Height}
    3-The Rectangle has a diagonal of {Math.Sqrt((Height*Height)+(Length*Length))}");  
   }
   RectangleCalc();
   break;
   case "3":
   static void EQCalc()
   {
   Console.WriteLine("Write the known length (Side or Height)");
    double EQVar = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine(@"Is it the length of the Side or the Height ?
    1 - Side
    2 - Height");
   string EQSwitcher = Console.ReadLine() ?? "1";
   switch (EQSwitcher)
   {
   case "1":
    static void EQSide(double num1)
    {
    Console.WriteLine(@$"
    1-The length of the side is {num1}
    2-The height of the triangle is {(Math.Sqrt(3)*(num1))/2}
    3-The area of the triangle is {(Math.Sqrt(3)*(num1*num1)/4)}  
    4-The apothem of the triangle is {(Math.Sqrt(3)*(num1))/6} ");           
    }
     EQSide(EQVar);
    break;
   case "2":
    static void EQHeight(double num1)
    {
    Console.WriteLine(@$"
    1-The height of the triangle is {num1}
    2-The length of the side is {(2*(Math.Sqrt(3)*num1))/3}
    3-The area of the triangle is {(((2*(Math.Sqrt(3)*num1))/3)*(num1))/2} 
    4-The apothem of the triangle is {num1/3}"); 
    }
    EQHeight(EQVar);
    break;
   }        
}
    EQCalc();
  break;
 case "4":
  static void IsoCalc()
  {
  Console.WriteLine("Write the length of the base and the legs");
    double IsoBase = Convert.ToDouble(Console.ReadLine());
    double IsoLength = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(@$"
    1-The height of the triangle is {Math.Sqrt((IsoLength*IsoLength)-(IsoBase*IsoBase)/4)}
    2-The area of the triangle is {(IsoBase/4)*(Math.Sqrt(4*(IsoLength*IsoLength)-(IsoBase*IsoBase)))}");
  }
  IsoCalc();
  break;
 case "5":
  static void CircCalc()
  {
  Console.WriteLine("Write the known value of the circle (can be Radius, Circunference or Area)");
  double CircVar = Convert.ToDouble(Console.ReadLine()); 
   Console.WriteLine(@"Write 
    1 - Radius
    2 - Circunference
    3 - Area");
    string CircSwitcher = Console.ReadLine() ?? "1";
    switch (CircSwitcher)
    {
      case "1":
     Console.WriteLine(@$"
    1-The Radius is {CircVar}
    2-The Diameter is {CircVar*2}
    3-The length of the Circunference is {(2*Math.PI)*CircVar}
    4-The Area of the Circle is {Math.PI*(CircVar*CircVar)}");          
      break;
      case "2":
       
     Console.WriteLine(@$"
    1-The Radius is {CircVar/(2*(Math.PI))}
    2-The Diameter is {CircVar/(Math.PI)}
    3-The length of the Circunference is {CircVar}
    4-The Area of the Circle is {Math.PI*((CircVar/(2*(Math.PI)))*(CircVar/(2*(Math.PI))))}");
                 
      break;
      case "3":
     Console.WriteLine(@$"
    1-The Radius is {Math.Sqrt(CircVar/Math.PI)}
    2-The Diameter is {2*(Math.Sqrt(CircVar/Math.PI))}
    3-The length of the Circunference is {2*(Math.Sqrt(CircVar/Math.PI))*Math.PI}
    4-The Area of the Circle is {CircVar}");        
      break;
  }
    }
  CircCalc();
  break;
 case "6":
  static void HexCalc()
  {
  Console.WriteLine("Write the length of the known value (can be the Side, the Height or the Apothem)");
  double HexVar = Convert.ToDouble(Console.ReadLine()); 
   Console.WriteLine(@"Is it the length of the Side, Height or the Apothem
    1 - Side
    2 - Height
    3 - Apothem");
  string HexSideOrHeight = Console.ReadLine() ?? "1";  
  switch (HexSideOrHeight)
  {
    case "1":
    Console.WriteLine(@$"
    1-The side of the hexagon is {HexVar}
    2-The height of the hexagon is {(Math.Sqrt(3)*HexVar)}
    3-The area of the hexagon is {(Math.Sqrt(3)*((HexVar*HexVar)*3))/2} 
    4-The apothem of the hexagon is {(Math.Sqrt(3)*HexVar)/2}"); 
    break;
    case "2":
    Console.WriteLine(@$"
    1-The side of the hexagon is {(Math.Sqrt(3)*HexVar)/3}
    2-The height of the hexagon is {HexVar}
    3-The area of the hexagon is {((Math.Sqrt(3)*((Math.Sqrt(3))*(HexVar))/3)*(((Math.Sqrt(3))*(HexVar))))/2} 
    4-The apothem of the hexagon is {HexVar/2}"); 
    break;
    case "3":
    Console.WriteLine(@$"
    1-The side of the hexagon is {(Math.Sqrt(3)*HexVar*2)/3}
    2-The height of the hexagon is {2*HexVar}
    3-The area of the hexagon is {(((Math.Sqrt(3)*HexVar*2)/3)*((Math.Sqrt(3)*HexVar*2)/3)*3)/2} 
    4-The apothem of the hexagon is {HexVar}"); 
    break;
  }
 }
  HexCalc();
  break;    
 }

}

static void AlgebraCalc()
{
  Console.WriteLine("Select the number of the wanted function");
  Console.WriteLine(@"
    1-Quadratic Formula     (a(X²) + b(X) + c = 0)
    2-Logarithm             (LogyX)
    3-Pythagorean Theorem   (A² + B² = C²)
    4-Distance of Two Points
    5-Midpoint Formula
    6-Slope");
  string SpecialAlgebra = Console.ReadLine() ?? "1";   
  switch (SpecialAlgebra)    
   {
     case "1":
     static void QuadraticFormula()
  {
     Console.WriteLine("Write the a, b and c of your a(X²) + b(X) + c = 0 expression");
    double QuadraticA = Convert.ToDouble(Console.ReadLine());   
    double QuadraticB = Convert.ToDouble(Console.ReadLine());
    double QuadraticC = Convert.ToDouble(Console.ReadLine());
     double Δ = (QuadraticB*QuadraticB) - 4*((QuadraticA)*(QuadraticC)); //obtain the delta for the formula
     
     Console.WriteLine($"Your Delta is {Δ}");
    if (Δ >= 0)
    {
     double QuadraticRoot1 = (-QuadraticB+Math.Sqrt(Δ))/2*QuadraticA; //in case the ± is +
     double QuadraticRoot2 = (-QuadraticB-Math.Sqrt(Δ))/2*QuadraticA; //in case the ± is -
     if (Δ == 0) {Console.WriteLine($"Therefore, your X is {QuadraticRoot1}");} // exception
     else {Console.WriteLine($"Therefore, your X is either {QuadraticRoot1} (+) or {QuadraticRoot2} (-)");}
    }
  }
     QuadraticFormula();
     break;
    case "2":
     static void Log()
     {
     double LogX = Convert.ToDouble(Console.ReadLine()); //the result of the base powered by the logarithm 
     double LogBase = Convert.ToDouble(Console.ReadLine()); //the number to be powered by the logarithm to become X
      Console.WriteLine($"The Logarithm of {LogX} with a {LogBase} base is {Math.Log(LogX, LogBase)}");
     }
      Console.WriteLine("Write the Logarithm and the Base");
     Log();
     break;
    case "3":
     static void Pythagoras()
     {
      Console.WriteLine("Do you know the B or the C ?");
      Console.WriteLine(@"
      1-B
      2-C");
      string Pyt = Console.ReadLine() ?? "1";   
      switch (Pyt)
      {
       case "1":
         Console.WriteLine("Write the A and B values");
     double PytA = Convert.ToDouble(Console.ReadLine());   
     double PytB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The C hypotenuse of the expression is {Math.Sqrt(PytA*PytA + PytB*PytB)}");           
        break;
       case "2":
         Console.WriteLine("Write the A and C values");
     double PythA = Convert.ToDouble(Console.ReadLine());   
     double PythC = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine($"The B Leg of the expression is {Math.Sqrt(PythC*PythC - PythA*PythA)}");
        break;
      }
     }
     Pythagoras();
     break;
    case "4":
     static void TwoPoints()
     {
      Console.WriteLine("Determine the X and Y coordinates of the first point");
       double Dif_1stX = Convert.ToDouble(Console.ReadLine());
       double Dif_1stY = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Now, do the same for the second point");
       double Dif_2ndX = Convert.ToDouble(Console.ReadLine());
       double Dif_2ndY = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine(@$"The distance between the two points is:
      {Math.Sqrt((Dif_2ndX - Dif_1stX)*(Dif_2ndX - Dif_1stX) + (Dif_2ndY - Dif_1stY)*(Dif_2ndY - Dif_1stY))}");  
     }
     TwoPoints();
     break;
    case "5":
     static void Midpoint()
     {
      Console.WriteLine("Determine the X and Y coordinates of the first point");
       double Mid_1stX = Convert.ToDouble(Console.ReadLine());
       double Mid_1stY = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Now, do the same for the second point");
       double Mid_2ndX = Convert.ToDouble(Console.ReadLine());
       double Mid_2ndY = Convert.ToDouble(Console.ReadLine());  
      Console.WriteLine($"The midpoint X is  {(Mid_1stX+Mid_2ndX)/2}");
      Console.WriteLine($"The midpoint Y is: {(Mid_1stY+Mid_2ndY)/2}"); 
     }
     Midpoint();  
     break;
    case "6":
     static void Slope()
     {
      Console.WriteLine("Determine the highest X and Y of the line");
       double SlopeMaxX = Convert.ToDouble(Console.ReadLine());
       double SlopeMaxY = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Now, do the same for the lowest X amd Y");
       double SlopeMinX = Convert.ToDouble(Console.ReadLine());
       double SlopeMinY = Convert.ToDouble(Console.ReadLine()); 
       
      Console.WriteLine($"the incline is of a ratio of {(SlopeMaxY-SlopeMinY)/(SlopeMaxX-SlopeMinX)}");
     }
     Slope();
     break;         
   }
}

static void FunctionCalc()
{
  Console.WriteLine("The function calculator works a little different from the others, please write the");
  Console.WriteLine("a, b and c of the format: f(x) = a(x²) + b(x) + c  , the system will discover the type");
    double FA = Convert.ToDouble(Console.ReadLine());
    double FB = Convert.ToDouble(Console.ReadLine()); 
    double FC = Convert.ToDouble(Console.ReadLine()); 
    static void Function(double A, double B, double C)
    {
      if  (A is 0 && B is 0) //case for function without x
      {
        Console.WriteLine("Your Function is Constant, therefore:");
        Console.WriteLine($"y = f(x) = {C}");
      }
      else if (A is 0) //case for function without x²
      {
        Console.WriteLine("Your Function is Linear, therefore:");
        Console.WriteLine($"y = f(x) = {B}x + {C}");
        Console.WriteLine("Which is your x?");
        double X = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"at x = {X}, the y coordinate is {(B*X) + C}");
      }
      else if (A is not 0) //
      {
        Console.WriteLine("Your Function is Quadratic");
        Console.WriteLine($"y = f(x) = {A}x² + {B}x  + {C}");
        Console.WriteLine("Which is your x?");
        double X = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"at x = {X}, the y coordinate is {(A*(X*X))+(B*X)+C}");
        double XVert = -1*(B/(2*A));
        double YVert = -1*(((B*B)-4*(A*C))/4*A); 
        Console.WriteLine($"And, by consequence, the X Vertex is {XVert} and the Y Vertex is {YVert}");
      }
    }
    Function(FA, FB, FC);
}

static void SpecialCalc()
{
  Console.WriteLine("Select the number of the wanted function");
  Console.WriteLine(@"
    1-Inverse (1/x)
    2-Rule of 3(a->c)
               (b->x)");
string SpecialSpecial = Console.ReadLine() ?? "1";       
  switch(SpecialSpecial)
  {
    case "1":
  Console.WriteLine("Write the Number you will use");
  
  double num4 = Convert.ToDouble(Console.ReadLine());
  
    Console.WriteLine($"The Inverse of {num4} is {1f/num4}");
    break;
    case "2":
    Console.WriteLine("Write the A, B and C of the rule of 3 as in the format shown in the menu");
    double Rule3A = Convert.ToDouble(Console.ReadLine());
    double Rule3B = Convert.ToDouble(Console.ReadLine());
    double Rule3C = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(@$"The Rule of 3 is {Rule3A}----->{Rule3C}
             {Rule3B}----->{RuleOf3(Rule3A, Rule3B, Rule3C)}");
    break;
    default:
    Console.WriteLine("Invalid Operation");
    break;
  }
}

static void StatCalc()
{
 Console.WriteLine("Write how many elements the set of data has");
 
  int HowLong = Convert.ToInt32(Console.ReadLine());

  List<double> numberList = new List<double>() {};

  for(int i = HowLong; i > 0; i--)
{
    Console.WriteLine($"({i} remaining!) Write your a number");
    double y = Convert.ToDouble(Console.ReadLine());
    numberList.Add(y);
}
numberList.Sort();
double average = numberList.Average();
numberList.Count();//gets the size of the List (to avoid cause problems by changing it or howlong)

 double MeanDeviator() //Still not working
{

  double sum = 0;

  double MeanDeviation = 0;
  foreach (var item in numberList)
  {
   sum = (Math.Pow(item + average, 2))/numberList.Count;
  }

  MeanDeviation = sum;
  return MeanDeviation;
}

Console.WriteLine($"the average of the {numberList.Count()} elements is: {average}");
Console.WriteLine($"The smallest number of the set is: {numberList.First()}");
Console.WriteLine($"And the largest number of the set is: {numberList.Last()}");
Console.WriteLine($"The set is: {string.Join(" ", numberList)}");
}

static double RuleOf3(double upperleft, double upperright, double lowerleft)
{
  double lowerright = (upperright*lowerleft)/upperleft;
  return (lowerright); 
}

static void ClearLine(int pedro)
{
    Console.SetCursorPosition(0, Console.CursorTop - pedro);
    Console.Write(new string(' ', Console.WindowWidth));
    Console.SetCursorPosition(0, Console.CursorTop);
}

static void UseAgain()
    {
    Console.ReadLine();
  
     Console.WriteLine("Do you want to use it again?");
     Console.WriteLine(@"
      1-Yes        
      2-No");

    string Special2 = Console.ReadLine() ?? "1"; 

    switch(Special2)
    {

      case "1":
      programa();
      break;
      default:
      Console.WriteLine("Closing");
      break;

    } 
  }
/*Very special thanks to my friend Victória (EternalQuasar0206) for helping me with the refactoring
the code during the early alpha and by guiding and explaining some of the features needed to implement 
some of my ideas*/
