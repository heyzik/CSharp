using Microsoft.EntityFrameworkCore;
using Casino.Models;


public class AppDbContext : DbContext
{
	public DbSet<Account> Accounts => Set<Account>();
	public AppDbContext() => Database.EnsureCreated();

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("Data Source=casino.db");
	}

	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}

