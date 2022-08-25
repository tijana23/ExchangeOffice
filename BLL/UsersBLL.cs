using ExchangeOffice.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace ExchangeOffice.BLL
{
    internal class UsersBLL : IRepository<User>
    {
        private static readonly string baseURL = "https://localhost:7229/api/";
        Entity myExchangeDb = new Entity();
        private DbSet<User> table;
        public List<User> ShowData()
        {
            table = myExchangeDb.Set<User>();
            return GetAll();


        }
        //public  async Task<List<User>> GetAllUsers()
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        HttpResponseMessage res = await client.GetAsync(baseURL + "Users");

        //        var data = await res.Content.ReadAsStringAsync();
        //        var list = JsonConvert.DeserializeObject<List<User>>(data);
        //        return list;

        //    }

        //}
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
            return Insert(user);
        }
        public string delete(int id)
        {
            User user = myExchangeDb.Users.Where(u => u.UsersId == id).FirstOrDefault();
            Debug.Write(user.FullName);
            user.IsActive = 0;
            return Update(user);
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
            //Debug.Write(user.FullName);
            return Update(user);
        }

        
        public List<User> GetAll()
        {
            table = myExchangeDb.Set<User>();
            List<User> all = table.ToList<User>();
            return all;
        }

        public User GetById(int id)
        {
            table = myExchangeDb.Set<User>();
            User current = table.Find(id);
            return current;
        }

        public string Insert(User t)
        {
            table = myExchangeDb.Set<User>();
            table.Add(t);
            myExchangeDb.SaveChanges();
            return "Your information has been saved";

        }

        public string Update(User t)
        {
            //Debug.Write(t.FullName);
            //table = myExchangeDb.Set<User>();
            //table.Attach(t);
            //myExchangeDb.Entry(t).State = EntityState.Modified;
            myExchangeDb.SaveChanges();
            return "Succefully updated";
        }
    }
}
