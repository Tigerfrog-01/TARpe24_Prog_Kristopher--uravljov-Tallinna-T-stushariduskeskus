using System.ComponentModel.Design;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Remove // for make command active, you got three options regular, premium, linen.  Change (0) to any number you like but remember regular and premium has value 90-199 below or above wont work and steam has 120+ below dont work.

            //Regular regular = new Regular();
            // regular.DeScale(0);


            // regular.UseSteam(0);


            //  regular.Iron(120);


            //   regular.TurnOn(0);


            //  regular.TurnOff(0);

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

public interface IIronMachine
{
    void DeScale();
    void Iron(int b);
    void UseSteam();
    void TurnOn();
    void TurnOff();

}

public class IroningMachine : IIronMachine
{

     public int UsageCounter { get; set; } = 0;
     public bool IsOn { get; set; } = false;
     public bool SteamEnabled { get; set; } = false;
     public  string MachineType { get; set; }


    public void TurnOn() => IsOn = true;
    public void TurnOff() => IsOn = false;

}
public class IronTemp(int b)
{











}

    public class Regular : IIronMachine

{

    public virtual void DeScale()
    {
        if (UsageCounter => 3)
            DeScale(); 
    }

    public virtual void Iron(int Iron)
    {
        if (Iron < 89)
        {
            Console.WriteLine("Temperature too low, lowest possible is 90");

        }
        else if (Iron >= 90 & Iron <= 119)
        {
            Console.WriteLine("Doing synthetic program");
            Console.WriteLine("Iron temperature: " + Iron);
            
        }
        else if (Iron >= 120 & Iron <= 149)
        {
            Console.WriteLine("Doing silk program");
            Console.WriteLine("Iron temperature: " + Iron);



        }
        else if (Iron >= 150 & Iron <= 199)
        {
            Console.WriteLine("Doing cotton program");
            Console.WriteLine("Iron temperature: " + Iron);



        }
        else if (Iron >= 200 & Iron <= 231)
        {
            Console.WriteLine("Doing linen program");
            Console.WriteLine("Iron temperature: " + Iron);
        }

    }
    public virtual void UseSteam()
    {
       
                                                                                     
    }

    public virtual void TurnOn()
    {

    }

    public virtual void TurnOff()
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

        
        if (Iron < 89)
        {
            Console.WriteLine("Temperature too low, lowest possible is 90");

        }
        else if (Iron >= 90 & Iron <= 230)
        {
            Console.WriteLine("Iron temperature: " + Iron);
        }
        else if (Iron >= 120 & Iron <= 149)
        {
            Console.WriteLine("Doing silk program");
            Console.WriteLine("Iron temperature: " + Iron);


          
        }
        else if (Iron >= 150 & Iron <= 199)
        {
            Console.WriteLine("Doing cotton program");
            Console.WriteLine("Iron temperature: " + Iron);


        
        }
        else if (Iron >= 200 & Iron <= 230)
        {
            Console.WriteLine("Doing linen program");
            Console.WriteLine("Iron temperature: " + Iron);
         


        }





















    }














}