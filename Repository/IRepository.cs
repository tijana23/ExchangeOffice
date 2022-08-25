using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.Repository
{
    
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        string Insert(T t);
        string Update(T t);

    }
}
