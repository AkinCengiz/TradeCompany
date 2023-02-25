
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicariOtomasyon.DataAccess.Abstract;
using TicariOtomasyon.Entities.Abstract;

namespace TicariOtomasyon.Business.Abstract
{
    public interface IEntityService<TEntity,TEntityDal> 
        where TEntity : class,IEntity,new()
    where TEntityDal : class, IEntityRepository<TEntity>, new()
    {
        List<TEntity> GetAll();
        //TEntity Get();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
