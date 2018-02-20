namespace RandomSite.Models
{
    public interface IShoppableItemModel
    {
        string Name { get; set; }
        string Description { get; set; }
        string ImageUrl { get; set; }
        string BrandUrl { get; set; }
        string BrandName { get; set; }
        int PriceInPennies { get; set; }
        int QuantityInStock { get; set; }
    }
}
