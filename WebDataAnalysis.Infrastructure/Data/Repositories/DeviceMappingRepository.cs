using Microsoft.EntityFrameworkCore;
using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Interfaces.Bases;

namespace WebDataAnalysis.Infrastructure.Data.Repositories;


public class DeviceMappingRepository : IDeviceMappingRepository
{

    private readonly WebDataAnalysisDbContext _context;

    public DeviceMappingRepository(WebDataAnalysisDbContext context)
    {
        _context = context;
    }


    public async Task CreateAsync(DeviceMapping entity)
    {
        await _context.DeviceMappings.AddAsync(entity);
    }

    public async Task RemoveAsync(DeviceMapping entity)
    {
        _context.DeviceMappings.Remove(entity);
    }

    public async Task<DeviceMapping> GetAsync(Guid id)
    {
        return await _context.DeviceMappings.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<DeviceMapping>> GetAllAsync()
    {
        return await _context.DeviceMappings.ToListAsync();
    }

    public async Task<List<DeviceMapping>> GetListByListIdDevices(List<Guid> idDevices)
    {
        return await _context.DeviceMappings.Where(x => idDevices.Contains(x.Device.Id)).ToListAsync();
    }

    public async Task<List<DeviceMapping>> GetListByIdDevices(Guid idDevice)
    {
        return await _context.DeviceMappings.Where(x => x.Device.Id == idDevice).ToListAsync();
    }
}