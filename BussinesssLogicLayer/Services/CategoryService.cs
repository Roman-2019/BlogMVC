using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BussinesssLogicLayer.Interfaces;
using BussinesssLogicLayer.Models;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;

namespace BussinesssLogicLayer.Services
{
    public class CategoryService : GeneralService<CategoryModel, Category>, IDBService<CategoryModel>
    {
        private readonly IMapper _mapper;

        public CategoryService(IDBRepository<Category> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public CategoryModel GetById(int id)
        {
            var categoryModel = GetAll().FirstOrDefault(x => x.Id == id);
            return categoryModel;
        }
        public override CategoryModel Map(Category modelDL)
        {
            return _mapper.Map<CategoryModel>(modelDL);
        }

        public override Category Map(CategoryModel modelBL)
        {
            return _mapper.Map<Category>(modelBL);
        }

        public override IEnumerable<CategoryModel> Map(IList<Category> posts)
        {
            return _mapper.Map<IEnumerable<CategoryModel>>(posts);
        }
        public override IEnumerable<Category> Map(IList<CategoryModel> postsModel)
        {
            return _mapper.Map<IEnumerable<Category>>(postsModel);
        }
    }
}
