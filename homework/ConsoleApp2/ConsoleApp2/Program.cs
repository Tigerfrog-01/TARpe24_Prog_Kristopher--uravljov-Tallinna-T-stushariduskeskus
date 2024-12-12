using static ConsoleApp2.Program;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string W = Console.ReadLine();
            string S = Console.ReadLine();
            int input = int.Parse(W);
            int input1 = int.Parse(S);
            //Console.WriteLine($"Sum of 2 numbers: {input1 + input}");
            Add2Numbers(input, input1);
            Console.WriteLine($"S: {input * input1}");
            Console.WriteLine($"P: {2 * (input + input1)}");
            
        }

        static public void Add2Numbers(int input, int input1)
        {
            // Implement the logic for adding 2 numbers here and print
            Console.WriteLine($"S: {input * input1}");
            Console.WriteLine($"P: {2 * (input + input1) }");
        }



    }
    }

























    


