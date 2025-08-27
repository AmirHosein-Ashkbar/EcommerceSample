using EcommerceSample.Application.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EcommerceSample.Infrastructure.Presistance.Repositories;
public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly AppDbContext _context;

    public GenericRepository(AppDbContext context)
    {
        _context = context;
    }
    public bool Add(TEntity order)
    {
        try
        {
            _context.Set<TEntity>().Add(order);
            return true;
        }
        catch (Exception ex)
        {

            return false;
        }
    }

    public async Task<List<TEntity>> GetAll()
    {
        return await _context.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity> GetById(int id)
    {
        return await _context.Set<TEntity>().FindAsync(id);
    }
}
