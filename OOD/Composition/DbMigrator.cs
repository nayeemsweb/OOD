// See https://aka.ms/new-console-template for more information
using Composition;

public class DbMigrator
{
	private readonly Logger _logger;

	public DbMigrator(Logger logger)
	{
		_logger = logger;
	}

	public void Migrate()
	{
		_logger.Log("Migrating...");
	}
}