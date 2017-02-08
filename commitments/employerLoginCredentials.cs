using System.IO;
using System.Linq;

namespace Commitments
{
    internal class employerLoginCredentials
    {
        public string email { get; set; }
        public string password { get; set; }
        public string use { get; set; }

        public employerLoginCredentials(string email, string password, string use)
        {
            this.email = email;
            this.password = password;
            this.use = use;
        }

        public static employerLoginCredentials[] LoadContacts(string csvFile)
        {
            return File.ReadLines(csvFile).Select(CreateFromCsvLine).ToArray();
        }
        private static readonly char[] separator = new[] { ',' };

        private static employerLoginCredentials CreateFromCsvLine(string line)
        {
            string[] split = line.Split(separator);
            return new employerLoginCredentials(split[0], split[1], split[2]);
        }
    }

}