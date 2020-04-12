using AutoMapper;
using BlogMVC.Models;
using BussinesssLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVC.App_Start
{
    public class WebAutomapperProFile: Profile
    {
        public WebAutomapperProFile()
        {
            CreateMap<PostViewModel, PostModel>().ReverseMap();
            CreateMap<AuthorViewModel, AuthorModel>().ReverseMap();
            CreateMap<CommentViewModel, CommentModel>().ReverseMap();
            CreateMap<TagViewModel, TagModel>().ReverseMap();
            CreateMap<CategoryViewModel, CategoryModel>().ReverseMap();
        }
    }
}