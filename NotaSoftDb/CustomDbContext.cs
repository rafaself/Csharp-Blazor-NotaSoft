using Microsoft.EntityFrameworkCore;

namespace NotaSoftDb;

public class CustomDbContext : DbContext
{
    public CustomDbContext()
    {
     
    }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		var connectionString =
			"User ID=root;" +
			"Password=myPassword;" +
			"Host=localhost;" +
			"Port=5432;" +
			"Database=myDataBase;";

		optionsBuilder.UseNpgsql(connectionString);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
	}

}
