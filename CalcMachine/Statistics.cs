namespace CalcMachine
{
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
                    Programa.MainMenu();
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

}