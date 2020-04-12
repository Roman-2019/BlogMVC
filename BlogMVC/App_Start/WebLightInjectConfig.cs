using AutoMapper;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using BussinesssLogicLayer;
using BussinesssLogicLayer.Interfaces;
using BussinesssLogicLayer.Services;

namespace BlogMVC.App_Start
{
    public class WebLightInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer();

            container.RegisterControllers(Assembly.GetExecutingAssembly());

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                 new List<Profile>() { new WebAutomapperProFile(), new BLLMapperProFile() }));

            container.Register(c => config.CreateMapper());

            container = BLLLightInjectConfiguration.Configuration(container);

            container.Register<IPostService, PostService>();
            container.Register<IAuthorService, AuthorService>();
            container.Register<ICategoryService, CategoryService>();
            container.Register<ITagService, TagService>();

            container.EnableMvc();
        }
    }
}