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

            //Mapenado todas as classes datatime
            molderbuilder.properties<DateTime>.configure(p => p.HasMaxLength(200));
        }
    }
}