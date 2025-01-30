namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                   var list = new int[] { 3, 3, 5, 9, 11};



                    FindMedianAndMean(list);
                }


                static void FindMedianAndMean(int[] numbers)
                {

                    var sortedNumbers = numbers.OrderBy(n => n).ToArray();


                    double median;
                    int length = sortedNumbers.Length;

                    if (length % 2 == 1)

                    {

                        median = sortedNumbers[length / 2];
                    }

                    else
                    {

                        median = (sortedNumbers[length / 2 - 1] + sortedNumbers[length / 2]) / 2.0;
                    }


                    double mean = sortedNumbers.Average();


                    Console.WriteLine($"List: {string.Join(", ", numbers)}");

                    Console.WriteLine($"Median: {median}");

                    Console.WriteLine($"Arithmetic Mean: {mean}");
                }
            }

        }

























