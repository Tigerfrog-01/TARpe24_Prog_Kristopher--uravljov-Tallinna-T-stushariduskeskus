using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            double money = 0;


            var Bank = new BANKSYSTEM();
            

            Console.WriteLine("Starting doing bank system");
            Bank.Run(money);
            
        }
    }
}

public class BANKSYSTEM
{
    public void Run(double money)
    {

        
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("Welcome this is your bank account info");     
        Console.WriteLine("Total money:" + money);
        Console.WriteLine("Card is Swedbank");
        Console.Write("Card number: ");
        string number = "50704579";
        if (number.Length == 8)

        {
            Console.WriteLine(number);
        }
        else
        {

            Console.WriteLine("invalid amount, lenght is 8, above or below is invalid");

        }
        var Checktwice = new BANKOPTION();
        Checktwice.Option(money);


    }

    }

public class BANKOPTION
{
    public void Option(double money)
    {


        Console.WriteLine("Would you like to do anything?");
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("Press A for add money");
        Console.WriteLine("Press B for substract money");
        Console.WriteLine("Press C for check again your balance");
        Console.WriteLine("Press D for return your card");
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.Write("Option: ");
        string Todosomething = Console.ReadLine();
        if (Todosomething == "a")
        {
            Console.Write("How much money you would want to add: ");
            string addmoney = Console.ReadLine();
            int addmoney2 = int.Parse(addmoney);         
            money =+ addmoney2;
            Console.WriteLine("Your new balance is: " + money);
        }
        else if (Todosomething == "b")
        {
            Console.Write("How much money you would want to substract: ");
            string addmoney = Console.ReadLine();
            int addmoney2 = int.Parse(addmoney);         
            money =- addmoney2;
            Console.WriteLine("Your new balance is: " + money);
        }
        else if (Todosomething == "c")
        {
            var Bank = new BANKSYSTEM();
            Bank.Run(money);
        }
        
        Console.WriteLine("--------------------------------------------------------------------------");
         var Checktwice = new BANKOPTION();
         Checktwice.Option(money);

        }
    }
