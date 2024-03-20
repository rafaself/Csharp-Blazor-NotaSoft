namespace NotaSoftDb.Repositories.Interfaces;

public interface IBaseRepository<in TEntity> where TEntity : class
{
	void Create(TEntity entity);
}
