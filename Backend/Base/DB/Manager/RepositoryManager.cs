using Base.DB.Helper;
using Base.DB.Interface;
using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Linq.Expressions
using System.Threading.Tasks;

namespace Base.DB.Manager
{
    public class RepositoryManager<T> : IRepositoryService<T> where T : class, IEntity, new()
    {

        private NHibernateHelper _nHibernateHelper;
        

        public RepositoryManager(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }


     
        public T Add(T entity)
        {
            using (var session= _nHibernateHelper.OpenSession())
            {
                session.Save(entity);
                return entity;
            }
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
