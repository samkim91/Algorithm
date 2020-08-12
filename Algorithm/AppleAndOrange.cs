using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class AppleAndOrange
    {
        void countApplesAndOranges(int s, int t, int a, int b, int [] apples, int [] oranges)
        {
            // s 범위의 시작, t 범위의 끝
            // a 애플나무 위치 b 오렌지 나무 위치
            // apples 떨어지는 애플의 위치들
            // oranges 떨어지는 오렌지의 위치들

            int appleNum = 0;
            int orangeNum = 0;

            foreach(int distance in apples)
            {
                int posi = a + distance;

                if(posi>=s && posi <= t)
                {
                    appleNum++;
                }
            }

            foreach(int distance in oranges)
            {
                int posi = b + distance;

                if(posi>=s && posi <= t)
                {
                    orangeNum++;
                }
            }

            Console.WriteLine(appleNum);
            Console.WriteLine(orangeNum);
            
        }
    }
}
