using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Interfaces.Bases;

namespace WebDataAnalysis.Domain.Interfaces;

public interface IDeviceParametersRepository : ICreateRepository<DeviceMapping>, IRemoveRepository<DeviceMapping>, IGetRepository<DeviceMapping>
{
    
}