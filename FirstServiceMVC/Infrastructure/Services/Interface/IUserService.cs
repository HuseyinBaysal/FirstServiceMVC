using FirstServiceMVC.Infrastructure.Entities.Concrete;
using System.Collections.Generic;

namespace FirstServiceMVC.Infrastructure.Services.Interface
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
        void AddUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);
    }
}
