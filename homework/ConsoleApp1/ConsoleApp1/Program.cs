using System.Diagnostics;
using System.Diagnostics.Tracing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
        Console.WriteLine(Word("a")); 
      
    }

    static string Word(string word)
    {
        if (word.Length < 2)
        {
            return "too short word!";
        }

        string result = string.Empty;

        for (int i = 0; i < word.Length; i += 2)
        {
            result += word[i];
        }

        return result;
    }
}













        }
    
