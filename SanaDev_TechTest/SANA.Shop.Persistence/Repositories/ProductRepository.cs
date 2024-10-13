using Microsoft.EntityFrameworkCore;
using SANA.Shop.Domain.Entities.Cart;
using SANA.Shop.Domain.Repositories;
using SANA.Shop.Persistence.Context;

namespace SANA.Shop.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Product> GetByIdAsync(int productId)
        {
            return await _context.Products.FindAsync(productId);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
