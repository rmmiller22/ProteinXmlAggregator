using Proteomics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulProteomicsDatabases;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, IList<Modification>> allKnownModifications;
                out Dictionary<string, Modification> unknownModifications;
            List<Protein> proteins = ProteinDbLoader.LoadProteinDb("uniprot-proteome%3AUP000005640.xml-Jurkat_SAV_DBGPTMDpruned.xml",  allKnownModifications, out unknownModifications);
        }
    }
}
