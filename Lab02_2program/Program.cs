using System;

namespace Lab02_2program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Write number of terms");
                int denominator = 1;
                int num_terms = Int32.Parse(Console.ReadLine());
                double Pi_4 = 0.0;
                for (int i = 0; i < num_terms; i++)
                {
                    if (i % 2 == 0)
                    {
                        Pi_4 += (double)1 / denominator;
                    }
                    else
                    {
                        Pi_4 -= (double)1 / denominator;
                    }
                    denominator += 2;
                }
                double Pi = 4 * Pi_4;
                Console.WriteLine($"Number Pi equals {Pi}");
                Console.ReadKey();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error.. Try again");
                Console.ReadKey();
                Program.Main(args);
            }
        }
    }
}
