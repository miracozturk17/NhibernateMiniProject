using System;
using System.Collections.Generic;
using System.Linq;
using NhibernateDb;
using NHibernate;

namespace RepositorySample
{
    public class RepositroyBase<T> : ICrudRepository<T> where T : class
    {
        public void Insert(T entities)
        {
            using (ISession _session = NhibernateSqlContext.SessionOpen())
            {
                using (ITransaction _transaction = _session.BeginTransaction())
                {
                    try
                    {
                        _session.Save(entities);
                        _transaction.Commit();
                    }
                    catch (Exception e)
                    {
                        if (!_transaction.WasCommitted)_transaction.Rollback();
                        throw new Exception("Insert Exception : "+e.Message);
                    }
                }
            }
        }

        public void Update(T entities)
        {
            using (ISession _session = NhibernateSqlContext.SessionOpen())
            {
                using (ITransaction _transaction = _session.BeginTransaction())
                {
                    try
                    {
                        _session.Update(entities);
                        _transaction.Commit();
                    }
                    catch (Exception e)
                    {
                        if (!_transaction.WasCommitted) _transaction.Rollback();
                        throw new Exception("Update Exception : " + e.Message);
                    }
                }
            }
        }

        public void Delete(T entities)
        {
            using (ISession _session = NhibernateSqlContext.SessionOpen())
            {
                using (ITransaction _transaction = _session.BeginTransaction())
                {
                    try
                    {
                        _session.Delete(entities);
                        _transaction.Commit();
                    }
                    catch (Exception e)
                    {
                        if (!_transaction.WasCommitted) _transaction.Rollback();
                        throw new Exception("Delete Exception : " + e.Message);
                    }
                }
            }
        }

        public T GetById(int id)
        {
            using (ISession _session=NhibernateSqlContext.SessionOpen())
            {
                return _session.Get<T>(id);
            }
        }

        public IList<T> GetList()
        {
            using (ISession _session=NhibernateSqlContext.SessionOpen())
            {
                return _session.Query<T>().ToList();
            }
        }
    }
}
