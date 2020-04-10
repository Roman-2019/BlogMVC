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
    public class AuthorService: IDBService<AuthorModel>
    {
        private readonly IDBRepository<Author> _authorRepository;

        public AuthorService()
        {
            _authorRepository = new AuthorRepository();
        }

        public void Add(AuthorModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AuthorModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public AuthorModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(AuthorModel model)
        {
            throw new NotImplementedException();
        }
    }
}
