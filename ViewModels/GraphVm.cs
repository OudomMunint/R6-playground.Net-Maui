using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redsix.ViewModels
{

    public class Sales
    {
        public string Product { get; set; }
        public double SalesRate { get; set; }
    }

    class GraphVm
    {
        public List<Sales> Data { get; set; }

        public GraphVm()
        {
            Data = new List<Sales>()
        {
            new Sales(){Product = "Happy", SalesRate = 5},
            new Sales(){Product = "Okay", SalesRate = 1},
            new Sales(){Product = "Sad", SalesRate = 1},
            new Sales(){Product = "Need Help", SalesRate = 1},
            new Sales(){Product = "Can't Decide", SalesRate = 2},
        };
        }
    }
 
}
