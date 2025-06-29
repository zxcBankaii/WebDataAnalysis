using WebDataAnalysis.Domain.Interfaces;
using WebDataAnalysis.Domain.Interfaces.Bases;

namespace WebDataAnalysis.Application.Interfaces;

public interface IUnitOfWork
{
    public IDeviceRepository DeviceRepository { get; }
    public IDeviceMappingRepository DeviceMappingRepository { get; }
    public IDeviceParametersRepository DeviceParametersRepository { get; }
    public IFindDeviceRepository FindDeviceRepository { get; }
    public IParametersRepository ParametersRepository { get; }
    public IRoleRepository RoleRepository { get; }
    public IUserRepository UserRepository { get; }
    public ICategoryRepository CategoryRepository { get; }
    public IStatusDeviceRepository StatusDeviceRepository { get; }
    
    Task SaveChangeAsync(CancellationToken token = default);
}