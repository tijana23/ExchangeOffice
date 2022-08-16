using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.Repository
{
    public class UserRepository : IUserRepository
    {
        Entity myExchangeDb = new Entity();
        public string DeleteUser(int id)
        {
            User user = myExchangeDb.Users.Where(u => u.UsersId == id).FirstOrDefault();
            user.IsActive = 0;
            return "Succefully deleted";
        }

        public List<User> GetAll()
        {
            List<User> allUsers = myExchangeDb.Users.ToList<User>();
            return allUsers;
        }

        public User GetUserById(int id)
        {
            User user = myExchangeDb.Users.Where(u => u.UsersId == id).FirstOrDefault();
            user.IsActive = 0;
            return user;
        }

        public string InsertUser(User user)
        {
            throw new NotImplementedException();
        }

        public string UpdateUser(int id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
