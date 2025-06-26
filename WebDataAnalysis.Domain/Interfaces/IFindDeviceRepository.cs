using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Interfaces.Bases;

namespace WebDataAnalysis.Domain.Interfaces;

public interface IFindDeviceRepository : ICreateRepository<FindDevice>, IRemoveRepository<FindDevice>, IGetRepository<FindDevice>, IUpdateRepository<FindDevice>
{
    
}