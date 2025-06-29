using Microsoft.EntityFrameworkCore;
using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Interfaces;

namespace WebDataAnalysis.Infrastructure.Data.Repositories;

public class ParameteresRepository : IParametersRepository
{
    private readonly WebDataAnalysisDbContext _context;

    public ParameteresRepository(WebDataAnalysisDbContext context)
    {
        _context = context;
    }


    public async Task CreateAsync(Parameteres entity)
    {
        await _context.Parameteres.AddAsync(entity);
    }

    public async Task RemoveAsync(Parameteres entity)
    {
        _context.Parameteres.Remove(entity);
    }

    public async Task<Parameteres> GetAsync(Guid id)
    {
        return await _context.Parameteres.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<Parameteres>> GetAllAsync()
    {
        return await _context.Parameteres.ToListAsync();
    }

    public async Task UpdateAsync(Parameteres entity)
    {
        _context.Parameteres.Update(entity);
    }
}