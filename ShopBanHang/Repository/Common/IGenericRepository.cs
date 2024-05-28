using System.Linq.Expressions;
namespace Models.Common;

public interface IGenericRepository<T> where T: class
{
    Task<T?> GetById(int id);
    Task<IEnumerable<T>> GetAll();
    Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> expression);
    Task<bool> Create(T entity);
    void Update(T entity);
    Task<bool> Delete(int id);
}