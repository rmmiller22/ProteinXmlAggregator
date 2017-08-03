using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProteinAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool generateDecoys = true;
            IDictionary<string, IList< Modifications >> allKnownModifications;
            bool IsContaminant = false;
            out Dictionary<string, Modifications> uknownModifications;
            List<Protein> proteins = ProteinDbLoader.LoadProteinDb("proteins.xml", generateDecoys, allKnownModifications, IsContaminant, out unknownModifications);
        }
    }
}
