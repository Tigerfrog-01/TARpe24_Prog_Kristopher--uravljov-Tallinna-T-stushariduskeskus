using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace ProgTask1
{
    internal class Program
    {
static void Main(string[] args)
        {
            Console.WriteLine("Insert 10 10 for skip");
            Console.WriteLine("Starting Combining");
            string uservalue = Console.ReadLine();
            string uservalue2 = Console.ReadLine();


            
           int num1 = int.Parse(uservalue);
            int num2 = int.Parse(uservalue2);
            Console.WriteLine(num1 + num2);
            var Programm = new Calc();
            Programm.Run();
           
        }

    }
    internal class Calc {

        public void Run()
        {
            var Programm = new Calc();

            Console.WriteLine("Starting Divding");
             string uservalue3 = Console.ReadLine();
            string uservalue4 = Console.ReadLine();


            int num1 = int.Parse(uservalue3);
            int num2 = int.Parse(uservalue4);          
            Console.WriteLine(num1 / num2);

            Console.WriteLine("Starting Multiplying");
            string uservalue6 = Console.ReadLine();
            string uservalue7 = Console.ReadLine();
            int num3 = int.Parse(uservalue6);
            int num4 = int.Parse(uservalue7);
            Console.WriteLine(num3 * num4);        

            Console.WriteLine("Starting Substraction");
            string uservalue8 = Console.ReadLine();
            string uservalue9 = Console.ReadLine();
            int num5 = int.Parse(uservalue8);
            int num6 = int.Parse(uservalue9);
            Console.WriteLine(num5 - num6);

        }

    }
}



    