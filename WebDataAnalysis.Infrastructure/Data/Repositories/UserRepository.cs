using Microsoft.EntityFrameworkCore;
using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Interfaces.Bases;

namespace WebDataAnalysis.Infrastructure.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly WebDataAnalysisDbContext _context;

    public UserRepository(WebDataAnalysisDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(User entity)
    {
        await _context.Users.AddAsync(entity);
    }

    public async Task RemoveAsync(User entity)
    {
        _context.Users.Remove(entity);
    }

    public async Task<User> GetAsync(Guid id)
    {
        return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<User>> GetAllAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task UpdateAsync(User entity)
    {
        _context.Users.Update(entity);
    }
}