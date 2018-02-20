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
        public JSONFileReader()
        {
            var text = System.IO.File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "TestData.json"));
            var jsonSerializationHelper = new JSONSerializationHelper();
            var clothingModel = jsonSerializationHelper.GetObjectFromString<ClothingItemModel>(text);
            Console.WriteLine("JSON file output: {0}", clothingModel.Name);
        }
    }
}
