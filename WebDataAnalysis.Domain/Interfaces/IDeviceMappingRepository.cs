using WebDataAnalysis.Domain.Entity;

namespace WebDataAnalysis.Domain.Interfaces.Bases;

public interface IDeviceMappingRepository : ICreateRepository<DeviceMapping>, IRemoveRepository<DeviceMapping>, IGetRepository<DeviceMapping>
{
    public Task<List<DeviceMapping>> GetListByListIdDevices(List<Guid> idDevices);
    public Task<List<DeviceMapping>> GetListByIdDevices(Guid idDevice);
}