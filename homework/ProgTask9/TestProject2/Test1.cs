namespace TestProject2;
using ConsoleApp1;



[TestClass]



public class UnitTest2
{

    public VATCalc VAT = new VATCalc();

    [TestMethod]
    public void IfPriceisTrue()
    {
        bool result = VAT.FindPrice(true , 45);
        Assert.IsTrue(result);

    }
    [TestMethod]
    public void IfIts20Percentage()
    {
        bool result = VAT.IsTaxPercent20(true);
        Assert.IsTrue(result);

    }
    [TestMethod]
    public void FindVATFromPrice()
    {
        var result = VAT.FindVATFromPrice(20);
        var expected = 4;
    }
    [TestMethod]
    public void FindPrice()
    {
        var result = VAT.FindPriceBasedOnTax(4);
        var expected = 20;
    }

}



























