using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Interfaces.Bases;

namespace WebDataAnalysis.Domain.Interfaces;

public interface IDeviceParametersRepository : ICreateRepository<DeviceParameters>, IRemoveRepository<DeviceParameters>, IGetRepository<DeviceParameters>
{
    
}