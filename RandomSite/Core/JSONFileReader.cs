using RandomSite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RandomSite.Core
{
    public class JSONFileReader
    {
        public JSONFileReader() { }
        public TObject ReadFile<TObject>(string filename)
        {
            var text = System.IO.File.ReadAllText(Path.Combine(Environment.CurrentDirectory, filename));
            var jsonSerializationHelper = new JSONSerializationHelper();
            return jsonSerializationHelper.GetObjectFromString<TObject>(text);
        }
    }
}
