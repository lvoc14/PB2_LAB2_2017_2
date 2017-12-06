namespace WebAppProva2bLab2lvoc14.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppProva2bLab2lvoc14.Models.BancoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "WebAppProva2bLab2lvoc14.Models.BancoContext";
        }

        protected override void Seed(WebAppProva2bLab2lvoc14.Models.BancoContext context)
        {
            
        }
    }
}
