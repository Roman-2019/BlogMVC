using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repositories
{
    public class CommentRepository: IDBRepository<Comment>
    {
        public readonly BlogContext _bctx;
        public CommentRepository() 
        {
            _bctx = new BlogContext();
        }

        public void Add(Comment comment)
        {
            _bctx.Comments.Add(comment);
            _bctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var commentDelete = GetById(id);
            _bctx.Comments.Remove(commentDelete);
            _bctx.SaveChanges();
        }

        public IEnumerable<Comment> GetAll()
        {
            return _bctx.Comments.AsNoTracking().ToList();
        }

        public Comment GetById(int id)
        {
            var commentGetById = _bctx.Comments.FirstOrDefault(x => x.Id == id);
            return commentGetById;
        }

        public void Update(Comment comment)
        {
            var updatedComment = GetById(comment.Id);
            updatedComment.Title = comment.Title;
            /*updatedComment.Post = comment.Post;
            updatedComment.Author = comment.Author;*/

            _bctx.Entry(updatedComment);
            _bctx.SaveChanges();
        }
    }
}
