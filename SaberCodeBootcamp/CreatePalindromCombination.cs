using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberCodeBootcamp
{
    internal class CreatePalindromCombination
    {
        public static void MainCreateCombinationPalindrom()
        {
            int values = 761165575;

<<<<<<< HEAD
            //Run(arr);
        }

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

        //private static List<string> K_Combination(char[] arr, int k)
        //{
        //    if (k > arr.Length || k <= 0)
        //        return null;
        //    if (k == arr.Length)
        //        return String.Concat(arr);

        //    if(k == 1)
        //    {
        //        Stack<string> combs = new Stack<string>();

        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            combs.Push(string.Concat(arr[i]));
        //        }

        //        return combs;
        //    }
        //}
=======
            List<char> allValues = values.ToString().ToCharArray().ToList();

            var createCombinations = new CreatePalindromCombination();
            var combinationsGroup = createCombinations.produceList(allValues);

            List<string> palindromValues = new List<string>();

            foreach (var combs in combinationsGroup)
            {
                string strCombs = string.Concat(combs);

                if(strCombs.Length >= 2)
                {
                    bool isPalindrom = CheckPalindrom(strCombs);
                    if(isPalindrom) palindromValues.Add(strCombs);
                }
            }
            foreach (var item in palindromValues)
            {
                Console.WriteLine(item);
            }

        }

        private static bool CheckPalindrom(string strCombs)
        {
            bool valid = true;
            int indexFromBack = strCombs.Length - 1;

            for (int i = 0; i < strCombs.Length; i++)
            {
                if (strCombs[i] != strCombs[indexFromBack])
                {
                    valid = false;
                    break;
                }
                indexFromBack--;
            }

            return valid;
        }

        private IEnumerable<int> constructSetFromBits(int i)
        {
            for (int n = 0; i != 0; i /= 2, n++)
            {
                if ((i & 1) != 0)
                    yield return n;
            }
        }

        //List<string> allValues = new List<string>()
        //{ "A1", "A2", "A3", "B1", "B2", "C1" };

        private IEnumerable<List<char>> produceEnumeration(List<char> allValues)
        {
            for (int i = 0; i < (1 << allValues.Count); i++)
            {
                yield return
                    constructSetFromBits(i).Select(n => allValues[n]).ToList();
            }
        }

        public  List<List<char>> produceList(List<char> allValues)
        {
            return produceEnumeration(allValues).ToList();
        }
>>>>>>> 54629e989dacb63bd934b72b4d030d0b5a254935
    }
}
