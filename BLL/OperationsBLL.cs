using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.BLL
{
    internal class OperationsBLL
    {
        Entity myExchangeDb = new Entity();
        public List<Operation> ShowData()
        {
            List<Operation> allOP = myExchangeDb.Operations.ToList<Operation>();
            return allOP;
        }
        public string insert(int OperationTypeId, int UsersId, DateTime OperationDatePicker, int Amount, int CurrencyFrom, int CurrencyTo)
        {
            Operation op = new Operation();
            op.OperationTypeId = OperationTypeId;
            op.UserId = UsersId;
            op.OperationDate = OperationDatePicker;
            op.Amount = Amount;
            op.CurrencyFrom = CurrencyFrom;
            op.CurrencyTo = CurrencyTo;
            myExchangeDb.Operations.Add(op);
            myExchangeDb.SaveChanges();
            return "Your information has been saved";
        }
        public string delete(int id)
        {
            ExchangeRate er = myExchangeDb.ExchangeRates.Where(o => o.ExchangeRatesId == id).FirstOrDefault();
            er.IsActive = 0;
            return "Succefully deleted";
        }
        public string update(int id, int OperationTypeId, int UsersId, DateTime OperationDatePicker, int Amount, int CurrencyFrom, int CurrencyTo)
        {
            Operation op = myExchangeDb.Operations.Where(o => o.OperationId == id).FirstOrDefault();
            op.OperationTypeId = OperationTypeId;
            op.UserId = UsersId;
            op.OperationDate = OperationDatePicker;
            op.Amount = Amount;
            op.CurrencyFrom = CurrencyFrom;
            op.CurrencyTo = CurrencyTo;
            myExchangeDb.Operations.Add(op);
            myExchangeDb.SaveChanges();
            return "Succefully updated";
        }
    }
}
