using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repositories
{
    public class PostRepository: IDBRepository<Post>
    {
        public readonly BlogContext _bctx;
        public PostRepository() 
        {
            _bctx = new BlogContext();
        }

        public void Add(Post post)
        {
            _bctx.Posts.Add(post);
            _bctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var postDelete = GetById(id);
            _bctx.Posts.Remove(postDelete);
            _bctx.SaveChanges();
        }

        public IEnumerable<Post> GetAll()
        {
            return _bctx.Posts.AsNoTracking().ToList();
        }

        public Post GetById(int id)
        {
            var postGetById = _bctx.Posts.FirstOrDefault(x => x.Id == id);
            return postGetById;
        }

        public void Update(Post post)
        {
            var updatedPost = GetById(post.Id);
            updatedPost.Comments = post.Comments;
            updatedPost.Tags = post.Tags;

            _bctx.Entry(updatedPost);
            _bctx.SaveChanges();
        }
    }
}
