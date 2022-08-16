using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExchangeOffice.BLL
{
    internal class UsersBLL
    {
        Entity myExchangeDb = new Entity();
        public List<User> ShowData()
        {
            List<User> allUsers = myExchangeDb.Users.ToList<User>();
            return allUsers;
        }
        public string insert(string Name, string Surname, bool? IsChecked)
        {
            User user = new User();
            user.Name = Name;
            user.Surname = Surname;
            if (IsChecked == true)
            {
                user.IsActive = 1;
            }
            else
            {
                user.IsActive = 0;
            }

            myExchangeDb.Users.Add(user);
            myExchangeDb.SaveChanges();

            return "Your information has been saved";
        }
        public string delete(int id)
        {
            User user = myExchangeDb.Users.Where(u => u.UsersId == id).FirstOrDefault();
            user.IsActive = 0;
            return "Succefully deleted";
        }
        public string update(int id, string Name, string Surname, bool? IsChecked)
        {
            User user = myExchangeDb.Users.Where(u => u.UsersId == id).FirstOrDefault();
            user.Name = Name;
            user.Surname = Surname;
            if (IsChecked == true)
            {
                user.IsActive = 1;

            }
            else
            {
                user.IsActive = 0;
            }

            myExchangeDb.SaveChanges();
            return "Succefully updated";
        }
    }
}
