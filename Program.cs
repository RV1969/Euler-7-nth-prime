using System;

namespace Euler0007
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime(int number)
            {
                if (number == 1) return false;
                if (number < 4) return true;
                if ((number % 2) == 0) return false;
                if (number < 9) return true;
                if ((number % 3) == 0) return false;

                var limit = Math.Ceiling(Math.Sqrt(number)); //Limiet

                for (int i = 5; i <= limit; i+=6)
                {
                    if (number % i == 0) return false;
                    if (number % (i + 2)==0) return false;
                }

                return true;
            }

            Console.WriteLine("Input n and I will try to find the nth Prime.");
            Console.WriteLine();
            var Foo = Console.ReadLine();
            if (int.TryParse(Foo, out int Max))
            {
                Console.WriteLine();
                Console.WriteLine("Please wait...");
                var watch = System.Diagnostics.Stopwatch.StartNew();
                int Num = 1; //tellertje

                for (int x = 1; ; x++)
                {
                    if (isPrime(x))
                    {
                        
                        if (Num == Max)
                        {
                            Console.WriteLine();
                            Console.Write("Prime sequence number " + Convert.ToString(Num) + ": " + Convert.ToString(x));
                            Console.WriteLine();
                            Console.WriteLine();
                            string elapsedMs = watch.ElapsedMilliseconds.ToString();
                            Console.WriteLine("That took me " + elapsedMs + " milliseconds.");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to exit");
                            Console.ReadKey();
                            break;
                        }
                        Num++;
                    }
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Not a number");
                Console.WriteLine();
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();                
            }            
        }
    }
}
