using FirstServiceMVC.Infrastructure.Context;
using FirstServiceMVC.Infrastructure.Entities.Concrete;
using FirstServiceMVC.Infrastructure.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstServiceMVC.Infrastructure.Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _dbContext;

        public UserService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public void DeleteUser(User user)
        {
                user.DeletedDate = DateTime.Now;
                user.Status = Entities.Abstract.Status.Passive;
                _dbContext.Users.Update(user);
                _dbContext.SaveChanges();
        }

        public List<User> GetAllUsers()
        {
            return _dbContext.Users.Where(x=>x.Status != Entities.Abstract.Status.Passive).ToList();
        }

        public User GetUserById(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(x=>x.ID == id);
            if (user != null)
            {
                return user;
            }
            return null;
        }

        public void UpdateUser(User user)
        {
            user.UpdateDate = DateTime.Now;
            user.Status = Entities.Abstract.Status.Modified;
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
        }
    }
}
