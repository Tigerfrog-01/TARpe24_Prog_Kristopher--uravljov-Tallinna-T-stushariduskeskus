using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
         VATCalc VAT = new VATCalc();
         VAT.FindVATFromPrice(20);
         VAT.FindPrice("true" , 20);
         VAT.FindPriceBasedOnTax(4);

        }
    }
}

class VATCalc
{
    private double _VATPerc;
    private double _Value;

    public VATCalc()
    {


    }
    public VATCalc(double VATPercentage, double Price)
    {

        this._Value = Price;

    }

    public void FindVATFromPrice(double price)
    {
        double VATPercentage = 20;
        double Transfrom = VATPercentage / 100;
        double VATprice = Transfrom * price;
        double WithoutVat = price - VATprice;
        Console.WriteLine("VAT is:" + VATprice);
    }
    public void FindPrice(string YesorNo, double price)
    {

        if (YesorNo == "true")
        {
            double tax = 0.166667;
            double FindTax = price * tax;
            double number = 0.00334;
            Console.WriteLine("Tax: " + (FindTax - number));
            double WithTax = price - FindTax;
            Console.WriteLine("Without tax is: " + Math.Round(WithTax, 2));

        }
        else if (YesorNo == "false")
        {
            double VATPercentage = 20;
            double Transfrom = VATPercentage / 100;
            double VATprice = Transfrom * price;
            double PriceWithVat = VATPercentage + VATprice;
            Console.WriteLine("With tax is: " + PriceWithVat);
        }
        else
        {
            Console.WriteLine("Invalid answer either say true or false");

        }

    }
    public void FindPriceBasedOnTax(double tax)
    {

        double FindPrice = 0.166667;
        double WithVAT = tax / FindPrice;

       
        Console.WriteLine("Price is: " + (Math.Round(WithVAT, 2) - tax));



    }

}

