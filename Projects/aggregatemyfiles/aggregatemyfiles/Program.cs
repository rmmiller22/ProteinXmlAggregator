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
        static void Main(string[] args)
        {
            string trypsin = @"E:\RMM\Jurkat Pruned Multiprotease databases\Trypsin\uniprot-proteome%3AUP000005640.xml-Jurkat_SAV_DBGPTMDproteinPruned.xml";
            string argC = @"E:\RMM\Jurkat Pruned Multiprotease databases\ArgC\Jurkat_SAV_DB-uniprot-proteome%3AUP000005640.xmlGPTMDproteinPruned.xml";
            string aspN = @"E:\RMM\Jurkat Pruned Multiprotease databases\AspN\Jurkat_SAV_DB-uniprot-proteome%3AUP000005640.xmlGPTMDproteinPruned.xml";
            string chym = @"E:\RMM\Jurkat Pruned Multiprotease databases\Chym\uniprot-proteome%3AUP000005640.xml-Jurkat_SAV_DBGPTMDproteinPruned.xml";
            string lysC = @"E:\RMM\Jurkat Pruned Multiprotease databases\LysC\uniprot-proteome%3AUP000005640.xml-Jurkat_SAV_DBGPTMDproteinPruned.xml";
            string gluC = @"E:\RMM\Jurkat Pruned Multiprotease databases\GluC\uniprot-proteome%3AUP000005640.xml-Jurkat_SAV_DBGPTMDproteinPruned.xml";
            string aggregatedDatabase = Path.Combine(trypsin, argC, aspN, chym, lysC, gluC);
            Console.WriteLine(aggregatedDatabase);
        }
    }
}
