using System;
using System.IO;

namespace MicroPact_Exam_SumIntegersInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;
            Console.Write("Enter the File Path : ");
            path = Console.ReadLine();
            int result = sumIntegersInFile(path);
            Console.WriteLine("SUM : {0}", result);

        }
        
        public static int sumIntegersInFile(string fullFilePath) 
        {
            String line;
            double sum = 0;
            int count = 0;
             try
             {
                 StreamReader sr = new StreamReader(fullFilePath);
                 line = sr.ReadLine();

                 while (line != null)
                 {
                     foreach (char c in line)
                     {
                         if (char.IsDigit(c))
                         {
                             sum += Char.GetNumericValue(line, count);
                         }
                         count++;
                     }
                     count = 0;

                     line = sr.ReadLine();
                 }

                 sr.Close();
             }
             catch (Exception e)
             {
                 Console.WriteLine("Exception: " + e.Message);
             }
             return Convert.ToInt32(sum);
            
        }

    }
}
