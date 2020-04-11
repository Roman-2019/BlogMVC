using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesssLogicLayer.Interfaces
{
    public interface IDBService<T> where T : class
    {
       // IEnumerable<T> GetAll();
        T GetById(int id);
       /* void Add(T model);
        void Delete(int id);
        void Update(T model);*/
    }
}
