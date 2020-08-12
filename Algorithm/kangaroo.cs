using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class kangaroo
    {
        public string Kangaroo(int x1, int v1, int x2, int v2)
        {


            if(x1 > x2)
            {
                if(v1 < v2)
                {
                    int i = 1;
                    while (true)
                    {
                        if((x1+v1*i) == (x2 + v2 * i))
                        {
                            return "YES";
                        }

                        if ((x1 + v1 * i) < (x2 + v2 * i))
                        {
                            return "NO";
                        }

                        i++;
                    }
                }
                else
                {
                    return "NO";
                }
            }else if(x1 < x2)
            {
                if(v1 > v2)
                {
                    int i = 1;
                    while (true)
                    {
                        if ((x1 + v1 * i) == (x2 + v2 * i))
                        {
                            return "YES";
                        }

                        if ((x1 + v1 * i) > (x2 + v2 * i))
                        {
                            return "NO";
                        }

                        i++;
                    }
                }
                else
                {
                    return "NO";
                }
                
            }else
            {
                if(v1 == v2)
                {
                    return "YES";
                }
                else
                {
                    return "NO";
                }
            }

        }
    }
}
