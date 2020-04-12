using BussinesssLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesssLogicLayer.Interfaces
{
     public interface ICategoryService: IService<CategoryModel>
    {
        CategoryModel GetById(int id);
    }
}
