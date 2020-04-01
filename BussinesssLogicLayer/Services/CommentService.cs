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
    public class CommentService:IDBService<CommentModel>
    {
        public readonly IDBRepository<Comment> _commentRepository;

        public CommentService()
        {
            _commentRepository = new CommentRepository();
        }

        public void Add(CommentModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommentModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public CommentModel GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(CommentModel model)
        {
            throw new NotImplementedException();
        }
    }
}
