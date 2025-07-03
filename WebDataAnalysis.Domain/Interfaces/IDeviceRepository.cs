using WebDataAnalysis.Domain.Entity;
using WebDataAnalysis.Domain.Interfaces.Bases;

namespace WebDataAnalysis.Domain.Interfaces;

public interface IDeviceRepository : ICreateRepository<Device>, IRemoveRepository<Device>, IGetRepository<Device>, IUpdateRepository<Device>
{
    public Task<List<Device>> GetListByIdCategory(Guid idCategory);
    public Task<List<Device>> GetListByListIdCategories(List<Guid> idCategory);
}