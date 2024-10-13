namespace SANA.Shop.Domain.Entities.Cart
{
    namespace SANA.Shop.Domain.Entities.Cart
    {
        public class CartItem
        {
            public int CartItemId { get; set; }
            public int ProductId { get; set; }
            public Product Product { get; set; }
            public int Quantity { get; set; }
        }
    }
}
