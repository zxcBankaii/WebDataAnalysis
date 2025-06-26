using Microsoft.EntityFrameworkCore;
using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Interfaces;

namespace WebDataAnalysis.Infrastructure.Data.Repositories;

public class DeviceParametersRepository : IDeviceParametersRepository
{

    private readonly WebDataAnalysisDbContext _context;

    public DeviceParametersRepository(WebDataAnalysisDbContext context)
    {
        _context = context;
    }


    public async Task CreateAsync(DeviceParameters entity)
    {
        await _context.DeviceParameters.AddAsync(entity);
    }

    public async Task RemoveAsync(DeviceParameters entity)
    {
        _context.DeviceParameters.Remove(entity);
    }

    public async Task<DeviceParameters> GetAsync(Guid id)
    {
        return await _context.DeviceParameters.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<DeviceParameters>> GetAllAsync(DeviceParameters entity)
    {
        return await _context.DeviceParameters.ToListAsync();
    }
}