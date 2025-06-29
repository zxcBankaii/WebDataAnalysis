using Microsoft.EntityFrameworkCore;
using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Interfaces.Bases;

namespace WebDataAnalysis.Infrastructure.Data.Repositories;

public class RoleRepository : IRoleRepository
{
    private readonly WebDataAnalysisDbContext _context;

    public RoleRepository(WebDataAnalysisDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(Role entity)
    {
        await _context.Roles.AddAsync(entity);
    }

    public async Task RemoveAsync(Role entity)
    {
        _context.Roles.Remove(entity);
    }

    public async Task<Role> GetAsync(Guid id)
    {
        return await _context.Roles.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<Role>> GetAllAsync()
    {
        return await _context.Roles.ToListAsync();
    }

    public async Task UpdateAsync(Role entity)
    {
        _context.Roles.Update(entity);
    }
}