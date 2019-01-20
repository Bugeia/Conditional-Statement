using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            try
            {
                string input = Console.ReadLine();
                int year = int.Parse(input);

                if (year < 18)
                {
                    Console.WriteLine("Minor.");
                }
                else if ((year > 17) && (year < 65))
                {
                    Console.WriteLine("Adult.");
                }
                else
                {
                    Console.WriteLine("Senior.");
                }
            }// end of try
            catch
            {
                Console.WriteLine("Please enter an integer.");
                Console.ReadKey(true);
            }// end of catch
        }
    }
}
