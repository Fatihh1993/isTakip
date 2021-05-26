using kurtProje.ToDo.Dataaccess.Concreate.EntityFreamworkCore.Contexts;
using kurtProje.ToDo.Dataaccess.Interfaces;
using kurtProje.ToDo.Entities.concreate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace kurtProje.ToDo.Dataaccess.Concreate.EntityFreamworkCore.Repositories
{
    public class EfKullaniciRepository : EfGenericRepository<Kullanici>, IKullaniciDal
    {

    }
}
