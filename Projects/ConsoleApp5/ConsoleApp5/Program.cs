using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
            
            public static void ProcessDirectory(string targetDirectory)
            {
            targetDirectory = @"E:\RMM\Testtxts";
                // Process the list of files found in the directory.
                string[] fileEntries = Directory.GetFiles(targetDirectory);
                foreach (string fileName in fileEntries)
                    ProcessFile(fileName);
            }

            // Insert logic for processing found files here.
            public static void ProcessFile(string path)
            {
                Console.WriteLine("Processed file '{0}'.", path);
            Console.Read();
            }
            //string path = @"E:\RMM\directoryForProgram1";

            //    DirectoryInfo di = Directory.CreateDirectory(path);
            //    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));
            //    Console.ReadLine();


            //string[] dirs = Directory.GetFiles(@"E:\RMM", "*t");
            //Console.WriteLine("The number of txt files is" + dirs.Length);
            //Console.ReadLine();
        }
    }

        //        foreach (string dir in dirs)
        //        {
        //            Console.WriteLine(dir);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("The process failed: {0}", e.ToString());
        //    }
        //}
        //static void Combine(string inputDirectoryPath, string inputFileNamePattern, string outputFilePath)
        //{
        //    string[] inputFilePaths = Directory.GetFiles(inputDirectoryPath, inputFileNamePattern);
        //    inputDirectoryPath = @"E:\RMM\Testtxts";
        //    inputFileNamePattern = ".txt";
        //    outputFilePath = @"E:\RMM\Testtxts";
        //    Console.WriteLine("Number of files" + inputFilePaths.Length);
        //    //using (var outputStream = File.Create(outputFilePath))
        //    //{
        //    //    foreach (var inputFilePath in inputFilePaths)
        //    //    {
        //    //        using (var inputStream = File.OpenRead(inputFilePath))
        //    //        {
        //    //            // Buffer size can be passed as the second argument.
        //    //            inputStream.CopyTo(outputStream);
        //    //        }
        //    //        Console.WriteLine("The file has been processed." + inputFilePath);
                   
        //    //    }

        //    //}
       
 

       
        
    

