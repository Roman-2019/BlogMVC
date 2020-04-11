using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BussinesssLogicLayer.Models;
using DAL.Models;

namespace BussinesssLogicLayer
{
    public class BLLMapperProFile: Profile
    {
        public BLLMapperProFile() 
        {
            CreateMap<AuthorModel, Author>().ReverseMap();
            CreateMap<CategoryModel, Category>().ReverseMap();
            CreateMap<CommentModel, Comment>().ReverseMap();
            CreateMap<PostModel, Post>().ReverseMap();
            CreateMap<TagModel, Tag>().ReverseMap();
        }
    }
}
