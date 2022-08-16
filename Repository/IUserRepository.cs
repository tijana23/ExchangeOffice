using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.Repository
{
    public interface IUserRepository
    {
        List<User> GetAll(); 
        User GetUserById(int id);
        string InsertUser(User user);
        string UpdateUser(int id, User user);
        string DeleteUser(int id);

    }
}
