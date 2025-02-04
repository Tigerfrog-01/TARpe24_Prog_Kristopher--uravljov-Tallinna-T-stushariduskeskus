namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string inputFilePath = "raw.txt"; 

            string outputFilePath = "cooked.txt"; 

            try
            {
              
                var inputLines = File.ReadAllLines(inputFilePath);

                var outputLines = new System.Collections.Generic.List<string>();

                decimal totalNetSalary = 0;



                foreach (var line in inputLines)
                {
                    string trimmedLine = line.Trim();
                    if (string.IsNullOrWhiteSpace(trimmedLine))
                        continue; 

                    if (trimmedLine.StartsWith("G") && trimmedLine.Length > 1)
                    {
                       
                        if (decimal.TryParse(trimmedLine.Substring(1).Trim(), out decimal grossSalary))
                        {
                            decimal netSalary = grossSalary - (grossSalary * 0.25M);
                            outputLines.Add(netSalary.ToString());
                            totalNetSalary += netSalary;

                        }
                        else

                        {
                            outputLines.Add("invalid: " + trimmedLine);

                        }
                    }
                    else if (trimmedLine.StartsWith("N") && trimmedLine.Length > 1)

                    {
                       
                        if (decimal.TryParse(trimmedLine.Substring(1).Trim(), out decimal netSalary))


                        {
                            outputLines.Add(netSalary.ToString());

                            totalNetSalary += netSalary;
                        }
                        else
                        {
                            outputLines.Add("invalid: " + trimmedLine);

                        }
                    }
                    else
                    {
                        
                        outputLines.Add("invalid: " + trimmedLine);

                    }
                }

               
                outputLines.Add("Sum is: " + totalNetSalary.ToString());


               
                File.WriteAllLines(outputFilePath, outputLines);


                Console.WriteLine("Salary data processing is cooked. Check the cooked file.");
            }
            catch (Exception ex)

            {
                Console.WriteLine("An error occurred: " + ex.Message);

            }













        }
    }
}
