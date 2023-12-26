using WebApiTest.Model;

namespace WebApiTest.Services.UserService
{
    public interface IUserService
    {
        List<User>? GetAllUsers();

        User? GetUser(int id);

        User? AddUser(User user);

        User UpdateUser(User user);

        User DeleteUser(int id);
    }
}
