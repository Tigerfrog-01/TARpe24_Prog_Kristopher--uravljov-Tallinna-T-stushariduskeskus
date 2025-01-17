using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;

namespace ProgTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var Lister = new Shorter();
            var Perc = new lst();
            var Rand = new four();
            var Doter = new libary();         
            Console.WriteLine("Starting remove every 2 words:");
            //Lister.Apple();
            Console.WriteLine("\nStarting list in reverse way");
            //Perc.Pear();
            Console.WriteLine("\nStarting put random stuff:");
            Rand.Grape();
            Console.WriteLine("\nStarting calculate:");
            Doter.Banana();           
        }
    }
}
internal class Shorter
{
    public void Apple()
    {


        Console.WriteLine(Word("Auto"));

    }

    static string Word(string word)
    {
        if (word.Length < 2)
        {
            return "too short word!";
        }

        string result = string.Empty;

        for (int i = 0; i < word.Length; i += 2)
        {
            result += word[i];
        }
        Console.WriteLine("-------------------");
        return result;
    }
}
internal class lst
{
    public void Pear()
    {

            List<string> lst = new List<string>();

            lst.Add(Console.ReadLine());
            lst.Add(Console.ReadLine());
            lst.Add(Console.ReadLine());
            lst.Add(Console.ReadLine());
            lst.Reverse();



            Console.WriteLine("-----------------------------------------");


            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {lst[i]}");
            }
        }
    }
internal class four
{    
    public void Grape()
    {




        {
            string filePath = "test.txt";
            List<string> coconut = new List<string>();
            
            using (StreamReader reader = new StreamReader(filePath))
            {
                
                for (int i = 4; i >= 1; --i)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                        break;
                    coconut.Add(line);


                   
                }
            }
            StreamWriter writer = new StreamWriter(filePath);
            for (int i = 0;)
            {
              




            }


        }





    internal class libary
{
    public void Banana()
    {
        Console.WriteLine("Enter amount of books (max 5):");
        string tree = Console.ReadLine();

        int books = int.Parse(tree);


        if (books > 5)
        {
            Console.WriteLine("You can only borrow a maximum of 5 books.");
            return;
        }

        Console.WriteLine("Enter number of days:");
        string sun = Console.ReadLine();
        Console.WriteLine("-------------------------------------------");

        int value = int.Parse(sun);


        if (value <= 21)
        {
            Console.WriteLine("No fine");
        }
        else
        {
            int extraDays = value - 21;


            double fine = extraDays * 0.50 * books;


            Console.WriteLine($"Your fine is {fine:C}");
        }




    }

}

