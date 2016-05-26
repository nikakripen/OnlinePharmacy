using System.Linq;
using Repository.Models;

namespace Repository.Repository
{
    public interface IRepository<T> where T: Entity
    {
        IQueryable<T> GetAll();
        bool Save(T entity);
        bool Delete(int id);
        bool Delete(T entity);
    }
}
