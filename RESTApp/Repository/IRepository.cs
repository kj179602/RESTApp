using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTApp.Repository
{
    interface IRepository <T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(T entity);
        void Update(int id, T entity);
        void Delete(int id);
    }
}
