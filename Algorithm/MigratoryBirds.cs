using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
	class MigratoryBirds
	{
		public int migratoryBirds(List<int> arr)
		{
			int highest = 0;

			int num1 = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;

			for(int i = 0; i<arr.Count; i++)
			{
				switch (arr[i])
				{
					case 1:
						num1++;
						break;
					case 2:
						num2++;
						break;
					case 3:
						num3++;
						break;
					case 4:
						num4++;
						break;
					case 5:
						num5++;
						break;
					default:
						break;
				}
			}

			List<int> frequency = new List<int> { num1, num2, num3, num4, num5 };
			int highestNum = 0;

			for(int i = 0; i<frequency.Count; i++)
			{
				if(highest < frequency[i])
				{
					highest = frequency[i];
					highestNum = i + 1;
				}

			}

			return highestNum;
		}
	}
}
