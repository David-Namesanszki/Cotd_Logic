
namespace Cotd_Logic.Repositories
{
	public interface IBaseRepository<T> where T : class
	{
		/// <summary>
		/// Get one object by id.
		/// </summary>
		/// <param name="id">Variable which the search is based on.</param>
		/// <returns>Returns an object.</returns>
		T GetOne(int id);

		/// <summary>
		/// Gets all objects.
		/// </summary>
		/// <returns>Return all objects from the stack.</returns>
		IQueryable<T> GetAll();

		/// <summary>
		/// Inserts an object into the database stack.
		/// </summary>
		/// <param name="entity">An object that is inserted into the databse stack.</param>
		void Insert(T entity);

		/// <summary>
		/// Removes an object from the database stack.
		/// </summary>
		/// <param name="entity">An object that is removed from the database stack.</param>
		void Remove(T entity);
	}
}