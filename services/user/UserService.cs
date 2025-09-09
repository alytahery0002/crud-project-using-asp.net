using YourProject.Data;
using YourProject.Models;
using Microsoft.EntityFrameworkCore;

namespace YourProject.Services
{ 
    public class UserService : IUserService
{
    private readonly AppDbContext _context;
    public UserService(AppDbContext context) => _context = context;

    public async Task<IEnumerable<User>> GetAllAsync() => await _context.Users.ToListAsync();

    public async Task<User?> GetByIdAsync(int id) => await _context.Users.FindAsync(id);

    public async Task<User> CreateAsync(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }
   }
}