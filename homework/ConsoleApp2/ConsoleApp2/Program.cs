using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Program
    {

        public class Bank
        {

            private double _money;
            private string _cardname;
            private string _cardnumber;

            public Bank()
            {

                _money = 0;
                _cardname = "MasterCard";
                _cardnumber = "30405590";
            }
            public void SetMoney(double _money)
            {
                this._money = _money;
                string one = Console.ReadLine();
                Console.WriteLine(_money + one);
            }
            class Final
            {
                static void Main(string[] args)
                {
                    Bank bank = new Bank();
                    bank.PrintInfo

                    bank._money = 0;

                }
            }
        }
    }
}
