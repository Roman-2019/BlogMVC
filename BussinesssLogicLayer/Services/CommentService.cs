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
    public class CommentService : GeneralService<CommentModel, Comment>, ICommentService
    {
        private readonly IMapper _mapper;

        public CommentService(IDBRepository<Comment> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public CommentModel GetById(int id)
        {
            var commentModel = GetAll().FirstOrDefault(x => x.Id == id);
            return commentModel;
        }
        public override CommentModel Map(Comment modelDL)
        {
            return _mapper.Map<CommentModel>(modelDL);
        }

        public override Comment Map(CommentModel modelBL)
        {
            return _mapper.Map<Comment>(modelBL);
        }

        public override IEnumerable<CommentModel> Map(IList<Comment> posts)
        {
            return _mapper.Map<IEnumerable<CommentModel>>(posts);
        }
        public override IEnumerable<Comment> Map(IList<CommentModel> postsModel)
        {
            return _mapper.Map<IEnumerable<Comment>>(postsModel);
        }
    }
}
