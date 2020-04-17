using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using LightInject;
using System.Web.Http;
using BussinesssLogicLayer;
using BussinesssLogicLayer.Interfaces;
using BussinesssLogicLayer.Services;

namespace WebApi.App_Start
{
    public class LightInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer();

            container.RegisterApiControllers();

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                 new List<Profile>() { new WebApiAutomapperProfile(), new BLLMapperProFile() }));

            container.Register(c => config.CreateMapper());

            container = BLLLightInjectConfiguration.Configuration(container);

            container.Register<IPostService, PostService>();
            container.Register<IAuthorService, AuthorService>();
            container.Register<ICategoryService, CategoryService>();
            container.Register<ITagService, TagService>();

            container.EnableWebApi(GlobalConfiguration.Configuration);
        }
    }
}