namespace SANA.Shop.Application.Features.Cart.Dtos.Requests
{
    public class AddToCartRequest
    {
        public Guid CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
