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
        
        double StdDev(List<double> valuesList)
        {
            double average = valuesList.Sum();
            average = average / valuesList.Count;
            double sum = valuesList.Sum(x => Math.Pow(x - average, 2)); 
            return Math.Sqrt(sum / valuesList.Count);
        }
        
        public int amax(List<int> valueList)
        {
             return valueList.Max();   
        }
    }
}
