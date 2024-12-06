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


            var calculator = new Calc();
            var quizGame = new Quiz();
            var TrueorFalse = new TrueFalse();
            var Floater = new Floater();
            var Age = new Age();

            Console.WriteLine("Starting Calculator:");
            calculator.Run();
            Console.WriteLine("\nStarting Quiz Game:");
            quizGame.Run();
            Console.WriteLine("\nStarting True or False:");
            TrueorFalse.Run();
            Console.WriteLine("\nStarting Floating:");
            Floater.Run();
            Console.WriteLine("\nAge checking:");
            Age.Run();
        }

    }
    internal class Calc {

        public void Run()
        {
            var Programm = new Calc();
            string number = Console.ReadLine();
            string number1 = Console.ReadLine();
            int input1 = int.Parse(number);
            int input2 = int.Parse(number1);
            int value = int.Parse(number);
            int value2 = int.Parse(number1);
            //Console.WriteLine($"Sum of 2 numbers: {value2 + value}");
            Add2Numbers(value2,value);
            Console.WriteLine($"Sum of 2 numbers: {value2 - value}");
            Console.WriteLine($"Sum of 2 numbers: {value2 / value}");
            Console.WriteLine($"Sum of 2 numbers: {value2 * value}");









        }
    
    public void Add2Numbers(int number1, int number2)
    {
        // Implement the logic for adding 2 numbers here and print
        Console.WriteLine($"Sum of 2 numbers: {number1 + number2}");
    }
}
    }

internal class Quiz
{

    public void Run()
    {

        Console.WriteLine("Welcome to quiz with 3 questions");
            Console.WriteLine("Number 1: Wich answer is true about Napoleon Bonaparte");
            Console.WriteLine("A: He was French");
            Console.WriteLine("B: He was Italian");
            Console.WriteLine("C: He was German");
            Console.WriteLine("--------------------------------------------------------------------------");          
          

            string input = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------");
            if (input == "b")           
            {
                Console.WriteLine("You are indeed correct, even if he borned in Corsica he had Italian roots!");
            }

            else
            {
                Console.WriteLine("you are not correct, B is Valid answer!!!");
               
                

            }
            Console.WriteLine("--------------------------------------------------------------------------");











    }

}
internal class TrueFalse
{

    public void Run()
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
internal class Floater
{

    public void Run()
    {

        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("Quiz on Float!");
        Console.WriteLine("Wich one is Float");
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("A: a");
        Console.WriteLine("B: 4,5");
        Console.WriteLine("C: 1");
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("If it says single you are correct!");
        string tree = Console.ReadLine();
        float leaf = float.Parse(tree);       
        Console.WriteLine(leaf);
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine(leaf.GetType().Name);
        Console.WriteLine("--------------------------------------------------------------------------");


    }

}
internal class Age
{
    public void Run()
    {

        Console.WriteLine("--------------------------------------------------------------------------");
        string tree = Console.ReadLine();
        Console.WriteLine("--------------------------------------------------------------------------");
        int value1 = int.Parse(tree);

            if (value1< 13)
            {
                Console.WriteLine("Alla 13-aastased: \"Naudi oma lapsepõlve!\"");
            }
            else if (value1 >= 12 && value1 <= 19)
{
    Console.WriteLine("13 kuni 19 aastat: \"Need on mõned mässulised teismeliseaastad!\"");
}
else if (value1 < 65)
{
    Console.WriteLine("Aastaid rohkem kui 19: \"Tere tulemast täiskasvanud elu!\"");
}
else
{
    Console.WriteLine("Haara kinni oma kuldaastate tarkusest!");
}
        Console.WriteLine("--------------------------------------------------------------------------");














    }

}