using YourProject.Data;
using YourProject.Models;
using Microsoft.EntityFrameworkCore;


namespace YourProject.Services
{
public class CategoryService : ICategoryService
{
    private readonly AppDbContext _context;
    public CategoryService(AppDbContext context) => _context = context;

    public async Task<IEnumerable<Category>> GetAllAsync() => await _context.Categories.ToListAsync();

    public async Task<Category?> GetByIdAsync(int id) => await _context.Categories.FindAsync(id);

    public async Task<Category> CreateAsync(Category category)
    {
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();
        return category;
    }
}}