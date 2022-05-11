Console.WriteLine("Select the type of calculator you want to use");
Console.WriteLine(@"
  1-Arithmetic 
  2-Trigonometric");

string CalculatorCore = Console.ReadLine() ?? "1";

switch(CalculatorCore)

{
case "1":
  Console.WriteLine("Select The Two Numbers you wish to calculate");

  int num1 = Convert.ToInt32(Console.ReadLine());
  int num2 = Convert.ToInt32(Console.ReadLine());

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
      int res = num1 + num2;
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
    1-Sine       
    2-Cosine   
    3-Tangent
    4-Cosecant
    5-Secant
    6-Cotangent");

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
  }

break;
}
Console.ReadLine();
/*Very special thanks to my friend Victória (EternalQuasar0206) for helping me with the refactoring
the code and by guiding and explaining some of the features needed to implement some of my ideas*/
