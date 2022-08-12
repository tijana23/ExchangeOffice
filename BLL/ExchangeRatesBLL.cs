using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.BLL
{
    internal class ExchangeRatesBLL
    {
        Entity myExchangeDb = new Entity();
        public List<ExchangeRate> ShowData()
        {
            List<ExchangeRate> allER = myExchangeDb.ExchangeRates.ToList<ExchangeRate>();
            return allER;
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
            myExchangeDb.ExchangeRates.Add(er);
            myExchangeDb.SaveChanges();

            return "Your information has been saved";
        }
        public string delete(int id)
        {
            ExchangeRate er = myExchangeDb.ExchangeRates.Where(o => o.ExchangeRatesId == id).FirstOrDefault();
            er.IsActive = 0;
            return "Succefully delete";
        }
        public string update(int id, DateTime DatePicker, int CurrencyFrom, int CurrencyTo, double rate, bool? IsChecked)
        {
            ExchangeRate er = myExchangeDb.ExchangeRates.Where(o => o.ExchangeRatesId == id).FirstOrDefault();
            er.ValidityDate = DatePicker;
            er.CurrencyFrom = CurrencyFrom;
            er.CurrencyTo = CurrencyTo;
            if (IsChecked == true)
            {
                er.IsActive = 1;

            }
            else
            {
                er.IsActive = 0;
            }
            myExchangeDb.SaveChanges();
            return "Succefully updated";
        }
    }
}
