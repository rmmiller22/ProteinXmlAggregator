using System.Collections.Generic;
using Proteomics;
using UsefulProteomicsDatabases;



namespace RM_ProteinAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool generateDecoys= true;
            IDictionary<string, IList<Modification>> allKnownModifications;
            bool IsContaminant =false;
            out Dictionary<string, Modification> unknownModifications;
            List<Protein> proteins = ProteinDbLoader.LoadProteinDb("proteins.xml", generateDecoys, allKnownModifications, IsContaminant, out unknownModifications);
            

         }
    } 
