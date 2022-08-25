using ExchangeOffice.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.BLL
{
    internal class OperationsBLL : IRepository<Operation>
    {
        Entity myExchangeDb = new Entity();
        private DbSet<Operation> table;
        public List<Operation> ShowData()
        {
            table = myExchangeDb.Set<Operation>();
            return GetAll();
        }
        public string insert(int OperationTypeId, int UsersId, DateTime OperationDatePicker, int Amount, int CurrencyFrom, int CurrencyTo)
        {
            table = myExchangeDb.Set<Operation>();
            Operation op = new Operation();
            op.OperationTypeId = OperationTypeId;
            op.UserId = UsersId;
            op.OperationDate = OperationDatePicker;
            op.Amount = Amount;
            op.CurrencyFrom = CurrencyFrom;
            op.CurrencyTo = CurrencyTo;
            return Insert(op);
        }
        public string update(int id, int OperationTypeId, int UsersId, DateTime OperationDatePicker, int Amount, int CurrencyFrom, int CurrencyTo)
        {
            table = myExchangeDb.Set<Operation>();
            Operation op = myExchangeDb.Operations.Where(o => o.OperationId == id).FirstOrDefault();
            op.OperationTypeId = OperationTypeId;
            op.UserId = UsersId;
            op.OperationDate = OperationDatePicker;
            op.Amount = Amount;
            op.CurrencyFrom = CurrencyFrom;
            op.CurrencyTo = CurrencyTo;
            return Update(op);
        }

        public List<Operation> GetAll()
        {
            table = myExchangeDb.Set<Operation>();
            List<Operation> all = table.ToList<Operation>();
            return all;
        }

        public Operation GetById(int id)
        {
            table = myExchangeDb.Set<Operation>();
            Operation current = table.Find(id);
            return current;
        }

        public string Insert(Operation t)
        {
            table = myExchangeDb.Set<Operation>();
            table.Add(t);
            myExchangeDb.SaveChanges();
            return "Your information has been saved";
        }

        public string Update(Operation t)
        {
            myExchangeDb.SaveChanges();
            return "Succefully updated";
        }
    }
}
