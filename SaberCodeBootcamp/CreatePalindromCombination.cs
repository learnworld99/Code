using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberCodeBootcamp
{
    internal class CreatePalindromCombination
    {
       
        //static public void MainCreateCombinationPalindrom()
        //{
        //    int input = 761165575;
        //    char[] arr = input.ToString().ToCharArray();

        //    Run(arr);
        //}

        //private static void Run(char[] arr)
        //{
        //    List<string> k_combs = new List<string>();

        //    Stack<char> combs = new Stack<char>();

        //    for (int k = 1; k < arr.Length; k++)
        //    {
        //        k_combs = K_Combination(arr, k);
        //        for (int i = 0; i < k_combs.Count; i++)
        //        {
        //            combs.Push(k_combs[i].ToCharArray().);
        //        }
        //    }

        //}

        //private static List<char> K_Combination(List<char> arr, int k)
        //{
        //    List<char> combs = new List<char>();
        //    List<char> head = new List<char>();
        //    List<char> tailcombs = new List<char>();


        //    if (k > arr.Count || k <= 0)
        //        return null;
        //    if (k == arr.Count)
        //         combs.Add(arr);

        //    if(k == 1)
        //    {
        //        for (int i = 0; i < arr.Count; i++)
        //        {
        //            combs.Add(arr[i]);
        //        }

        //        return combs;
        //    }

        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        head = arr.ToList().GetRange(i, i + 1);
        //        tailcombs = K_Combination(arr.ToList().GetRange(i + 1),  k - 1);
        //    }
        //}
    }
}
