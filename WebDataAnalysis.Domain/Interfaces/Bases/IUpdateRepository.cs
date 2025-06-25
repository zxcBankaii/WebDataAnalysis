namespace WebDataAnalysis.Domain.Interfaces.Bases;

public interface IUpdateRepository<T> where T : class
{
    public Task UpdateAsync(T entity);
}