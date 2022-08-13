using System.Linq.Expressions;
using System.Security.Principal;
using TestAPI.Models;

namespace E_CommerceAPI.Data_Access
{
    public interface IEFentityRepository<T> where T : class, IEntity, new()
    {
        public T? Get(Expression<Func<T,bool>> filter);
        public List<T> GetList(Expression<Func<T, bool>>? filter = null);
        public T Add(T entity);
        public T Update(T entity);
        public T Delete(T entity);

    }

}
