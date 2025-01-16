using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> lst = new List<string>();


            lst.Add(Console.ReadLine());
            lst.Add(Console.ReadLine());
            lst.Add(Console.ReadLine());
            lst.Add(Console.ReadLine());
            lst.Reverse();           
            Console.WriteLine("-----------------------------------------");


            foreach (string word in lst)
            {


                Console.WriteLine(word);

            }

            List<string> lst1 = new List<string>();

            Console.WriteLine("-----------------------------------------");
            lst1.Add(Console.ReadLine());
            lst1.Add(Console.ReadLine());
            lst1.Add(Console.ReadLine());
            lst1.Add(Console.ReadLine());
            lst1.Sort();
            Console.WriteLine("-----------------------------------------");


            foreach (string word in lst1)
            {


                Console.WriteLine(word);
            }












        }
        }
    }

