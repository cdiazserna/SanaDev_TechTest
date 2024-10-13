using SANA.Shop.Domain.Entities.Cart;

namespace SANA.Shop.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int productId);
        Task<IEnumerable<Product>> GetAllAsync();
    }
}
