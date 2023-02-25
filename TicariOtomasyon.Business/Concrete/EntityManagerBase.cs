using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicariOtomasyon.Business.Abstract;
using TicariOtomasyon.DataAccess.Abstract;
using TicariOtomasyon.Entities.Abstract;

namespace TicariOtomasyon.Business.Concrete
{
    public class EntityManagerBase<TEntity,TEntityDal> : IEntityService<TEntity,TEntityDal> 
        where TEntity : class, IEntity, new()
        where TEntityDal : class, IEntityRepository<TEntity>, new()

    {
        private TEntityDal _entityDal = new TEntityDal();
        public List<TEntity> GetAll()
        {
            return _entityDal.GetAll();
        }

        public void Add(TEntity entity)
        {
            _entityDal.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _entityDal.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            _entityDal.Delete(entity);
        }
    }
}
