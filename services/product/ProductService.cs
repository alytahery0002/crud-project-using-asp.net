using YourProject.Data;
using YourProject.Models;
using Microsoft.EntityFrameworkCore;

namespace YourProject.Services
{
public class ProductService : IProductService
{
    private readonly AppDbContext _context;
    public ProductService(AppDbContext context) => _context = context;

    public async Task<IEnumerable<Product>> GetAllAsync() =>
        await _context.Products.Include(p => p.Category).ToListAsync();

    public async Task<Product?> GetByIdAsync(int id) =>
        await _context.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);

    public async Task<Product> CreateAsync(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return product;
    }
}
}