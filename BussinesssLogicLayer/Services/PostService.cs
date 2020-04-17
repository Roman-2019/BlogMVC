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
    public class PostService : GeneralService<PostModel, Post>, IPostService
    {
        private readonly IMapper _mapper;

        public PostService(IDBRepository<Post> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public PostModel GetById(int id)
        {
            var postModel = GetAll().FirstOrDefault(x => x.Id == id);
            return postModel;
        }

        public IEnumerable<PostModel> Posts(int pageNo, int pageSize)
        {
            var posts = _repository.GetAll()
                .OrderByDescending(x => x.DateTime)
                .Skip(pageNo * pageSize)
                .Take(pageSize)
                .ToList();

            var postsModel = Map(posts);

            return postsModel;

        }
        public override PostModel Map(Post modelDL)
        {
            return _mapper.Map<PostModel>(modelDL);
        }

        public override Post Map(PostModel modelBL)
        {
            return _mapper.Map<Post>(modelBL);
        }

        public override IEnumerable<PostModel> Map(IList<Post> posts)
        {
            return _mapper.Map<IEnumerable<PostModel>>(posts);
        }
        public override IEnumerable<Post> Map(IList<PostModel> postsModel)
        {
            return _mapper.Map<IEnumerable<Post>>(postsModel);
        }
    }
}
