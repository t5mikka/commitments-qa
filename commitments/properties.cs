using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Commitments
{
    internal class getPropertiesFile
    {
        public string dataValue { get; set; }

        public getPropertiesFile(string dataValue)
        {
            this.dataValue = dataValue;
        }

        public static getPropertiesFile[] LoadProperties(string csvFile)
        {
            return File.ReadLines(csvFile).Select(CreateFromCsvLine).ToArray();
        }
        private static readonly char[] separator = new[] { ',' };

        private static getPropertiesFile CreateFromCsvLine(string line)
        {
            string[] split = line.Split(separator);
            return new getPropertiesFile(split[1]);
        }
    }
}
