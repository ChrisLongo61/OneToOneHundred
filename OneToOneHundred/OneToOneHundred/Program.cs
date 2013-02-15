using System;

namespace OneToOneHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = string.Empty;
            for (int number = 1; number < 101; number++)
            {
                if (number % 3 == 0)
                {
                    output = "Modern";
                }
                if (number % 5 == 0)
                {
                    output += "Medical";
                }
                if (string.IsNullOrEmpty(output))
                {
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine(output);
                    output = string.Empty;
                }
            }
        }
    }
}
