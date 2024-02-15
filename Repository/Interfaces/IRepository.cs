using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        User Login(User user);
        User Register(User user);
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity key);
        List<TEntity> GetAll(TEntity entity);
        List<TEntity> Search(TEntity entity, string criteria);
    }
}
