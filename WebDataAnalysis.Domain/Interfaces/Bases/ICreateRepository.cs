namespace WebDataAnalysis.Domain.Interfaces.Bases;

public interface ICreateRepository<T> where T : class
{
    public Task CreateAsync(T entity);
}