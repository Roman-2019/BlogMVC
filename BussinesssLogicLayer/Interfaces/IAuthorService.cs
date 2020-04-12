using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesssLogicLayer.Models;

namespace BussinesssLogicLayer.Interfaces
{
    public interface IAuthorService: IService<AuthorModel>
    {
       AuthorModel GetById(int id);
       
    }
}
