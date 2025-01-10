using System.Collections.Generic;
using static ConsoleApp2.Program;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var Lister = new List();
            var Perc = new Per();
            Console.WriteLine("Starting Percentage:");
            Perc.Percentage();
            Console.WriteLine("\nStarting List:");
            Lister.Apple();



        }
    }
internal class List
{

    public void Apple()
    {
            var Lister = new List();

            List<string> lst = new List<string>();

            // Read three lines of input from the user and add them to the list
            lst.Add(Console.ReadLine());
            lst.Add(Console.ReadLine());
            lst.Add(Console.ReadLine());

            // Print out each item in the list as a word
            foreach (string word in lst)
            {
                Console.WriteLine(word);  // Print each word on a new line

    }
}

internal class Per
{

    public void Percentage()
    {
            var Perc = new Per();

            Console.WriteLine("Insert Number");
        string tree = Console.ReadLine();
        double value1 = int.Parse(tree);
        Console.WriteLine("Insert Percentage");
        string grass = Console.ReadLine();
        double value2 = int.Parse(grass);
        Console.WriteLine("Result");
        Console.WriteLine(value1 * value2 / 100);












    }

    }
}
































