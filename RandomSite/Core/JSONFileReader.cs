using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RandomSite.Core
{
    public class JSONFileReader
    {
        public JSONFileReader()
        {
            string text = System.IO.File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "TestData.json"));
            Console.WriteLine("JSON file output: {0}", text);
        }
    }
}
