using Microsoft.EntityFrameworkCore;
using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Interfaces;

namespace WebDataAnalysis.Infrastructure.Data.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly WebDataAnalysisDbContext _context;

    public CategoryRepository(WebDataAnalysisDbContext context)
    {
        _context = context;
    }


    public async Task CreateAsync(Category entity)
    {
        await _context.Categories.AddAsync(entity);
    }

    public async Task RemoveAsync(Category entity)
    {
        _context.Categories.Remove(entity);
    }

    public async Task<Category> GetAsync(Guid id)
    {
        return await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<Category>> GetAllAsync()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task UpdateAsync(Category entity)
    {
        _context.Categories.Update(entity);
    }
}