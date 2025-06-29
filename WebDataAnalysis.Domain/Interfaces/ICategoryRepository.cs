using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Interfaces.Bases;

namespace WebDataAnalysis.Domain.Interfaces;

public interface ICategoryRepository : ICreateRepository<Category>, IRemoveRepository<Category>, IGetRepository<Category>, IUpdateRepository<Category>
{
    
}