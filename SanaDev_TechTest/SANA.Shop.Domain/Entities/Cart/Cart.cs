namespace SANA.Shop.Domain.Entities.Cart
{
    namespace SANA.Shop.Domain.Entities.Cart
    {
        public class Cart
        {
            public Guid CartId { get; set; }
            public List<CartItem> Items { get; set; } = new List<CartItem>();

            public void AddItem(Product product, int quantity)
            {
                Items.Add(new CartItem { Product = product, Quantity = quantity });
            }
        }
    }
}
