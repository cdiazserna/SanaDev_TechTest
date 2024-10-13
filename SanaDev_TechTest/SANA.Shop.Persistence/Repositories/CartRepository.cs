using SANA.Shop.Domain.Entities.Cart;
using SANA.Shop.Domain.Entities.Cart.SANA.Shop.Domain.Entities.Cart;
using SANA.Shop.Domain.Repositories;

namespace SANA.Shop.Persistence.Repositories
{
    public class CartRepository : ICartRepository
    {
        private static readonly Dictionary<Guid, Cart> _cartStorage = new();

        public Task AddToCartAsync(Guid cartId, Product product, int quantity)
        {
            if (!_cartStorage.ContainsKey(cartId))
            {
                _cartStorage[cartId] = new Cart { CartId = cartId };
            }

            _cartStorage[cartId].AddItem(product, quantity);
            return Task.CompletedTask;
        }

        public Task<Cart> GetCartAsync(Guid cartId)
        {
            _cartStorage.TryGetValue(cartId, out var cart);
            return Task.FromResult(cart);
        }
    }
}
