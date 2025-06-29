using Microsoft.EntityFrameworkCore;
using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Interfaces;

namespace WebDataAnalysis.Infrastructure.Data.Repositories;

public class FindDeviceRepository : IFindDeviceRepository
{
    private readonly WebDataAnalysisDbContext _context;

    public FindDeviceRepository(WebDataAnalysisDbContext context)
    {
        _context = context;
    }


    public async Task CreateAsync(FindDevice entity)
    {
        await _context.FindDevices.AddAsync(entity);
    }

    public async Task RemoveAsync(FindDevice entity)
    {
        _context.FindDevices.Remove(entity);
    }

    public async Task<FindDevice> GetAsync(Guid id)
    {
        return await _context.FindDevices.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<FindDevice>> GetAllAsync()
    {
        return await _context.FindDevices.ToListAsync();
    }

    public async Task UpdateAsync(FindDevice entity)
    {
        _context.FindDevices.Update(entity);
    }
}