using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomSite.Models
{
    public class ClothingItemModel// : IShoppableItemModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }
        [JsonProperty("brandName")]
        public string BrandName { get; set; }
        [JsonProperty("brandUrl")]
        public string BrandUrl { get; set; }
        [JsonProperty("priceInPennies")]
        public int PriceInPennies { get; set; }
        [JsonProperty("quantityInStock")]
        public int QuantityInStock { get; set; }

        //unique fields
        [JsonProperty("sizesOffered")]
        public List<string> SizesOffered { get; set; }
        [JsonProperty("colorsOffered")]
        public List<string> ColorsOffered { get; set; }
    }
}
