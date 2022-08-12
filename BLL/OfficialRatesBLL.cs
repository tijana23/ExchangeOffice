using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.BLL
{
    internal class OfficialRatesBLL
    {
        Entity myExchangeDb = new Entity();
        public List<OfficialRate> ShowData()
        {
            List<OfficialRate> allOR = myExchangeDb.OfficialRates.ToList<OfficialRate>();
            return allOR;
        }
        public string insert(DateTime DatePicker, int Currency, double rate, bool? IsChecked)
        {
            OfficialRate or = new OfficialRate();
            or.ValidityDate = DatePicker;
            or.Currency = Currency;
            or.Rate = rate;
            if (IsChecked == true)
            {
                or.IsActive = 1;
            }
            else
            {
                or.IsActive = 0;
            }
            myExchangeDb.OfficialRates.Add(or);
            myExchangeDb.SaveChanges();

            return "Your information has been saved";
        }
        public string delete(int id)
        {
            OfficialRate or = myExchangeDb.OfficialRates.Where(o => o.OfficialRatesId == id).FirstOrDefault();
            or.IsActive = 0;
            return "Succefully delete";
        }
        public string update(int id, DateTime DatePicker, int Currency, double rate, bool? IsChecked)
        {
            OfficialRate or = myExchangeDb.OfficialRates.Where(o => o.OfficialRatesId == id).FirstOrDefault();
            or.ValidityDate = DatePicker;
            or.Currency = Currency;
            or.Rate = rate;
            if (IsChecked == true)
            {
                or.IsActive = 1;

            }
            else
            {
                or.IsActive = 0;
            }
            myExchangeDb.SaveChanges();
            return "Succefully updated";
        }
    }
}
