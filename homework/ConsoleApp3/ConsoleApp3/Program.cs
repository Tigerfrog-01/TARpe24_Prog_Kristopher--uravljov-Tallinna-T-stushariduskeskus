namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
         VATCalc VAT = new VATCalc();
         VAT.FindVATFromPrice(20);
         VAT.FindPrice("True", 20);


        }
    }
}

class VATCalc
{
    private  double _VATPerc;
    private double _Value;
    private string _False;
    public VATCalc()
    {

       
    }
    public VATCalc(double VATPercentage, double Price, bool False)
    {
        
        this._Value = Price;
        this._False = "";
    }

    public void FindVATFromPrice(double price)
    {
        double VATPercentage = 20;
        double Transfrom = VATPercentage / 100;
        double VATprice = Transfrom * price;
        double WithoutVat = price - VATprice;
        double PriceWithVat = VATPercentage + VATprice;
        Console.WriteLine("Price with VAT is:" + PriceWithVat );
        Console.WriteLine("VAT is:" + VATprice);
    }
    public void FindPrice(bool False, double price)
    {
       
     
        


    }
    }

