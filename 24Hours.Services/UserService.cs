using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _24Hours.Data;
using _24Hours.Models;

namespace _24Hours.Services
{
    public class AppUserservice
    {
        private readonly Guid _userId;

        public AppUserservice(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateUser(UserCreate model)
        {
            var entity = new User()
            {
                Email = model.Email,
                Name = model.Name,
                UserId = new Guid()
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.AppUsers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<UserList> GetAppUsers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .AppUsers
                        .Where(e => e.UserId == _userId)
                        .Select(e => new UserList
                        {
                            Email = e.Email,
                            Name = e.Name,
                            UserId = e.UserId
                        });
                return query.ToArray();
            }
        }
        public UserDetail GetUserById(Guid id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .AppUsers
                        .Single(e => e.UserId == id);

                return new UserDetail()
                {
                    Email = entity.Email,
                    Name = entity.Name,
                    UserId = entity.UserId
                };
            }
        }
        public bool UpdateUser(UserEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .AppUsers
                        .Single(e => e.UserId == model.UserId);
                entity.Email = model.Email;
                entity.Name = model.Name;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteUser(Guid UserId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                        ctx
                            .AppUsers
                            .Single(e => e.UserId == UserId);
                ctx.AppUsers.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
