using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

    public class ViewModel
    {
        public ObservableCollection<Sales> Data { get; set; }
        public List<Brush> CustomBrushes { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<Sales>(new GraphVm().Data);
            CustomBrushes = new List<Brush>
            {
                new SolidColorBrush(Color.FromRgb(255, 0, 0)),
                new SolidColorBrush(Color.FromRgb(0, 255, 0)),
                new SolidColorBrush(Color.FromRgb(0, 255, 0)),
                new SolidColorBrush(Color.FromRgb(0, 0, 0)),
                new SolidColorBrush(Color.FromRgb(0, 0, 0))
            };
        }
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
