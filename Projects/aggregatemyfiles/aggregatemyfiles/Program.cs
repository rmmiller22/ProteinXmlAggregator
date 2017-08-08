using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace aggregatemyfiles
{
    class Program
    {
        static void Main(string dirPath, string filePattern, string destFile)
        {

                string[] fileAry = Directory.GetFiles(@"E:\RMM\Testtxts", ".txt");

                Console.WriteLine("Total File Count : " + fileAry.Length);

                using (TextWriter tw = new StreamWriter(destFile, true))
                {
                    foreach (string filePath in fileAry)
                    {
                        using (TextReader tr = new StreamReader(filePath))
                        {
                            tw.WriteLine(tr.ReadToEnd());
                            tr.Close();
                            tr.Dispose();
                        }
                        Console.WriteLine("File Processed : " + filePath);
                    }

                    tw.Close();
                    tw.Dispose();
                }
            }

        }
    }

