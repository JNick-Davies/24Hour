using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _24Hours.Data;
using _24Hours.Models;

namespace _24Hours.Services
{
    public class LikeService
    {
        private readonly Guid _userId;

        public LikeService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateLike(LikeCreate model)
        {
            var entity = new Like()
            {
                Liker = model.Liker,
                LikedPost = model.LikedPost
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Likes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
       /* public IEnumerable<LikeList> GetLikes()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Likes
                        .Where(e => e.Liker.UserId == _userId)
                        .Select(e => new LikeList
                        {
                            Liker = e.Liker,
                            LikedPost = e.LikedPost
                        });
                return query.ToArray();
            }
        }
        public bool DeleteLike(int postId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                        ctx
                            .Likes
                            .Single(e => e.LikedPost.PostId == postId && e.Liker.UserId == _userId);
                ctx.Likes.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        } */
    }
}
