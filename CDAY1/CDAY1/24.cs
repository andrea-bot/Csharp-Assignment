using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDAY1
{
    public static class Count24
    {
        public static void Count()
        {
            int max = 24;
            for (int step = 1; step <= 4; step++)
            {
                for (int i = 0; i <= max; i += step)
                {
                    Console.Write(i);
                    Console.Write(',');
                }
                Console.WriteLine();
            }
        }
    }
}
