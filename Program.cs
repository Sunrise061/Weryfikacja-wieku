using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weryfikacja_wieku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double AGE;

            Console.WriteLine("Enter your age:");
            AGE = double.Parse(Console.ReadLine());

            if (AGE > 18)
            {
                Console.WriteLine("ACCES GRANTED",AGE);
                Console.ReadKey();
            }
            else if (AGE > 15)
            {
                Console.WriteLine("Do you have parental consent?");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                var a1 = double.Parse(Console.ReadLine());           
                if (a1 == 1)
                {
                    Console.WriteLine("ACCES GRANTED");
                    Console.ReadKey();
                }
                else if (a1 == 2)
                {
                    Console.WriteLine("ACCES DENIED");
                    Console.ReadKey();
                }

            }
            else if (AGE < 15) 
            {
                Console.WriteLine("ACCES DENIED");
                Console.ReadKey();
            }
            
        }
    }
}
