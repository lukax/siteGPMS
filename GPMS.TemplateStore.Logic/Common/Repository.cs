using GPMS.TemplateStore.Logic.Utils;
using NHibernate;

namespace GPMS.TemplateStore.Logic.Common
{
    public abstract class Repository<T>
        where T : AggregateRoot
    {
        public virtual T GetById(long id)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                return session.Get<T>(id);
            }
        }

        public virtual void Save(T aggregateRoot)
        {
            using (ISession session = SessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.SaveOrUpdate(aggregateRoot);
                transaction.Commit();
            }
        }
    }
}
