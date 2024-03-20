using NotaSoftDb.Repositories.Interfaces;

namespace NotaSoftDb.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
	CustomDbContext _dbContext;

    public BaseRepository(CustomDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Create(TEntity entity)
	{
		_dbContext.Add(entity);
	}
}
