namespace TuristDB_App.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TuristDB_App.TouristDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TuristDB_App.TouristDbContext context)
        {
            ReadData data = new ReadData();
            data.ReadDataOnFile();
        }
    }
}
