using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Interfaces.Bases;

namespace WebDataAnalysis.Domain.Interfaces;

public interface IParametersRepository : ICreateRepository<Device>, IRemoveRepository<Device>, IGetRepository<Device>, IUpdateRepository<Device>
{
    
}