using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Interfaces.Bases;

namespace WebDataAnalysis.Domain.Interfaces;

public interface IParametersRepository : ICreateRepository<Parameteres>, IRemoveRepository<Parameteres>, IGetRepository<Parameteres>, IUpdateRepository<Parameteres>
{
    
}