using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Parser_for_Peptide_Count
{

    class Program
    {
        static int Main(string[] args)
        {

            List<string> foundUniquePSM1 = new List<string>();
            List<string> foundALLPSM1 = new List<string>();
            List<string> foundUniquePSM3 = new List<string>();
            List<string> foundALLPSM3 = new List<string>();
            List<string> foundUniquePSM5 = new List<string>();
            List<string> foundALLPSM5 = new List<string>();
            string line;
            var directory = new DirectoryInfo("C:\\Program Files (x86)\\Jenkins\\workspace\\TestData");
            var myDirectory = (from f in directory.GetDirectories()
                               orderby f.LastWriteTime descending
                               select f).First();



            using (StreamReader file = new StreamReader(Path.Combine(directory.ToString(), myDirectory.ToString(), "Task1SearchTask", "results.txt")))
            {

                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains("Unique PSMs within 1% FDR"))
                    {
                        foundUniquePSM1.Add(line);
                    }
                    if (line.Contains("All target PSMS within 1% FDR"))
                    {
                        foundALLPSM1.Add(line);
                    }
                }
            }

            using (StreamReader file = new StreamReader(Path.Combine(directory.ToString(), myDirectory.ToString(), "Task3SearchTask", "results.txt")))
            {
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains("Unique PSMs within 1% FDR"))
                    {
                        foundUniquePSM3.Add(line);
                    }
                    if (line.Contains("All target PSMS within 1% FDR"))
                    {
                        foundALLPSM3.Add(line);
                    }
                }
            }

            using (StreamReader file = new StreamReader(Path.Combine(directory.ToString(), myDirectory.ToString(), "Task5SearchTask", "results.txt")))
            {
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains("Unique PSMs within 1% FDR"))
                    {
                        foundUniquePSM5.Add(line);
                    }
                    if (line.Contains("All target PSMS within 1% FDR"))
                    {
                        foundALLPSM5.Add(line);
                    }
                }
            }
            Console.WriteLine(Path.Combine(directory.ToString(), myDirectory.ToString(), "Task5SearchTask", "results.txt"));

           for (int i = 0; i < foundUniquePSM1.Count; i++)
            {
                if ((Int32.Parse(foundUniquePSM1[i].Split(' ').Last()) - 1) > Int32.Parse(foundUniquePSM3[i].Split(' ').Last()))
                {
                   
                    Console.WriteLine("FOUND PSMS DID NOT INCREASE BETWEEN SEARCHTASK1 and SEARCHTASK3");
                    Environment.Exit(-1);
                    return -1;
                }
            }
     
            if ((Int32.Parse(foundALLPSM1[foundALLPSM1.Count - 1].Split(' ').Last()) - 1) > Int32.Parse(foundALLPSM3[foundALLPSM3.Count - 1].Split(' ').Last())) {
                   
                Console.WriteLine("FOUND PSMS DID NOT INCREASE BETWEEN SEARCHTASK1 and SEARCHTASK3");
                Environment.Exit(-1);
                return -1;
              
            }

            for (int i = 0; i < foundUniquePSM5.Count; i++)
               {

                    if (Int32.Parse(foundUniquePSM3[i+1].Split(' ').Last()) > Int32.Parse(foundUniquePSM5[i].Split(' ').Last()))
                    {
                        Console.WriteLine("FOUND PSMS DID NOT INCREASE BETWEEN SEARCHTASK3 and SEARCHTASK5");
                        Environment.Exit(-1);
                        return -1;
                    }
                
               }  

            for (int i = 0; i < foundALLPSM5.Count; i++)
            {
                if ((Int32.Parse(foundALLPSM3[i].Split(' ').Last()) -1) > Int32.Parse(foundALLPSM5[i].Split(' ').Last()))
                {
                    Console.WriteLine("FOUND PSMS DID NOT INCREASE BETWEEN SEARCHTASK3 and SEARCHTASK5");
                    Environment.Exit(-1);
                    return -1;
                }
            }
            
            Console.WriteLine("number of found PSMS succesfully increased");
            return 0;
        }
    }
}
