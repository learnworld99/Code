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
    }
}
