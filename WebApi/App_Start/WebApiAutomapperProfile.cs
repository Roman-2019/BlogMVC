using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BussinesssLogicLayer.Models;
using WebApi.Models;

namespace WebApi.App_Start
{
    public class WebApiAutomapperProfile: Profile
    {
        public WebApiAutomapperProfile()
        {
            CreateMap<PostApiModel, PostModel>()
                .ForMember(x => x.AuthorModel, s => s.MapFrom(x => x.AuthorApiModel))
                .ReverseMap();
            CreateMap<AuthorApiModel, AuthorModel>().ReverseMap();
            CreateMap<CommentApiModel, CommentModel>().ReverseMap();
            CreateMap<TagApiModel, TagModel>().ReverseMap();
        }
    }
}