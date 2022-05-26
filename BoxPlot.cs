using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Words
{
    internal class BoxPlot
    {
        public double median(List<int> times)
        {
             Tuple<double, double, double> tup = TimeCounting(times);
             return tup[1];
        }
    }
}
