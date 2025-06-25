namespace WebDataAnalysis.Domain.Interfaces.Bases;

public interface IGetRepository<T> where T : class
{
    public Task<T> GetAsync(Guid id);
    public Task<List<T>> GetAllAsync(T entity);
}