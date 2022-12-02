using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberCodeBootcamp
{
    internal class GetDomainUrl
    {
        public static void PrintDomainUrl()
        {
            List<DomainUrl> tableUrl = Data.TableUrl;

            foreach (var url in tableUrl)
            {
                string subdomain = GetSubDomain(url.WebUrl);
                Console.WriteLine(subdomain);
            }
        }

        private static string GetSubDomain(string webUrl)
        {
            Uri fullPath = new Uri(webUrl);
            string hostName = fullPath.Host;
            string[] domains = hostName.Split(new char[] { '.' });
            string subDomain = domains[0];

            return subDomain;

        }
    }
}
