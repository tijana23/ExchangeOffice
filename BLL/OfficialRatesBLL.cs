using ExchangeOffice.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ExchangeOffice.BLL
{
    internal class OfficialRatesBLL : IRepository<OfficialRate>
    {
        Entity myExchangeDb = new Entity();
        private DbSet<OfficialRate> table;
        public List<OfficialRate> ShowData()
        {
            NbrmWebService.Kurs kurs = new NbrmWebService.Kurs();
            var Rresult = kurs.GetExchangeRateD(DateTime.Today, DateTime.Today);
            XmlDocument doc = new XmlDocument();
            XmlSerializer serializer = new XmlSerializer(typeof(dsKurs));
            dsKurs result;
            doc.LoadXml(Rresult);
            Debug.Write(Rresult);
            using (TextReader reader = new StringReader(Rresult))
            {
                result = (dsKurs)serializer.Deserialize(reader);
            }
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
            return GetAll();
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
            return Insert(or);
        }
        public string delete(int id)
        {
            OfficialRate or = myExchangeDb.OfficialRates.Where(o => o.OfficialRatesId == id).FirstOrDefault();
            return Update(or);
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
            return Update(or);
        }

        public List<OfficialRate> GetAll()
        {
            table = myExchangeDb.Set<OfficialRate>();
            List<OfficialRate> all = table.ToList<OfficialRate>();
            return all;
        }

        public OfficialRate GetById(int id)
        {
            table = myExchangeDb.Set<OfficialRate>();
            OfficialRate current = table.Find(id);
            return current;
        }

        public string Insert(OfficialRate t)
        {
            table = myExchangeDb.Set<OfficialRate>();
            table.Add(t);
            myExchangeDb.SaveChanges();
            return "Your information has been saved";
        }

        public string Update(OfficialRate t)
        {
            myExchangeDb.SaveChanges();
            return "Succefully updated";
        }
    }
}
