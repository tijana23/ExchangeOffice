using ExchangeOffice.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.BLL
{
    internal class ExchangeRatesBLL : IRepository<ExchangeRate>
    {
        Entity myExchangeDb = new Entity();
        private DbSet<ExchangeRate> table;

        public List<ExchangeRate> ShowData()
        {
            return GetAll();
        }
        public string insert(DateTime DatePicker, int CurrencyFrom, int CurrencyTo, double rate, bool? IsChecked)
        {
            ExchangeRate er = new ExchangeRate();
            er.ValidityDate = DatePicker;
            er.CurrencyFrom = CurrencyFrom;
            er.CurrencyTo = CurrencyTo;
            er.Rate = rate;
            if (IsChecked == true)
            {
                er.IsActive = 1;
            }
            else
            {
                er.IsActive = 0;
            }

            return Insert(er);
        }
        public string delete(int id)
        {
            ExchangeRate er = myExchangeDb.ExchangeRates.Where(o => o.ExchangeRatesId == id).FirstOrDefault();
            return Update(er);
        }
        public string update(int id, DateTime DatePicker, int CurrencyFrom, int CurrencyTo, double rate, bool? IsChecked)
        {
            ExchangeRate er = myExchangeDb.ExchangeRates.Where(o => o.ExchangeRatesId == id).FirstOrDefault();
            er.ValidityDate = DatePicker;
            er.CurrencyFrom = CurrencyFrom;
            er.CurrencyTo = CurrencyTo;
            er.Rate = rate;
            if (IsChecked == true)
            {
                er.IsActive = 1;

            }
            else
            {
                er.IsActive = 0;
            }
            return Update(er);
        }

        public List<ExchangeRate> GetAll()
        {
            table = myExchangeDb.Set<ExchangeRate>();
            List<ExchangeRate> all = table.ToList<ExchangeRate>();
            return all;
        }

        public ExchangeRate GetById(int id)
        {
            table = myExchangeDb.Set<ExchangeRate>();
            ExchangeRate current = table.Find(id);
            return current;
        }

        public string Insert(ExchangeRate t)
        {
            table = myExchangeDb.Set<ExchangeRate>();
            table.Add(t);
            myExchangeDb.SaveChanges();
            return "Your information has been saved";
        }

        public string Update(ExchangeRate t)
        {
            myExchangeDb.SaveChanges();
            return "Succefully updated";
        }
    }
}
