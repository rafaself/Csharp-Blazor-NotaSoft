using NotaSoftDb.Models;

namespace NotaSoftDb.Repositories;

public class InvoiceRepository : BaseRepository<Invoice>
{
	public InvoiceRepository(CustomDbContext dbContext) : base(dbContext)
	{
	}
}
