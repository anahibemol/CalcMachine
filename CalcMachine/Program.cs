Console.WriteLine("Select The Two Numbers you wish to calculate");

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Select the number of the wanted operation");
Console.WriteLine(@"
  1-Addition  
  2-Subtraction  
  3-Multiplication  
  4-Division
  5-Exponentiation");

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
Console.ReadLine();
/*Very special thanks to my friend Victória (EternalQuasar0206) for helping me with the refactoring
the code and by guiding and explaining some of the features needed to implement some of my ideas*/
