using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareDatabases
{
    class Program
    {
        static void Main(string[] args)
        {
            // This method accepts two strings the represent two files to 
            // compare. A return value of 0 indicates that the contents of the files
            // are the same. A return value of any other value indicates that the 
            // files are not the same.
            
                int file1byte;
                int file2byte;
                FileStream fs1;
                FileStream fs2;


            // Open the two files.
                string file1 = @"E:\RMM\Jurkat Pruned Multiprotease databases\AggregateDatabase.xml";
                string file2 = @"E:\RMM\Jurkat Pruned Multiprotease databases\merged_database_2017-08-04-10-28-02.xml";
                fs1 = new FileStream(file1, FileMode.Open);
                fs2 = new FileStream(file2, FileMode.Open);

                // Check the file sizes. If they are not the same, the files 
                // are not the same.
                if (fs1.Length != fs2.Length)
                {
                    // Close the file
                    fs1.Close();
                    fs2.Close();

                    // Return false to indicate files are different
                    Console.WriteLine("The Databases are not the same length");
                Console.Read();
                }

                //// Read and compare a byte from each file until either a
                //// non-matching set of bytes is found or until the end of
                //// file1 is reached.
                //do
                //{
                //    // Read one byte from each file.
                //    file1byte = fs1.ReadByte();
                //    file2byte = fs2.ReadByte();
                //}
                //while ((file1byte == file2byte) && (file1byte != -1));

                //// Close the files.
                //fs1.Close();
                //fs2.Close();

                //// Return the success of the comparison. "file1byte" is 
                //// equal to "file2byte" at this point only if the files are 
                //// the same.
                //Console.WriteLine((file1byte - file2byte) == 0);
            }
        }
    }
