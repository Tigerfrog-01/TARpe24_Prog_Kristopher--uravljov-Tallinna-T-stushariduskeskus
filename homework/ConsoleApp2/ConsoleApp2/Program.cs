using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("True or False Quiz");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Platypus is mammal");
            Console.WriteLine("--------------------------------------------------------------------------");
            string input = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------");
            int value = 0;
            int value1 = 0;
            int value2 = value1;
            int value3 = value2;

            if (input == "true")
              
            {
                Console.WriteLine("You are correct, Fun fact even if it lays eggs its still mammal");
                value1 = value + 1;



            }

            else
            {
                Console.WriteLine("you are not correct, answer was true!");

               

            }
            
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Next Question, Was Petersburg named after Peter the first");
            Console.WriteLine("--------------------------------------------------------------------------");
            string input1 = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------");
            if (input1 == "true")
            {
                Console.WriteLine("You are correct, Peter the first wanted its own capital as its name");
                value2 = value1 + 1;

            }
            
            else
            {
                Console.WriteLine("you are not correct, answer was true!");
                
                

            }
            
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Next Question, Was Victoria the first, queen of England  170cm tall");
            Console.WriteLine("--------------------------------------------------------------------------");
            string input2 = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------");
            if (input2 == "false")
            {
                Console.WriteLine("You are correct, Victoria wasnt 170cm tall but 147cm tall");
                value3 = value2 + 1;
            }
            
            else
            {
                Console.WriteLine("you are not correct, answer was true!");
                
              
                }
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Total score is:");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(value3);
          
            }
        }
            }





