using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesssLogicLayer.Models;

namespace BussinesssLogicLayer.Interfaces
{
    public interface ITagService: IService<TagModel>
    {
        TagModel GetById(int id);
    }
}
