using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Interfaces;
using BussinesssLogicLayer.Interfaces;

namespace BussinesssLogicLayer.Services
{
    public abstract class GeneralService<ModelBL, ModelDL> : IService<ModelBL> where ModelBL : class where ModelDL : class
    {

        public readonly IDBRepository<ModelDL> _repository;

        public GeneralService(IDBRepository<ModelDL> repository)
        {
            _repository = repository;
        }

        public void Add(ModelBL modelBL)
        {
            var model = Map(modelBL);
            _repository.Add(model);
        }

        public IEnumerable<ModelBL> GetAll()
        {
            var models = _repository.GetAll().ToList();

            return Map(models);
        }

        public void Remove(int id)
        {
            _repository.Delete(id);
        }

        public void Update(ModelBL modelBL)
        {
            var model = Map(modelBL);
            _repository.Update(model);
        }

        public abstract ModelBL Map(ModelDL modelDL);
        public abstract ModelDL Map(ModelBL modelBL);

        public abstract IEnumerable<ModelBL> Map(IList<ModelDL> modelsDL);
        public abstract IEnumerable<ModelDL> Map(IList<ModelBL> modelsBL);

    }
}
