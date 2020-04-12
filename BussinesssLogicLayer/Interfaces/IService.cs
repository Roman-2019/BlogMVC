using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesssLogicLayer.Interfaces
{
    public interface IService<T> where T : class
    {
        void Add(T model);
        void Remove(int id);
        void Update(T model);
        IEnumerable<T> GetAll();
    }
}
