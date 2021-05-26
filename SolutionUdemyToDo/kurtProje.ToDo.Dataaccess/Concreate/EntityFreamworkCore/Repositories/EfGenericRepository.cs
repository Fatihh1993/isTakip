using kurtProje.ToDo.Dataaccess.Concreate.EntityFreamworkCore.Contexts;
using kurtProje.ToDo.Dataaccess.Interfaces;
using kurtProje.ToDo.Entities.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kurtProje.ToDo.Dataaccess.Concreate.EntityFreamworkCore.Repositories
{
    public class EfGenericRepository<Tablo> : IGenericDal<Tablo>
        where Tablo : class, ITablo, new()
    {
        public List<Tablo> GetirHepsi()
        {
            
            using var context = new TodoContext();
            return context.Set<Tablo>().ToList();
        }

        public Tablo GetirIdile(int id)
        {
            using var context = new TodoContext();
            return context.Set<Tablo>().Find();

        }

        public void Guncelle(Tablo tablo)
        {
            using var context = new TodoContext();
            context.Set<Tablo>().Update(tablo);
            context.SaveChanges();
        }

        public void Kaydet(Tablo tablo)
        {
            using var context = new TodoContext();
            context.Set<Tablo>().Add(tablo);
            context.SaveChanges();

        }

        public void Sil(Tablo tablo)
        {
            using var context = new TodoContext();
            context.Set<Tablo>().Remove(tablo);
            context.SaveChanges();
        }
    }
}
