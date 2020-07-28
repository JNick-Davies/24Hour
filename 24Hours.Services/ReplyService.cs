using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _24Hours.Data;
using _24Hours.Models;

namespace _24Hours.Services
{
    public class ReplyService
    {
        private readonly Guid _userId;

        public ReplyService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateReply(ReplyCreate model)
        {
            var entity = new Reply()
            {
                ReplyComment = model.ReplyComment,
                Author = model.Author,
                CommentPost = model.CommentPost,
                Id = model.Id,
                Text = model.Text
                

            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Replies.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ReplyList> GetReplies()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Replies
                        .Where(e => e.Author.UserId == _userId)
                        .Select(e => new ReplyList
                        {
                            Id = e.Id,
                            CommentPost = e.CommentPost,
                            Text = e.Text,
                            Author = e.Author,
                            ReplyComment = e.ReplyComment
                        });
                return query.ToArray();
            }
        }
        public ReplyDetail GetReplyById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Replies
                        .Single(e => e.Id == id && e.Author.UserId == _userId);

                return new ReplyDetail()
                {
                    Author = entity.Author,
                    Text = entity.Text,
                    Id = entity.Id,
                    CommentPost = entity.CommentPost,
                    ReplyComment = entity.ReplyComment
                    
                };
            }
        }
        public bool UpdateReply(ReplyEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Replies
                        .Single(e => e.Id == model.Id && e.Author.UserId == _userId);
                entity.Text = model.Text;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteReply(int ReplyId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                        ctx
                            .Replies
                            .Single(e => e.Id == ReplyId && e.Author.UserId == _userId);
                ctx.Replies.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
