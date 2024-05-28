using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models.MetaDBContext;

namespace Models.Common;

public class GenericRepository<T> : IGenericRepository<T> where T: class
{
    protected readonly MetasolDBContext _dbContext;
    protected DbSet<T> dbSet;
    protected readonly ILogger _logger = null!;
    public GenericRepository(MetasolDBContext dbContext, ILogger logger)
    {
        _dbContext = dbContext;
        _logger = logger;
        this.dbSet = _dbContext.Set<T>();
    }
    public virtual async Task<T?> GetById(int id)
    {
        try
        {
            return await dbSet.FindAsync(id);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error getting entity with id {Id}", id);
            return null;
        }
    }

    public virtual async Task<IEnumerable<T>>  GetAll()
    {
        return await dbSet.ToListAsync();
    }

    public async Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> expression)
    {
        return await dbSet.Where(expression).ToListAsync();
    }

    public virtual async Task<bool> Create(T entity)
    {
        try
        {
            await dbSet.AddAsync(entity);
            return true;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error adding entity");
            return false;
        }
    }
    public void Update(T entity)
    {
        dbSet.Update(entity);
    }
    public virtual async Task<bool> Delete(int id)
    {
        try
        {
            var entity = await dbSet.FindAsync(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                return true;
            }
            else
            {
                _logger.LogWarning("Entity with id {Id} not found for deletion", id);
                return false;
            }
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error deleting entity with id {Id}", id);
            return false;
        }
    }
}