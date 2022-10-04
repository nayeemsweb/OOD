using Composition;

var logger = new Logger();

var dbMigrator = new DbMigrator(logger);
dbMigrator.Migrate();

var installer = new Installer(logger);
installer.Install();