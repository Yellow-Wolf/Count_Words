using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Words
{
    internal class BoxPlot
    {
        myWordCount mc = new myWordCount();
        public int median()
        {
            mc.WordCount();
            var k = mc.wordList.Values.ToArray();
            int sum = k.Sum();

            var accum = 0;
            for (int i = 0; i < k.Length; i++)
            {
                accum += k[i];
                if (accum >= sum / 2)
                    return i;
            }

            return k.Length;
        }
    }
}
