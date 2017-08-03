using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chemistry;
using MassSpectrometry;
using MzML;
using pepXML;
using Proteomics
using UsefulProteomicsDatabases;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(IDictionary<string, IList<Modification>> allKnownModifications)
        {
            List<Protein> proteins = ProteinDbLoader.LoadProteinDb("uniprot-proteome%3AUP000005640.xml-Jurkat_SAV_DBGPTMDproteinPruned.xml", allKnownModifications;
        }
    }
}
