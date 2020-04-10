using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesssLogicLayer.Interfaces;
using BussinesssLogicLayer.Models;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;

namespace BussinesssLogicLayer.Services
{
    public class TagService: IDBService<TagModel>
    {
        private readonly IDBRepository<Tag> _tagRepository;

        public TagService()
        {
            _tagRepository = new TagRepository();
        }

        public void Add(TagModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TagModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public TagModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TagModel model)
        {
            throw new NotImplementedException();
        }
    }
}
