using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
               
            Console.WriteLine(GetMoneyInfo("5")); 
        }

        static string GetMoneyInfo(string amount)
        {
           
            int euros = 0, cents = 0;

            if (amount.Length == 3) 

            {
                euros = int.Parse(amount.Substring(0, 1)); 

                cents = int.Parse(amount.Substring(1, 2)); 

            }
            else if (amount.Length == 2) 
            {

                cents = int.Parse(amount);

            }
            else if (amount.Length == 1)
            {
                cents = int.Parse(amount);
            }

           
            string result = "";

          
            if (euros > 0)
            {
                if (euros == 1)
                    result += "1 euro";
                else
                    result += euros + " eurot";
            }

           
            if (cents > 0)
            {
                if (euros > 0)

                    result += " ja "; 

                if (cents == 1)

                    result += "1 sent";

                else

                    result += cents + " senti";
            }

            
            if (euros == 0 && cents == 0)


            {
                result = "0 senti";

            }

            return result;
















        }
    }
}
