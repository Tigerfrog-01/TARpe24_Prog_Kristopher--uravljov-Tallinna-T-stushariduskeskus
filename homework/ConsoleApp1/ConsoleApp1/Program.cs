namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double principal = 2000;

            double interestRate = 10 / 100;

            int years = 1;

            double finalAmount = FindCompoundInterest(principal, interestRate, years);

            Console.WriteLine($"The final amount after {years} years is {finalAmount}");
        }

        static double
        FindCompoundInterest(double principal, double interestRate, int years)


        {

            for (int i = 0; i < years; i++)
            {

                double interest = principal * interestRate;
                principal += interest;

            }

            return principal;

        }

    }
}

        
    
     



