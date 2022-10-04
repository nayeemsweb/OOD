// See https://aka.ms/new-console-template for more information

using Composition;

public class Installer
{
	private readonly Logger _logger;

	public Installer(Logger logger)
	{
		_logger = logger;
	}

	public void Install()
	{
		_logger.Log("Installing...");
	}
}