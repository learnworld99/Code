using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberCodeBootcamp
{
    internal class LoopingPattern
    {
        public static void MainLoop()
        {
            int n = 7;
            string pattern = string.Concat(Enumerable.Repeat("*#%", n));

            for (int i = 0; i < n; i++)
            {
                string temp = string.Empty;

                for (int j = 0; j <= i; j++)
                {
                    temp += pattern[j];
                }
                Console.Write(temp);
                Console.WriteLine();

            }
        }
    }
}
