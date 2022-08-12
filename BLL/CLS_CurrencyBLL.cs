using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.BLL
{
    internal class CLS_CurrencyBLL
    {
        Entity myExchangeDb = new Entity();
        public List<CLS_Currency> ShowData()
        {
            List<CLS_Currency> allCurrencies = myExchangeDb.CLS_Currency.ToList<CLS_Currency>();
            return allCurrencies;
        }
        public string insert(string Code, string Name, bool? IsChecked)
        {
            CLS_Currency c = new CLS_Currency();
            c.Code = Code;
            c.Name = Name;
            if (IsChecked == true)
            {
                c.IsActive = 1;
            }
            else
            {
                c.IsActive = 0;
            }
            myExchangeDb.CLS_Currency.Add(c);
            myExchangeDb.SaveChanges();
            return "Your information has been saved";
        }
        public string delete(int id)
        {
            CLS_Currency c = myExchangeDb.CLS_Currency.Where(o => o.CurrencyId == id).FirstOrDefault();
            c.IsActive = 0;
            return "Succefully delete";
        }
        public string update(int id, string Code, string Name, bool? IsChecked)
        {
            CLS_Currency c = myExchangeDb.CLS_Currency.Where(o => o.CurrencyId == id).FirstOrDefault();
            c.Code = Code;
            c.Name = Name;
            if (IsChecked == true)
            {
                c.IsActive = 1;
            }
            else
            {
                c.IsActive = 0;
            }
            myExchangeDb.CLS_Currency.Add(c);
            myExchangeDb.SaveChanges();
            return "Succefully updated";
        }
    }
}
