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
    public class TagService : GeneralService<TagModel, Tag>, IDBService<TagModel>
    {
        private readonly IMapper _mapper;

        public TagService(IDBRepository<Tag> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public TagModel GetById(int id)
        {
            var tagModel = GetAll().FirstOrDefault(x => x.Id == id);
            return tagModel;
        }
        public override TagModel Map(Tag modelDL)
        {
            return _mapper.Map<TagModel>(modelDL);
        }

        public override Tag Map(TagModel modelBL)
        {
            return _mapper.Map<Tag>(modelBL);
        }

        public override IEnumerable<TagModel> Map(IList<Tag> posts)
        {
            return _mapper.Map<IEnumerable<TagModel>>(posts);
        }
        public override IEnumerable<Tag> Map(IList<TagModel> postsModel)
        {
            return _mapper.Map<IEnumerable<Tag>>(postsModel);
        }
    }
}
