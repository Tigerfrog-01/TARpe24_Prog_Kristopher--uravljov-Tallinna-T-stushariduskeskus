using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Transactions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var CircleCalc = new Circle();
          
         
            Console.WriteLine("Starting CircleCalc:");
            CircleCalc.Circle1();
            










        }
    }
}

internal class Circle
{

    public void Circle1()
    {

        double diameter = 72;
        double radius = diameter / 2;
        double area = 3.14 * radius;
        Console.WriteLine(area);





















    }
}