using Microsoft.EntityFrameworkCore;
using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Interfaces;

namespace WebDataAnalysis.Infrastructure.Data.Repositories;

public class StatusDeviceRepository : IStatusDeviceRepository
{
    private readonly WebDataAnalysisDbContext _context;

    public StatusDeviceRepository(WebDataAnalysisDbContext context)
    {
        _context = context;
    }


    public async Task CreateAsync(StatusDevice entity)
    {
        await _context.StatusDevices.AddAsync(entity);
    }

    public async Task RemoveAsync(StatusDevice entity)
    {
        _context.StatusDevices.Remove(entity);
    }

    public async Task<StatusDevice> GetAsync(Guid id)
    {
        return await _context.StatusDevices.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<StatusDevice>> GetAllAsync()
    {
        return await _context.StatusDevices.ToListAsync();
    }

    public async Task UpdateAsync(StatusDevice entity)
    {
        _context.StatusDevices.Update(entity);
    }
}