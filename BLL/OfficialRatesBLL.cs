using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExchangeOffice.BLL
{
    internal class OfficialRatesBLL
    {
        Entity myExchangeDb = new Entity();
        public List<OfficialRate> ShowData()
        {
            NbrmWebService.Kurs kurs = new NbrmWebService.Kurs();
            var result = kurs.GetExchangeRateD(DateTime.Today, DateTime.Today);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(result);
            Debug.Write(result);
            foreach (XmlNode node in doc.SelectNodes("//KursZbir"))
            {
                string name = node["Oznaka"].InnerText;
                CLS_Currency c = myExchangeDb.CLS_Currency.Where(cu => cu.Name == name).FirstOrDefault();
                OfficialRate o = new OfficialRate();
                o.Currency = c.CurrencyId;
                o.ValidityDate = Convert.ToDateTime(node["Datum"].InnerText);
                o.Rate = Convert.ToDouble(node["Sreden"].InnerText);
                o.IsActive = 1;

                if (!myExchangeDb.OfficialRates.Where(or => or.ValidityDate == DateTime.Today && or.Currency == c.CurrencyId).Any())
                {
                    myExchangeDb.OfficialRates.Add(o);
                    myExchangeDb.SaveChanges();
                }
            }

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
            return "Succefully deleted";
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
