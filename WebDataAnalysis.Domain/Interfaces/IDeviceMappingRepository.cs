using WebDataAnalysis.Domain.Entity;

namespace WebDataAnalysis.Domain.Interfaces.Bases;

public interface IDeviceMappingRepository : ICreateRepository<DeviceMapping>, IRemoveRepository<DeviceMapping>, IGetRepository<DeviceMapping>
{
    
}