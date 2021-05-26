using kurtProje.ToDo.Dataaccess.Concreate.EntityFreamworkCore.Mapping;
using kurtProje.ToDo.Entities.concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace kurtProje.ToDo.Dataaccess.Concreate.EntityFreamworkCore.Contexts
{
    public class TodoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=FATIH\\SQLEXPRESS;database=udemyBlogToDo; integrated security=true; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KullaniciMap());
            modelBuilder.ApplyConfiguration(new CalismaMap());

        }

        internal object Entry(object tablo)
        {
            throw new NotImplementedException();
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Calisma> Calismalar { get; set; }
    }

        
}
