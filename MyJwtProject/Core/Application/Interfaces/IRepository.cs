using System.Linq.Expressions;

namespace MyJwtProject.Core.Application.Interfaces
{
	public interface IRepository<T> where T : class,new()
	{
		Task<List<T>> GetAllAsync();
		Task<T?> GetByIdAsync(object id);
		Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter);

		Task CreateAsync(T entity);
		Task UpdateAsync(T entity);
		Task RemoveAsync(T entity);

	}
}
//TQZFQ-977YS-GGXTY-YZ3CW-76V2C