using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
	class BreakingTheRecords
	{
		
		public int[] breakingRecords(int[] scores)
		{
			int max = 0;
			int min = 0;

			int highest = scores[0];
			int lowest = scores[0];

			foreach(int score in scores)
			{
				if(score > highest)
				{
					highest = score;
					max++;
				}

				if(score < lowest)
				{
					lowest = score;
					min++;
				}
			}

			int[] result = new int[] { max, min };

			return result;
		}
	}
}
