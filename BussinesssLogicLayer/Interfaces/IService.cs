using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesssLogicLayer.Interfaces
{
    public interface IService<ModelBL> where ModelBL : class
    {
        void Add(ModelBL model);
        void Remove(int id);
        void Update(ModelBL model);
        IEnumerable<ModelBL> GetAll();
    }
}
