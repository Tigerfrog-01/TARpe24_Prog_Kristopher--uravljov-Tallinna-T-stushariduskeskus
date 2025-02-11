using System.ComponentModel.Design;


namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Checking control Nr
            string IDcode = "34501234215";
            string change = IDcode.Substring(10);
            Console.WriteLine("Control Nr:" + change);
            //Checking birth nr
            string IDcode1 = "34501234215";
            string change1 = IDcode1.Substring(9);
            string change2 = change1.Substring(0, change1.Length - 1);
            Console.WriteLine("Birth nr:" + change2);
            //Checking hospital location
            string IDcode3 = "34501234215";
            string change3 = IDcode3.Substring(7);
            string change4 = change3.Substring(0, change3.Length - 2);
            int value = int.Parse(change4);
            if (value == 42)
            {
                Console.WriteLine("Place of birth: Pärnu");
            }
            else
            {
                Console.WriteLine("We dont have data for other hospitals than 42 aka Pärnu");
            }
            //Checking gender
            string IDcode5 = "34501234215";
            string change5 = IDcode5.Substring(0);
            string change6 = change5.Substring(0, change5.Length - 10);
            int result = int.Parse(change6);
            switch (result)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                Console.WriteLine("man");
                break;
                case 2:
                case 4:
                case 6:
                case 8:
                Console.WriteLine("woman");
                break;
            }
            //Checking Birthdate
            //year first
            string IDcode7 = "34501234215";
            string change7 = IDcode7.Substring(1);
            string change8 = change7.Substring(0, change7.Length - 4);
            string year = change8.Substring(0);
            string year1 = year.Substring(0, year.Length - 4);
            int result1 = int.Parse(year1);
            int result2 = int.Parse(change6);          
            if (result2 == 1)
            {
                Console.WriteLine("18" + result1 );
            }
            else if (result2 == 2)
            {
                result2 = 18 + result1;
            }
            else if (result2 == 3)
            {
              result2 = 19 + result1;
            }
            else if (result2 == 4)
            {
                Console.WriteLine("19" + result1);
            }
            else if (result2 == 5)
            {
                Console.WriteLine("20" + result1);
            }
            else if (result2 == 6)
            {
                Console.WriteLine("20" + result1);
            }
            else if (result2 == 7)
            {
                Console.WriteLine("21" + result1);
            }
            else if (result2 == 8)
            {
                Console.WriteLine("21" + result1 );
            }
            //extract day
            string IDcode8 = "34501234215";
            string change9 = IDcode8.Substring(5);
            string change10 = change9.Substring(0, change9.Length - 4);
            Console.WriteLine(change10);
            //makin sure wich month is real
            string IDcode9 = "34501234215";
            string change11 = IDcode9.Substring(3);
            string change12 = change11.Substring(0, change11.Length - 6);
            int result3 = int.Parse(change12);
            
            if (result3 == 01)
            {
                Console.WriteLine("January");
            }
            else if (result3 == 02)
            {
               Console.WriteLine("Febuary");
            }
            else if (result3 == 04)
            {
                Console.WriteLine("March");
            }
            else if (result3 == 05)
            {
                Console.WriteLine("April");
            }
            else if (result3 == 06)
            {
                Console.WriteLine("May");
            }
            else if (result3 == 07)
            {
                Console.WriteLine("June");
            }
            else if (result3 == 08)
            {
                Console.WriteLine("July");
            }
            else if (result3 == 09)
            {
                Console.WriteLine("August");
            }
            else if (result3 == 10)
            {
                Console.WriteLine("October");

            }
            else if (result3 == 11)
            {
                Console.WriteLine("November");
            }
            else if (result3 == 12)
            {
                Console.WriteLine("December");
            }

            Console.WriteLine(result2);
            


        }
        
    }

    }

