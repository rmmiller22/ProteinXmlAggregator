using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace AggregateFiles
{
    class Program
    {
        static void Main()
        {
            string pathFile1 = @"E:\RMM\Jurkat Pruned Multiprotease databases\Trypsin\uniprot-proteome%3AUP000005640.xml-Jurkat_SAV_DBGPTMDpruned.xml";
            string pathFile2 = @"E:\RMM\Jurkat Pruned Multiprotease databases\ArgC\Jurkat_SAV_DB-uniprot-proteome%3AUP000005640.xmlGPTMDpruned.xml";
            //string pathFile3 = @"E:\RMM\Jurkat Pruned Multiprotease databases\AspN\Jurkat_SAV_DB-uniprot-proteome%3AUP000005640.xmlGPTMDpruned.xml";
            //string pathFile4 = @"E:\RMM\Jurkat Pruned Multiprotease databases\Chym\uniprot-proteome%3AUP000005640.xml-Jurkat_SAV_DBGPTMDpruned.xml";
            //string pathFile5 = @"E:\RMM\Jurkat Pruned Multiprotease databases\GluC\uniprot-proteome%3AUP000005640.xml-Jurkat_SAV_DBGPTMDpruned.xml";
            //string pathFile6 = @"E:\RMM\Jurkat Pruned Multiprotease databases\LysC\uniprot-proteome%3AUP000005640.xml-Jurkat_SAV_DBGPTMDpruned.xml";

           

            File.WriteAllText(@"E:\RMM\Jurkat Pruned Multiprotease databases\trypsinandArgC.xml", File.ReadAllText(pathFile1) + File.ReadAllText(pathFile2)); //+ File.ReadAllText(pathFile3) + File.ReadAllText(pathFile4) + File.ReadAllText(pathFile5) + File.ReadAllText(pathFile6));
            //string pathFile1 = @"E:\RMM\Jurkat Pruned Multiprotease databases\AggregateDatabase.xml";
            //string pathFile2 = @"E:\RMM\Jurkat_SAV_DB.fasta";


            //File.WriteAllText(@"E:\RMM\Jurkat Pruned Multiprotease databases\AggregateDatabase2.xml", File.ReadAllText(pathFile1) + File.ReadAllText(pathFile2));
        }
    }
    }
