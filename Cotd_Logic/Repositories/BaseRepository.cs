using Microsoft.EntityFrameworkCore;

namespace Cotd_Logic.Repositories;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
{
	/// <summary>
	/// Initializes a new instance of the <see cref="BaseRepository{T}"/> class.
	/// Makes a connection with the data layer.
	/// </summary>
	/// <param name="ctx">The database context from the data layer.</param>
	protected BaseRepository(DbContext ctx)
	{
		this.Ctx = ctx;
	}

	/// <summary>
	/// Gets or sets the database context.
	/// </summary>
	public DbContext Ctx { get; set; }

	/// <inheritdoc/>
	public IQueryable<T> GetAll()
	{
		return this.Ctx.Set<T>();
	}

	/// <inheritdoc/>
	public abstract T GetOne(int id);

	/// <inheritdoc/>
	public void Insert(T entity)
	{
		this.Ctx.Set<T>().Add(entity);
		this.Ctx.SaveChanges();
	}

	/// <inheritdoc/>
	public void Remove(T entity)
	{
		this.Ctx.Set<T>().Remove(entity);
		this.Ctx.SaveChanges();
	}
}
