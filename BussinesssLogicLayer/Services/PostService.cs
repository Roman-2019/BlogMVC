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
    public class PostService: IDBService<PostModel>
    {
        public readonly IDBRepository<Post> _postRepository;

        public PostService()
        {
            _postRepository = new PostRepository();
        }

        public void Add(PostModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public PostModel GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(PostModel model)
        {
            throw new NotImplementedException();
        }
    }
}
