using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Interfaces;
using DAL.Models;
using DAL;
using LightInject;

namespace BussinesssLogicLayer
{
    public static class BLLLightInjectConfiguration
    {
        public static ServiceContainer Configuration(ServiceContainer container)
        {
            container.Register<BlogContext>(factory => new BlogContext());
            container.Register<IDBRepository<Author>, AuthorRepository>();
            container.Register<IDBRepository<Post>, PostRepository>();
            container.Register<IDBRepository<Category>, CategoryRepository>();
            container.Register<IDBRepository<Tag>, TagRepository>();
            container.Register<IDBRepository<Comment>, CommentRepository>();

            //container.Register(typeof(IDBRepository<>), typeof(GenericRepository<>));
            return container;
        }
    }
}
