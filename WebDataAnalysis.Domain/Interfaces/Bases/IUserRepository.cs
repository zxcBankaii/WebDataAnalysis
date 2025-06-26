using WebDataAnalysis.Domain.Entity;

namespace WebDataAnalysis.Domain.Interfaces.Bases;

public interface IUserRepository : ICreateRepository<User>, IRemoveRepository<User>, IGetRepository<User>, IUpdateRepository<User>
{
    
}