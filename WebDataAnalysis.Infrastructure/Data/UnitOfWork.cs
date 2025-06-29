using WebDataAnalysis.Application.Interfaces;
using WebDataAnalysis.Domain.Interfaces;
using WebDataAnalysis.Domain.Interfaces.Bases;
using WebDataAnalysis.Infrastructure.Data.Repositories;

namespace WebDataAnalysis.Infrastructure.Data;

public class UnitOfWork: IUnitOfWork
{

    private readonly WebDataAnalysisDbContext _context;

    private DeviceMappingRepository _deviceMappingRepository;
    private DeviceParametersRepository _deviceParametersRepository;
    private DeviceRepository _deviceRepository;
    private FindDeviceRepository _findDeviceRepository;
    private ParameteresRepository _parameteresRepository;
    private RoleRepository _roleRepository;
    private UserRepository _userRepository;
    private CategoryRepository _categoryRepository;
    private StatusDeviceRepository _statusDeviceRepository;

    public UnitOfWork(WebDataAnalysisDbContext context)
    {
        _context = context;
    }
    
    
    public IDeviceRepository DeviceRepository
    {
        get => _deviceRepository;
    } 
    public IDeviceMappingRepository DeviceMappingRepository
    {
        get => _deviceMappingRepository;
    }
    public IDeviceParametersRepository DeviceParametersRepository
    {
        get => _deviceParametersRepository;
    }
    public IFindDeviceRepository FindDeviceRepository
    {
        get => _findDeviceRepository;
    }
    public IParametersRepository ParametersRepository
    {
        get => _parameteresRepository;
    }
    public IRoleRepository RoleRepository
    {
        get => _roleRepository;
    }
    public IUserRepository UserRepository
    {
        get => _userRepository;
    }
    public ICategoryRepository CategoryRepository
    {
        get => _categoryRepository;
    }
    public IStatusDeviceRepository StatusDeviceRepository
    {
        get => _statusDeviceRepository;
    }

    public async Task SaveChangeAsync(CancellationToken token = default)
    {
        await _context.SaveChangesAsync(token);
    }
}