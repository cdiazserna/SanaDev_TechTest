namespace SANA.Shop.Domain.Entities.Cart
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
