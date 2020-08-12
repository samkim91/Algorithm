using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
	class BirthdayChocolate
	{
		
		public int birthday(List<int> s, int d, int m)
		{
            int result = 0;

            for (int i = 0; i < s.Count - m + 1; i++)
            {
                int sum = 0;

                for (int j = 0; j < m; j++)
                {
                    sum += s[i + j];
                }

                if (sum == d)
                {
                    result++;
                }
            }

            return result;
        }
	}
}
