using WebDataAnalysis.Domain.Entity;

namespace WebDataAnalysis.Domain.Interfaces.Bases;

public interface IUserRepository : ICreateRepository<Role>, IRemoveRepository<Role>, IGetRepository<Role>, IUpdateRepository<Role>
{
    
}