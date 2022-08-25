using ExchangeOffice.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.BLL
{
    internal class CLS_OperationTypeBLL : IRepository<CLS_OperationType>
    {
        Entity myExchangeDb = new Entity();
        private DbSet<CLS_OperationType> table;
        public List<CLS_OperationType> ShowData()
        {
            return GetAll();
        }
        public string insert(string Code, string Name, bool? IsChecked)
        {
            CLS_OperationType cop = new CLS_OperationType();
            cop.Code = Code;
            cop.Name = Name;
            if (IsChecked == true)
            {
                cop.IsActive = 1;
            }
            else
            {
                cop.IsActive = 0;
            }
            return Insert(cop);
        }
        public string delete(int id)
        {
            CLS_OperationType cop = myExchangeDb.CLS_OperationType.Where(o => o.OperationTypeId == id).FirstOrDefault();
            return Update(cop);
        }
        public string update(int id, string Code, string Name, bool? IsChecked)
        {
            CLS_OperationType cop = myExchangeDb.CLS_OperationType.Where(o => o.OperationTypeId == id).FirstOrDefault();
            cop.Code = Code;
            cop.Name = Name;
            if (IsChecked == true)
            {
                cop.IsActive = 1;
            }
            else
            {
                cop.IsActive = 0;
            }
            return Update(cop);
        }

        public List<CLS_OperationType> GetAll()
        {
            table = myExchangeDb.Set<CLS_OperationType>();
            List<CLS_OperationType> all = table.ToList<CLS_OperationType>();
            return all;
        }

        public CLS_OperationType GetById(int id)
        {
            table = myExchangeDb.Set<CLS_OperationType>();
            CLS_OperationType current = table.Find(id);
            return current;
        }

        public string Insert(CLS_OperationType t)
        {
            table = myExchangeDb.Set<CLS_OperationType>();
            table.Add(t);
            myExchangeDb.SaveChanges();
            return "Your information has been saved";
        }

        public string Update(CLS_OperationType t)
        {
            myExchangeDb.SaveChanges();
            return "Succefully updated";
        }
    }
}
