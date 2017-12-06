using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2lvoc14.Models
{
    public class BancoContext:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Removendo as convençõpes de puralidade um para muitos e muitos para muitos
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Mapenado a classe Conta propriedade DateTime para DateTime2 
            modelBuilder.Entity<Conta>().Property(s => s.DataAbertura).HasColumnType("datetime2");
            //Mapeando  as classes que possuem propriedade do tipo string para varchar(200)
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType ("varchar(200)"));
            //Mapeando o processo CUD
            modelBuilder.Types().Configure(t => t.MapToStoredProcedures());        }
    }
}