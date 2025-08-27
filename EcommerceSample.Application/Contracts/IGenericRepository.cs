using EcommerceSample.Domain.Entities;

namespace EcommerceSample.Application.Contracts;
public interface IGenericRepository<TEntity> where TEntity : class
{
    bool Add(TEntity order);
    Task<TEntity> GetById(int id);
    Task<List<TEntity>> GetAll();
}
