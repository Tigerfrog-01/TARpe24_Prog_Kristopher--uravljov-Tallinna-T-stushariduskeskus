using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1

{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cat cat = new Cat();

            cat.CatIsPlaying(true , 450);


            

        }
    }
    
    
}

    public class Cat()
    {
        public bool CatIsPlaying(bool isSummer, int temp)
        {
       

            if (isSummer == true)
            {
            if (temp >= 421 & temp <= 470)
            {
                Console.WriteLine("Its summer ");

            }
            else
            {


           


            }

            }

        return false;

    }
    }


 

