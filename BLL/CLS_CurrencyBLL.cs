using ExchangeOffice.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExchangeOffice.BLL
{
    internal class CLS_CurrencyBLL : IRepository<CLS_Currency>
    {
        Entity myExchangeDb = new Entity();
        private DbSet<CLS_Currency> table;
        public List<CLS_Currency> ShowData()
        {
            NbrmWebService.Kurs kurs = new NbrmWebService.Kurs();
            var result = kurs.GetExchangeRateD(DateTime.Today, DateTime.Today);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(result);
            Debug.Write(result);
            foreach (XmlNode node in doc.SelectNodes("//KursZbir"))
            {
                string name = node["Oznaka"].InnerText;
                string currency = node["Valuta"].InnerText;
                CLS_Currency c = new CLS_Currency();
                c.Name = name;
                c.Code = currency;
                c.IsActive = 1;

                myExchangeDb.CLS_Currency.Add(c);
                myExchangeDb.SaveChanges();

                //if (!myExchangeDb.CLS_Currency.Any())
                //{
                //    myExchangeDb.CLS_Currency.Add(c);
                //    myExchangeDb.SaveChanges();
                //}
            }
            return GetAll();
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
            return Insert(c);
        }
        public string delete(int id)
        {
            CLS_Currency c = myExchangeDb.CLS_Currency.Where(o => o.CurrencyId == id).FirstOrDefault();
            return Update(c);
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
            return Update(c);
        }

        public List<CLS_Currency> GetAll()
        {
            table = myExchangeDb.Set<CLS_Currency>();
            List<CLS_Currency> all = table.ToList<CLS_Currency>();
            return all;
        }

        public CLS_Currency GetById(int id)
        {
            table = myExchangeDb.Set<CLS_Currency>();
            CLS_Currency current = table.Find(id);
            return current;
        }

        public string Insert(CLS_Currency t)
        {
            table = myExchangeDb.Set<CLS_Currency>();
            table.Add(t);
            myExchangeDb.SaveChanges();
            return "Your information has been saved";
        }

        public string Update(CLS_Currency t)
        {
            myExchangeDb.SaveChanges();
            return "Succefully updated";
        }
    }
}
