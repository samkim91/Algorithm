using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class BetweenTowSets
    {
        public int getTotalX(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();

            for(int i = 1; i*a[a.Count()-1] < b[0]; i++)
            {
                result.Add(a[a.Count() - 1] * i);
            }
        }
    }
}
