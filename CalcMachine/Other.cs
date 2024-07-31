namespace CalcMachine
{
            public static class Other
        {
            public static void Prime()
            {
                Console.WriteLine("Write your number");
                    int num = Convert.ToInt32(Console.ReadLine() ?? "2");
                    for(int n = 2; n <= num; n++)
                    {                
                        int primecheck = 0;
                        for(int i = 1; i < n; i++)
                        {
                            if(n % i == 0) {primecheck = primecheck+1; }
                        }
                        if (primecheck > 1) {Console.WriteLine($"{n} is not prime"); }
                        else                {Console.WriteLine($"{n} is prime"); }
                    }
            }
        }

}