using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _24Hours.Data;
using _24Hours.Models;

namespace _24Hours.Services
{
    public class CommentService
    {
        private readonly Guid _userId;

        public CommentService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateComment(CommentCreate model)
        {
            var entity = new Comment()
            {
                UserId = _userId,
                CommentPost = model.CommentPost,
                Text = model.Text
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Comments.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<CommentList> GetComments()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Comments
                        .Where(e => e.UserId == _userId)
                        .Select(e => new CommentList
                        {
                            CommentPost = e.CommentPost,
                            Text = e.Text,
                            CommentId = e.CommentId
                        });
                return query.ToArray();
            }
        }
        public CommentDetail GetCommentById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Comments
                        .Single(e => e.CommentId == id && e.UserId == _userId);
                        
                return new CommentDetail() { 
                    CommentId = entity.CommentId,
                    Text = entity.Text,
                    CommentPost = entity.CommentPost
                };
            }
        }
      /*  public bool UpdateComment(CommentEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Comments
                        .Single(e => e.Id == model.Id && e.UserId.UserId == _userId);
                entity.Text = model.Text;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteComment(int CommentId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                        ctx
                            .Comments
                            .Single(e => e.Id == CommentId && e.UserId.UserId == _userId);
                ctx.Comments.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        } */
    }
}
