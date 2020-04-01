using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogMVC.Interfaces
{
    public interface IDBController<T> where T: class
    {
        IEnumerable<T> GetAll();
        T GetById();
        void Add(T model);
        void Delete(int id);
        void Update(T model);
    }
}
