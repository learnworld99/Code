using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberCodeBootcamp
{
    internal class Data
    {
        public static List<DomainUrl> TableUrl = new List<DomainUrl>
        {
            new DomainUrl(1, "https://id.bitdegree.org"),
            new DomainUrl(2, "https://finance.detik.com"),
            new DomainUrl(3, "https://telkom.co.id"),
            new DomainUrl(4, "https://corona.jakarta.co.id")
        };

        public static List<DataTable> DataTables = new List<DataTable>
        {
            new DataTable("row1", 2, 'S'),
            new DataTable("row2", 2, 'A'),
            new DataTable("row3", 1, 'S'),
            new DataTable("row4", 3, 'S'),
            new DataTable("row5", 1, 'A'),
            new DataTable("row6", 4, 'A'),
            new DataTable("row7", 5 , 'S'),
            new DataTable("row8", 5, 'A')
        };
    }

    public class DomainUrl
    {
        public int Id { get; set; }
        public string WebUrl { get; set; }

        public DomainUrl(int id, string webUrl)
        {
            Id = id;
            WebUrl = webUrl;
        }
    }

    public class DataTable
    {
        public string Field1 { get; set; }
        public int Field2 { get; set; }
        public char Field3 { get; set; }

        public DataTable(string field1, int field2, char field3)
        {
            Field1 = field1;
            Field2 = field2;
            Field3 = field3;
        }
    }
}
