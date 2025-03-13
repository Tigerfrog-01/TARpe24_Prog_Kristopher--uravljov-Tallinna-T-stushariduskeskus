using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Remove // for make command active, you got three options regular, premium, linen.  Change (0) to any number you like but remember regular and premium has value 90-199 below or above wont work and steam has 120+ below dont work.

         Regular regular = new Regular();
         regular.DeScale(0);

         Regular regular1 = new Regular();
         regular1.Iron(150);

         Regular regular3 = new Regular();
         regular3.TurnOn(0);

         Regular regular4 = new Regular();
         regular4.TurnOff(0);

         // Premium premium = new  Premium();
         //premium.DeScale(0);

         //Premium premium1 = new Premium();
         //premium1.Iron(0);

         //Premium premium2 = new Premium();
         //premium2.UseSteam(0);

         //Premium premium3 = new Premium();
         //premium3.TurnOn(0);

         //Premium premium4 = new Premium();
         //premium4.TurnOff(0);

         //Linen linen = new Linen();
         // linen.DeScale(0);

         // Linen linen1 = new Linen();
         //linen1.Iron(0);

         //Linen linen2 = new Linen();
         //linen2.UseSteam(0);

         //Linen linen3 = new Linen();
         //linen3.TurnOn(0);

         //Linen linen4 = new Linen();
         //linen4.TurnOff(0);







        }
    }
}

interface IIronMachine
{
    void DeScale(int a);
    void Iron(int b);
    void UseSteam(int c);
    void TurnOn(int d);
    void TurnOff(int e);

}

class Regular : IIronMachine

{

    public virtual void DeScale(int scale)
    {

    }

    public virtual void Iron(int Iron)
    {
        int regular1 = 0;

        if (Iron >= 90 & Iron <= 119)
        {
            Console.WriteLine("Doing synthetics program");
            Console.WriteLine("Iron temperature: " + Iron);
            Console.WriteLine(regular1 + 1);
        }
        else if (Iron >= 120 & Iron <= 149)
        {
            Console.WriteLine("Doing silk program");
            Console.WriteLine("Iron temperature: " + Iron);
            Console.WriteLine(regular1 + 1);
        }
        else if (Iron >= 150 & Iron <= 199)
        {
            Console.WriteLine("Doing cotton program");
            Console.WriteLine("Iron temperature: " + Iron);
            Console.WriteLine(regular1 + 1);
        }
        else if (Iron >= 200 & Iron <= 230)
        {
            Console.WriteLine("Cannot do the program, use linen");
            
        }
    }

    public virtual void UseSteam(int Steam)
    {

        int Iron = 0;   

        if (Iron >= 120)
        {
            Console.WriteLine("Steam is used at the following temperature: " + Steam);
        }
        else if (Iron <= 120)
        {
            Console.WriteLine("Iron Temperature is too low");
        }
    }

    public virtual void TurnOn(int On)
    {

    }

    public virtual void TurnOff(int Off)
    {

    }


}
class Premium : Regular

{
    
}
class Linen : Regular

{

    public virtual void Iron(int Iron)
    {
        int regular1 = 0;
        if (Iron >= 90 & Iron <= 230)
        {
            Console.WriteLine("Iron temperature: " + Iron);
        }
        else if (Iron >= 120 & Iron <= 149)
        {
            Console.WriteLine("Doing silk program");
            Console.WriteLine("Iron temperature: " + Iron);


            Console.WriteLine(regular1 + 1);
        }
        else if (Iron >= 150 & Iron <= 199)
        {
            Console.WriteLine("Doing cotton program");
            Console.WriteLine("Iron temperature: " + Iron);

           
            Console.WriteLine(regular1 + 1);
        }
        else if (Iron >= 200 & Iron <= 230)
        {
            Console.WriteLine("Doing linen program");
            Console.WriteLine("Iron temperature: " + Iron);
            Console.WriteLine(regular1 + 1);


        }

    }
}
