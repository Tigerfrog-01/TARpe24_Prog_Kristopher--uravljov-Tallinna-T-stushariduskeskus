namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string beginningsFile = "file.txt";
            string endingsFile = "half.txt";
            string resultFile = "full.txt";

            
            List<string> beginnings = new List<string>();
            List<string> endings = new List<string>();
            List<string> fullIds = new List<string>();

            
            using (StreamReader srBeginnings = new StreamReader(beginningsFile))
            {
                string line;
                while ((line = srBeginnings.ReadLine()) != null)
                {
                    beginnings.Add(line.Trim());  
                }
            }

         
            using (StreamReader srEndings = new StreamReader(endingsFile))
            {
                string line;
                while ((line = srEndings.ReadLine()) != null)
                {
                    endings.Add(line.Trim());  
                }
            }

           
            foreach (string beginning in beginnings)
            {
                int requiredEndingLength = 11 - beginning.Length; 

                
                foreach (string ending in endings)
                {
                    if (ending.Length == requiredEndingLength)
                    {
                        string fullId = beginning + ending;  
                        fullIds.Add(fullId);
                        endings.Remove(ending);  
                        break;  
                    }
                }
            }

           
            using (StreamWriter sw = new StreamWriter(resultFile))
            {
                foreach (string fullId in fullIds)
                {
                    sw.WriteLine(fullId);
                }
            }

            Console.WriteLine("ID codes have been restored and saved to " + resultFile);
        }
    }



















}
    
