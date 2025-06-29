using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Interfaces.Bases;

namespace WebDataAnalysis.Domain.Interfaces;

public interface IStatusDeviceRepository : ICreateRepository<StatusDevice>, IRemoveRepository<StatusDevice>, IGetRepository<StatusDevice>, IUpdateRepository<StatusDevice>
{
    
}