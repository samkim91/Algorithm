using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
	class DivisibleSumPairs
	{

		public int divisibleSumPairs(int n, int k, int [] ar)
		{
			int result = 0;

			for (int i = 0; i < n - 1; i++)
			{
				for (int j = 1; j < n - i; j++)
				{
					if( (ar[i] + ar[i+j]) % k == 0)
					{
						result++;
					}
				}
			}

			return result;
		}

	}
}
