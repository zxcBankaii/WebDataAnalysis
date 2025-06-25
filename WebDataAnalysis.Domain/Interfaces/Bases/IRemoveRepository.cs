namespace WebDataAnalysis.Domain.Interfaces.Bases;

public interface IRemoveRepository<T> where T : class
{
    public Task RemoveAsync(T entity);
}