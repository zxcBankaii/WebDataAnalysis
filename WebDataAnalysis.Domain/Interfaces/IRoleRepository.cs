using WebDataAnalysis.Domain.Entity;

namespace WebDataAnalysis.Domain.Interfaces.Bases;

public interface IRoleRepository : ICreateRepository<Role>, IRemoveRepository<Role>, IGetRepository<Role>, IUpdateRepository<Role>
{
    
}