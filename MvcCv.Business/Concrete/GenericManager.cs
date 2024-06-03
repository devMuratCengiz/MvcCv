using MvcCv.Business.Abstract;
using MvcCv.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCv.Business.Concrete
{
    public class GenericManager<T> (IRepository<T> _repository): IGenericService<T> where T : class
    {
        public void TCreate(T entity)
        {
            _repository.Create(entity);
        }

        public void TDelete(int id)
        {
            _repository.Delete(id);
        }

        public List<T> TGetAll()
        {
            var values = _repository.GetAll();
            return values;
        }

        public T TGetById(int id)
        {
            var value = _repository.GetById(id);
            return value;
        }

        public void TUpdate(T entity)
        {
            _repository.Update(entity);
        }
    }
}
