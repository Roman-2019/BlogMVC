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
    public class AuthorService: GeneralService<AuthorModel, Author>, IDBService<AuthorModel>
    {
        //private readonly IDBRepository<Author> _authorRepository;
        private readonly IMapper _mapper;

        public AuthorService(IDBRepository<Author> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        /*
        public AuthorService()
        {
            _authorRepository = new AuthorRepository();
        }*/

        public AuthorModel GetById(int id)
        {
            var authorModel = GetAll().FirstOrDefault(x => x.Id == id);
            return authorModel;
        }
        public override AuthorModel Map(Author modelDL)
        {
            return _mapper.Map<AuthorModel>(modelDL);
        }

        public override Author Map(AuthorModel modelBL)
        {
            return _mapper.Map<Author>(modelBL);
        }

        public override IEnumerable<AuthorModel> Map(IList<Author> posts)
        {
            return _mapper.Map<IEnumerable<AuthorModel>>(posts);
        }
        public override IEnumerable<Author> Map(IList<AuthorModel> postsModel)
        {
            return _mapper.Map<IEnumerable<Author>>(postsModel);
        }
    }
}
