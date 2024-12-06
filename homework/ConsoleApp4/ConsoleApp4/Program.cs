using System.Runtime.Intrinsics.X86;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
           
            string tree = Console.ReadLine();
            int value1 = int.Parse(tree);

            if (value1 < 13)
            {
                Console.WriteLine("Alla 13-aastased: \"Naudi oma lapsepõlve!\"");
            }
            else if (value1 >= 12 && value1 <= 19)            
            {
                Console.WriteLine("13 kuni 19 aastat: \"Need on mõned mässulised teismeliseaastad!\"");
            }
            else if (value1 < 65 )
            {
                Console.WriteLine("Aastaid rohkem kui 19: \"Tere tulemast täiskasvanud elu!\"");
            }
            else 
            {
                Console.WriteLine("Haara kinni oma kuldaastate tarkusest!");
            }








































        }
    }
}
