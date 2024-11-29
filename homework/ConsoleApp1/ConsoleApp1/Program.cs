using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to quiz with 3 questions");
            Console.WriteLine("Number 1: Wich answer is true about Napoleon Bonaparte");
            Console.WriteLine("A: He was French");
            Console.WriteLine("B: He was Italian");
            Console.WriteLine("C: He was German");
            Console.WriteLine("--------------------------------------------------------------------------");          
          

            string input = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------");
            if (input == "2")
            {
                Console.WriteLine("You are indeed correct, even if he borned in Corsica he had Italian roots!");
            }

            else
            {
                Console.WriteLine("you are not correct, 2 is Valid answer!!!");
               
                

            }




            Console.WriteLine("--------------------------------------------------------------------------");


        }

    }
}

        









