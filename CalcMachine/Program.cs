  static void programa()
  {
        Console.WriteLine("Select the type of calculator you want to use");
    Console.WriteLine(@"
      1-Arithmetic 
      2-Trigonometric
      3-Geometric
      9-Special");

    string CalculatorCore = Console.ReadLine() ?? "1";

    switch(CalculatorCore)

    {
  case "1":
      Console.WriteLine("Write The Two Numbers you wish to calculate");

      double num1 = Convert.ToDouble(Console.ReadLine());
      double num2 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Select the number of the wanted Operation");
      Console.WriteLine(@"
        1-Addition         (x+y) 
        2-Subtraction      (x-y)
        3-Multiplication   (x*y) 
        4-Division         (x/y)
        5-Exponentiation   (x^y)
        6-Logarithm        (LogyX");

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
          float float1 = float.Parse(num1.ToString());
          float float2 = float.Parse(num2.ToString());
          Console.WriteLine($"The Result of {num1} / {num2} is {float1 / float2}");
          break;

      case "5":
          Console.WriteLine($"The Result of {num1} ^ {num2} is {Math.Pow(num1, num2)}");
          break;
      case "6":
          Console.WriteLine($"The Logarithm of {num1} with a {num2} base is {Math.Log(num1, num2)}");
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

      string SpecialTrig = Console.ReadLine() ?? "1";

      double double3 = double.Parse(num3.ToString());
      double radian3 = (double3 * (Math.PI)) / 180;
      

      switch(SpecialTrig) 
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
      Console.WriteLine("Select the type of Polygon you want to calculate");
      Console.WriteLine(@"
        1-Square
        2-Rectangle
        3-Triangle (Equilateral)
        4-Triangle (Isoceles) TO BE ADDED
        5-Triangle (Scalene) TO BE ADDED
        6-Hexagon
        ");

     string SpecialGeo = Console.ReadLine() ?? "1"; 

     switch (SpecialGeo)
     {
       case "1":
       Console.WriteLine("Write the length of the Side");

        double Side = Convert.ToDouble(Console.ReadLine());

       Console.WriteLine(@$"
        1-The Square has a Side of {Side}
        2-The Square has a area of {Side*Side}
        3-The Square has a diagonal of {Math.Sqrt(2*(Side*Side))}
        4-The Square has a apothem of {Side/2}
        ");
         
       break;

       case "2":
       Console.WriteLine("Write the length and the height of the Retangle");

        double RecLength = Convert.ToDouble(Console.ReadLine());   
        double RecHeight = Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine(@$"
        1-The Rectangle has a length of {RecLength} and a height of {RecHeight}
        2-The Rectangle has a area of {RecLength*RecHeight}
        3-The Rectangle has a diagonal of {Math.Sqrt((RecHeight*RecHeight)+(RecLength*RecLength))}
        ");  
       break;

       case "3":
       Console.WriteLine("Do you know the Side or the Height?");
       Console.WriteLine(@"
        1-Side
        2-Height");

       string EQSideOrHeight = Console.ReadLine() ?? "1";

       switch (EQSideOrHeight)
       {
         case "1":
       Console.WriteLine("Write the length of the Side");

        double EQTriSide = Convert.ToDouble(Console.ReadLine());

       Console.WriteLine(@$"
        1-The length of the side is {EQTriSide}
        2-The height of the triangle is {(Math.Sqrt(3)*(EQTriSide))/2}
        3-The area of the triangle is {(Math.Sqrt(3)*(EQTriSide*EQTriSide)/4)}  
        4-The apothem of the triangle is {(Math.Sqrt(3)*(EQTriSide))/6} ");      
        break;

         case "2":
       Console.WriteLine("Write the height of the triangle");

        double EQTriHeight = Convert.ToDouble(Console.ReadLine());

       Console.WriteLine(@$"
        1-The height of the triangle is {EQTriHeight}
        2-The length of the side is {(2*(Math.Sqrt(3)*EQTriHeight))/3}
        3-The area of the triangle is {(((2*(Math.Sqrt(3)*EQTriHeight))/3)*(EQTriHeight))/2} 
        4-The apothem of the triangle is {EQTriHeight/3}"); 
        break;

       }
      
      break;  
      case "6":
      Console.WriteLine("Do you know the Side, the Height or the Apothem?");
       Console.WriteLine(@"
        1-Side
        2-Height
        3-Apothem");

      string HexSideOrHeight = Console.ReadLine() ?? "1";  

      switch (HexSideOrHeight)
      {

        case "1":
        
       Console.WriteLine("Write the length of the side of the hexagon");

        double HexSide = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(@$"
        1-The side of the hexagon is {HexSide}
        2-The height of the hexagon is {(Math.Sqrt(3)*HexSide)}
        3-The area of the hexagon is {(Math.Sqrt(3)*((HexSide*HexSide)*3))/2} 
        4-The apothem of the hexagon is {(Math.Sqrt(3)*HexSide)/2}"); 
        break;

        case "2":
       Console.WriteLine("Write the height of the hexagon");

        double HexHeight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(@$"
        1-The side of the hexagon is {(Math.Sqrt(3)*HexHeight)/3}
        2-The height of the hexagon is {HexHeight}
        3-The area of the hexagone is {((Math.Sqrt(3)*((Math.Sqrt(3))*(HexHeight))/3)*(((Math.Sqrt(3))*(HexHeight))))/2} 
        4-The apothem of the hexagon is {HexHeight/2}"); 
        break;

        case "3":
       Console.WriteLine("Write the apothem of the hexagon");

        double HexApo= Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(@$"
        1-The side of the hexagon is {(Math.Sqrt(3)*HexApo*2)/3}
        2-The height of the hexagon is {2*HexApo}
        3-The area of the hexagone is {(((Math.Sqrt(3)*HexApo*2)/3)*((Math.Sqrt(3)*HexApo*2)/3)*3)/2} 
        4-The apothem of the hexagon is {HexApo}"); 
        break;
      }



      break;    
     }
  

  break;
  case "9":
      Console.WriteLine("Write the Number you will use");
      
      int num4 = Convert.ToInt32(Console.ReadLine());
      
      double double4 = double.Parse(num4.ToString());

      Console.WriteLine("Select the number of the wanted function");
      Console.WriteLine(@"
        1-Inverse (1/x)");

    string SpecialSpecial = Console.ReadLine() ?? "1";       

      switch(SpecialSpecial)
      {

        case "1":

        Console.WriteLine($"The Inverse of {num4} is {1f/num4}");
        break;
        default:
        Console.WriteLine("Invalid Operation");
        break;
      }

    break;
    }
    Console.ReadLine();
  
  programa();

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
programa();
    /*Very special thanks to my friend Victória (EternalQuasar0206) for helping me with the refactoring
    the code and by guiding and explaining some of the features needed to implement some of my ideas*/
