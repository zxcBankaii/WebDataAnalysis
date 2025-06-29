using Microsoft.EntityFrameworkCore;
using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Interfaces;

namespace WebDataAnalysis.Infrastructure.Data.Repositories;

public class DeviceRepository : IDeviceRepository
{
    private readonly WebDataAnalysisDbContext _context;

    public DeviceRepository(WebDataAnalysisDbContext context)
    {
        _context = context;
    }


    public async Task CreateAsync(Device entity)
    {
        await _context.Devices.AddAsync(entity);
    }

    public async Task RemoveAsync(Device entity)
    {
        _context.Devices.Remove(entity);
    }

    public async Task<Device> GetAsync(Guid id)
    {
        return await _context.Devices.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<Device>> GetAllAsync()
    {
        return await _context.Devices.ToListAsync();
    }

    public async Task UpdateAsync(Device entity)
    {
        _context.Devices.Update(entity);
    }
}