using MVC.Models;

namespace MVC.Repository.Interfaces
{
    public interface IUserRepository
    {
        public void AddUser(User user);
        public User GetUserByUsername(string username);
        public List<User> GetAllUsers();
        public void DeleteUser(int userId);

    }
}
