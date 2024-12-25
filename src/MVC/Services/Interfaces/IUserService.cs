using MVC.Models;

namespace MVC.Services.Interfaces
{
    public interface IUserService
    {
        public void RegisterUser(string username, string password);
        public bool LoginUser(string username, string password);
        public void DeleteUser(int userId);
        public List<User> GetUsers();
    }
}
