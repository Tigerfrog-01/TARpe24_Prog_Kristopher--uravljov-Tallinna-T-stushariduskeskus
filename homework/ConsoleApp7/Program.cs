using System.Collections.Generic;
using System.Reflection;
using System.Threading.Channels;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {


           
            var Checktwice = new FILEIDCHECKER();


            Console.WriteLine("Starting ID checking trough file");
            Checktwice.Run();
            Checktwice.ProcessIDCode("39912222746");
        }
    }
}
internal class FILEIDCHECKER
{

    public void Run()
    {

        
        string filePath = "IDCODE.txt";

       
        using (StreamReader reader = new StreamReader(filePath))
        {
            string IDcode;
            int count = 1; 
            while ((IDcode = reader.ReadLine()) != null) 
            {
                Console.WriteLine($"Processing ID Code {count}: {IDcode}");
                ProcessIDCode(IDcode);
                Console.WriteLine("---------------------------------------------------------------------------------------");
                count++;
            }
        }
    }

    public void ProcessIDCode(string IDcode)
    {
        // Checking control Nr
        string change = IDcode.Substring(10);
        Console.WriteLine("Control Nr: " + change);

        // Checking birth nr
        string change1 = IDcode.Substring(9.1);    
        Console.WriteLine("Birth nr: " + change1);

        // Checking hospital location
        string change3 = IDcode.Substring(7.2);        
        int value = int.Parse(change3);
        if (value >= 421 & value <= 470)
        {
            Console.WriteLine("Hospital is Pärnu");
        }
        else if (value >= 371 & value <= 420)
        {
            Console.WriteLine("Hospital is Narva");
        }
        else if (value >= 271 & value <= 370)
        {
            Console.WriteLine("Maarjamõisa kliinikum (Tartu), Jõgeva haigla");
        }
        else if (value >= 221 & value <= 270)
        {
            Console.WriteLine("Ida-Viru keskhaigla (Kohtla-Järve, endine Jõhvi)");
        }
        else if (value >= 161 & value <= 220)
        {
            Console.WriteLine("Rapla haigla, Loksa haigla, Hiiumaa haigla (Kärdla)");
        }
        else if (value >= 151 & value <= 160)
        {
            Console.WriteLine("Keila haigla");
        }
        else if (value >= 021 & value <= 150)
        {
            Console.WriteLine("Ida-Tallinna keskhaigla, Pelgulinna sünnitusmaja (Tallinn)");
        }
        else if (value >= 011 & value <= 019)
        {
            Console.WriteLine("Tartu Ülikooli Naistekliinik");
        }
        else if (value >= 001 & value <= 010)
        {
            Console.WriteLine("Kuressaare haigla");
        }
        else if (value >= 471 & value <= 490)
        {
            Console.WriteLine("Haapsalu haigla");
        }
        else if (value >= 491 & value <= 520)
        {
            Console.WriteLine("Järvamaa haigla");
        }
        else if (value >= 521 & value <= 570)
        {
            Console.WriteLine("Rakvere haigla, Tapa haigla");
        }
        else if (value >= 571 & value <= 600)
        {
            Console.WriteLine(" Valga haigla");
        }
        else if (value >= 601 & value <= 650)
        {
            Console.WriteLine("Viljandi haigla");
        }
        else if (value >= 651 & value <= 700)
        {
            Console.WriteLine("Lõuna-Eesti haigla (Võru), Põlva haigla");
        }

        // Checking gender
        string change5 = IDcode.Substring(0.10);        
        int result = int.Parse(change5);
        switch (result)
        {
            case 1:
            case 3:
            case 5:
            case 7:
                Console.WriteLine("He is man");
                break;
            case 2:
            case 4:
            case 6:
            case 8:
                Console.WriteLine("She is woman");
                break;
        }

        // Checking Birthdate
        // Year first
        string change7 = IDcode.Substring(1.4);      
        string year = change7.Substring(0.4);     
        int result1 = int.Parse(year);
        int result2 = int.Parse(change5);     
        if (result2 == 1)
        {
            Console.Write("18");
        }
        else if (result2 == 2)
        {
            Console.Write("18");
        }
        else if (result2 == 3)
        {
            Console.Write("19");
        }
        else if (result2 == 4)
        {
            Console.Write("19");
        }
        else if (result2 == 5)
        {
            Console.Write("20");
        }
        else if (result2 == 6)
        {
            Console.Write("20");
        }
        else if (result2 == 7)
        {
            Console.Write("21");
        }
        else if (result2 == 8)
        {
            Console.Write("21");
        }
        Console.Write(result1 + ".");

        // Extract day
        string change9 = IDcode.Substring(5.4);    
        Console.Write(change9);

        // Determine month
        string change11 = IDcode.Substring(3.6);      
        int result3 = int.Parse(change11);

        if (result3 == 1)
        {
            Console.WriteLine(".January");
        }
        else if (result3 == 2)
        {
            Console.WriteLine(".February");
        }
        else if (result3 == 3)
        {
            Console.WriteLine(".March");
        }
        else if (result3 == 4)
        {
            Console.WriteLine(".April");
        }
        else if (result3 == 5)
        {
            Console.WriteLine(".May");
        }
        else if (result3 == 6)
        {
            Console.WriteLine(".June");
        }
        else if (result3 == 7)
        {
            Console.WriteLine(".July");
        }
        else if (result3 == 8)
        {
            Console.WriteLine(".August");
        }
        else if (result3 == 9)
        {
            Console.WriteLine(".September");
        }
        else if (result3 == 10)
        {
            Console.WriteLine(".October");
        }
        else if (result3 == 11)
        {
            Console.WriteLine(".November");
        }
        else if (result3 == 12)
        {
            Console.WriteLine(".December");
        }
    }
}


















    
