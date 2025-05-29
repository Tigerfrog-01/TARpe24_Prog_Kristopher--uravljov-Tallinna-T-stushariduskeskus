namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawDiamond(57);

        }
        static void DrawDiamond(int n)
        {

            if (n % 2 == 0)
            {
                Console.WriteLine("Please enter an odd number");
                return;

            }

            int mid = n / 2;

            for (int i = 0; i <= mid; i++)
            {
                int stars = 2 * i + 1;
                int spaces = mid - i;
                Console.WriteLine(new string(' ', spaces) + new string('*', stars));

            }
            for (int i = mid - 1; i >=0; i --)
            {
                int stars = 2 * i + 1;
                int spaces = mid - i;
                Console.WriteLine(new string(' ', spaces) + new string('*', stars));

            }

        }
    }
}