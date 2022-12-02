using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberCodeBootcamp
{
    internal class CreatePalindromCombination
    {
       
        static public void MainCreateCombinationPalindrom()
        {
            int input = 761165575;
            char[] arr = input.ToString().ToCharArray();

            Run(arr);
        }

        private static void Run(char[] arr)
        {
            List<string> k_combs = new List<string>();

            Stack<char> combs = new Stack<char>();

            for (int k = 1; k < arr.Length; k++)
            {
                k_combs = K_Combination(arr, k);
                for (int i = 0; i < k_combs.Count; i++)
                {
                    combs.Push(k_combs[i].ToCharArray().);
                }
            }

        }

        private static List<string> K_Combination(char[] arr, int k)
        {
            if (k > arr.Length || k <= 0)
                return null;
            if (k == arr.Length)
                return String.Concat(arr);

            if(k == 1)
            {
                Stack<string> combs = new Stack<string>();

                for (int i = 0; i < arr.Length; i++)
                {
                    combs.Push(string.Concat(arr[i]));
                }

                return combs;
            }
        }
    }
}
