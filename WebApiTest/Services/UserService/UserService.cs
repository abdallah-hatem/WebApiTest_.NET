using WebApiTest.Data;
using WebApiTest.Model;

namespace WebApiTest.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _db;
        public UserService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = _db.Users.ToList();
            return users;
        }


        public User? GetUser(int id)
        {
            var user = _db.Users.ToList().Find(x => x.Id == id);
            if (user is null)
                return null;

            return user;
        }


        public User? AddUser(User user)
        {
            User newUser = new User { Email = user.Email, Name = user.Name, Password = user.Password };
            _db.Users.Add(newUser);
            _db.SaveChanges();

            return newUser;
        }

        public User DeleteUser(int id)
        {
            throw new NotImplementedException();
        }


        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
