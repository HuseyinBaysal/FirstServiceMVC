using FirstServiceMVC.Infrastructure.Entities.Concrete;
using FirstServiceMVC.Infrastructure.Services.Interface;
using FirstServiceMVC.Models.DTO_s;
using Microsoft.AspNetCore.Mvc;

namespace FirstServiceMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var users = _userService.GetAllUsers();
            return View(users);
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        //DTO => 

        [HttpPost]
        public IActionResult CreateUser(CreateUserDTO createUser)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    FirstName = createUser.FirstName,
                    LastName = createUser.LastName,
                    EMail = createUser.EMail,
                    Gender = createUser.Gender,
                    Age = createUser.Age,
                };

                _userService.AddUser(user);
                return RedirectToAction("Index");
            }
            return View(createUser);
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var user = _userService.GetUserById(id);
            if (user != null)
            {
                EditUserDTO editUser = new EditUserDTO
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    EMail = user.EMail,
                    Age = user.Age,
                    Gender = user.Gender,
                };
                return View(editUser);
            }
            return View();
        }

        [HttpPost]
        public IActionResult EditUser(EditUserDTO editUser)
        {
            if (ModelState.IsValid)
            {
                if (User != null)
                {
                    var user = _userService.GetUserById(editUser.ID);
                    user.FirstName = editUser.FirstName;
                    user.LastName = editUser.LastName;
                    user.EMail = editUser.EMail;
                    user.Age = editUser.Age;
                    user.Gender = editUser.Gender;
                    _userService.UpdateUser(user);
                    return RedirectToAction("Index");
                }
                return View(editUser);
            }
            return View(editUser);
        }

        [HttpGet]
        public IActionResult DeleteUser(int id)
        {
            var user = _userService.GetUserById(id);
            if (user != null)
            {
                _userService.DeleteUser(user);
            }
            return RedirectToAction("Index");
        }
    }
}
