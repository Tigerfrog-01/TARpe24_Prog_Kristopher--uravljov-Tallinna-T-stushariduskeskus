namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();
            using (StreamReader reader = new StreamReader("file.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line); 
                    Console.WriteLine(line); 
                }
                Console.WriteLine("--------------------------------");
            }
            List<string> list1 = new List<string>();
            using (StreamReader reader = new StreamReader("half.txt"))
            {
                string line1;
                while ((line1 = reader.ReadLine()) != null)
                {
                    list.Add(line1);
                    Console.WriteLine(line1);
                }
            }

            


















        }
    }
}