// See https://aka.ms/new-console-template for more informati



using System.ComponentModel;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Sorted
{
    static void Main(string[] args)
    {
       
    {

            Console.WriteLine("--------------------------------------------------------------------------");
            string tree = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------");
            int value1 = int.Parse(tree);

            if (value1 < 500)
            {
                Console.WriteLine(value1);
            }
            else if (value1 > 500 && value1 < 799)
            {
                Console.WriteLine("tax");
            }

            else if (value1 > 799)
            {
                Console.WriteLine("More Tax");
            }
            Console.WriteLine("--------------------------------------------------------------------------");

        }

        static void Add2Numbers(int value1)
        {
            // Implement the logic for adding 2 numbers here and print
            Console.WriteLine($"Sum of 2 numbers: {value1* 0,2}");
        }

















    }
    }
