using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _24Hours.Data;
using _24Hours.Models;

namespace _24Hours.Services
{
    public class PostService
    {
        private readonly Guid _userId;

        public PostService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreatePost(PostCreate model)
        {
            var entity = new Post()
            {
                Author = model.Author,
                Text = model.Text,
                Title = model.Title,
                PostId = model.PostId
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<PostList> GetPosts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Posts
                        .Where(e => e.Author.UserId == _userId)
                        .Select(e => new PostList
                        {
                            PostId = e.PostId,
                            Author = e.Author,
                            Text = e.Text,
                            Title = e.Title
                        });
                return query.ToArray();
            }
        }
        public PostDetail GetPostById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Posts
                        .Single(e => e.PostId == id && e.Author.UserId == _userId);

                return new PostDetail()
                {
                    Author = entity.Author,
                    PostId = entity.PostId,
                    Text = entity.Text,
                    Title = entity.Title
                };
            }
        }
        public bool UpdatePost(PostEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Posts
                        .Single(e => e.PostId == model.PostId && e.Author.UserId == _userId);
                entity.Text = model.Text;
                entity.Title = model.Title;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeletePost(int postId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                        ctx
                            .Posts
                            .Single(e => e.PostId == postId && e.Author.UserId == _userId);
                ctx.Posts.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
