using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCv.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> TGetAll();
        void TCreate(T entity);
        void TUpdate(T entity);
        void TDelete(int id);
        T TGetById(int id);
    }
}
