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

            //var queryOrderDataTables = dataTables.OrderBy(col => col.Field2);

            CoupleRows(dataTables);
        }

        public static List<List<DataTable>> CoupleRows(List<DataTable> dataTables)
        {
            List<List<DataTable>> listCoupleRows = new List<List<DataTable>>()
            {
                //new List<DataTable> {new DataTable("row1", 2, 'S')},
                //new List<DataTable> {new DataTable("row2", 2, 'A')},
                //new List<DataTable> {new DataTable("row1", 3, 'S')},
                //new List<DataTable> {new DataTable("row2", 3, 'A')},
            };
            List<DataTable> coupleRows = new List<DataTable>();


            for(int i = 1; i < dataTables.Count; i++)
            {
                if (dataTables[i].Field2 == dataTables[i - 1].Field2)
                {

                }
            }
            //Print(listCoupleRows);

            return listCoupleRows;
        }

        //private static void Print(List<List<DataTable>> list)
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        for (int j = 0; j < list[i].Count; j++)
        //        {

        //        }
        //    }
        //}
    }
}
