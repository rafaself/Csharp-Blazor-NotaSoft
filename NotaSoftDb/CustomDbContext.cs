using Microsoft.EntityFrameworkCore;
using NotaSoftDb.Models;

namespace NotaSoftDb;

public class CustomDbContext : DbContext
{
	public DbSet<Invoice> Invoices { get; set; }

    public CustomDbContext()
    {
     
    }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		var connectionString =
			"User ID=root;" +
			"Password=rafa123;" +
			"Host=localhost;" +
			"Port=5432;" +
			"Database=entitystudy;";

		optionsBuilder.UseNpgsql(connectionString);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
	}

}
