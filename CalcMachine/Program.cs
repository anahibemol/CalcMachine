Console.WriteLine("Select the type of calculator you want to use");
Console.WriteLine(@"
  1-Arithmetic 
  2-Trigonometric
  3-Special");

string CalculatorCore = Console.ReadLine() ?? "1";

switch(CalculatorCore)

{
case "1":
  Console.WriteLine("Write The Two Numbers you wish to calculate");

  double num1 = Convert.ToDouble(Console.ReadLine());
  double num2 = Convert.ToDouble(Console.ReadLine());

  Console.WriteLine("Select the number of the wanted operation");
  Console.WriteLine(@"
    1-Addition       (x+y) 
    2-Subtraction    (x-y)
    3-Multiplication (x*y) 
    4-Division       (x/y)
    5-Exponentiation (x^y)");

  string operation = Console.ReadLine() ?? "1";

  switch(operation) 
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
      float float1 = float.Parse(num1.ToString());
      float float2 = float.Parse(num2.ToString());
      Console.WriteLine($"The Result of {num1} / {num2} is {float1 / float2}");
      break;

   case "5":
      Console.WriteLine($"The Result of {num1} ^ {num2} is {Math.Pow(num1, num2)}");
      break;

  default:
    Console.WriteLine("Invalid option");
    break;
  }
break;
case "2":
  Console.WriteLine("Write the value of the angle");

  int num3 = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Select the number of the wanted trigonometric function");
  Console.WriteLine(@"
    1-Sine (Sin)       
    2-Cosine (Cos)
    3-Tangent (Tan)
    4-Cosecant (Cossec)
    5-Secant (Sec)
    6-Cotangent (Cotan)
    7-All");

  string TrigonometricFunction = Console.ReadLine() ?? "1";

  double double3 = double.Parse(num3.ToString());
  double radian3 = (double3 * (Math.PI)) / 180;
  

  switch(TrigonometricFunction) 
  {

    case "1":
    Console.WriteLine($"The Sine of {double3} is {Math.Sin(radian3)}");
    break;

    case "2":
    Console.WriteLine($"The Cosine of {double3} is {Math.Cos(radian3)}");
    break;

    case "3":
    Console.WriteLine($"The Tangent of {double3} is {Math.Tan(radian3)}");
    break;

    case "4":
    Console.WriteLine($"The Cosecant of {double3} is {1/(Math.Sin(radian3))}");
    break;

    case "5":
    Console.WriteLine($"The Secant of {double3} is {1/(Math.Cos(radian3))}");
    break;

    case "6":
    Console.WriteLine($"The Coangent of {double3} is {1/(Math.Tan(radian3))}");
    break;
        
    case "7":
    Console.WriteLine($"The Sine of {double3} is {Math.Sin(radian3)}");
    Console.WriteLine($"The Cosine of {double3} is {Math.Cos(radian3)}");
    Console.WriteLine($"The Tangent of {double3} is {Math.Tan(radian3)}");
    Console.WriteLine($"The Cosecant of {double3} is {1/(Math.Sin(radian3))}");
    Console.WriteLine($"The Secant of {double3} is {1/(Math.Cos(radian3))}");
    Console.WriteLine($"The Coangent of {double3} is {1/(Math.Tan(radian3))}");
    break;
  }

break;
case "3":
  Console.WriteLine("Write the Number you will use");
  
  int num4 = Convert.ToInt32(Console.ReadLine());
  
  double double4 = double.Parse(num4.ToString());

  Console.WriteLine("Select the number of the wanted function");
  Console.WriteLine(@"
    1-Inverse (1/x)");

string Special = Console.ReadLine() ?? "1";       

   switch(Special)
   {

    case "1":

    Console.WriteLine($"The Inverse of {num4} is {1f/num4}");
    break;
   }

break;
}
Console.ReadLine();
/*Very special thanks to my friend Victória (EternalQuasar0206) for helping me with the refactoring
the code and by guiding and explaining some of the features needed to implement some of my ideas*/
