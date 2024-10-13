using SANA.Shop.Domain.Entities.Cart;
using SANA.Shop.Domain.Entities.Cart.SANA.Shop.Domain.Entities.Cart;

namespace SANA.Shop.Domain.Repositories
{
    public interface ICartRepository
    {
        Task AddToCartAsync(Guid cartId, Product product, int quantity);
        Task<Cart> GetCartAsync(Guid cartId);
    }
}
