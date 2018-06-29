using System;

namespace ClassAssociation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance

            // var text = new Text();
            // text.Width = 100;
            // text.Copy();

            // Composition

            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
