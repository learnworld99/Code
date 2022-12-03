using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberCodeBootcamp
{
    internal class AssociateArray
    {
        public static void MainAssociateArray()
        {
            var dataTables = Data.DataTables;
            var arrayOfArrays = CoupleRows(dataTables);

            var prettyArray = PrettyPrintArrayOfArrays(arrayOfArrays);
            Console.WriteLine(prettyArray);

        }

        public static List<string[]> CoupleRows(List<DataTable> dataTables)
        {
            var groupDtByField2 = dataTables.OrderBy(o => o.Field2).ThenByDescending(o => o.Field3).GroupBy(g => g.Field2).ToArray();
            var listCoupleRows = new List<string[]>();

            foreach (var dt in groupDtByField2)
            {
                var arrCoupleRows = new string[2];

                var item = dt.ToList();
                var findField_S = item.Find(f => f.Field3.ToString().ToLower() == "s");
                var findField_A = item.Find(f => f.Field3.ToString().ToLower() == "a");

                var field_S = findField_S != null && findField_S?.Field3.ToString().ToLower() == "s" ? findField_S.Field1 : "";
                var field_A = findField_A != null && findField_A?.Field3.ToString().ToLower() == "a" ? findField_A.Field1 : "";

                arrCoupleRows[0] = "\"" + field_S + "\"";
                arrCoupleRows[1] = "\"" + field_A + "\"";

                listCoupleRows.Add(arrCoupleRows);
            }

            return listCoupleRows;
        }

        public static string PrettyPrintArrayOfArrays(List<string[]> arrayOfArrays)
        {
            if (arrayOfArrays == null)
                return "";

            var prettyArrays = new string[arrayOfArrays.Count()];

            for (int i = 0; i < arrayOfArrays.Count(); i++)
            {
                prettyArrays[i] = "[" + String.Join(",", arrayOfArrays[i]) + "]";
            }

            return "[" + String.Join(",", prettyArrays) + "]";
        }
    }
}
