using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomSite.Models
{
    public class ClothingItemModel : IShoppableItemModel
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ImageUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string BrandName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string BrandUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PriceInPennies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int QuantityInStock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //unique fields
        public List<string> SizesOffered { get; set; }
        public List<string> ColorsOffered { get; set; }
    }
}
