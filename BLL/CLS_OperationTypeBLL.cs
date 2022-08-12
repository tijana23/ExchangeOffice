using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.BLL
{
    internal class CLS_OperationTypeBLL
    {
        Entity myExchangeDb = new Entity();
        public List<CLS_OperationType> ShowData()
        {
            List<CLS_OperationType> allCOP = myExchangeDb.CLS_OperationType.ToList<CLS_OperationType>();
            return allCOP;
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
            myExchangeDb.CLS_OperationType.Add(cop);
            myExchangeDb.SaveChanges();
            return "Your information has been saved";
        }
        public string delete(int id)
        {
            CLS_OperationType cop = myExchangeDb.CLS_OperationType.Where(o => o.OperationTypeId == id).FirstOrDefault();
            cop.IsActive = 0;
            return "Succefully delete";
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
            myExchangeDb.CLS_OperationType.Add(cop);
            myExchangeDb.SaveChanges();
            return "Succefully updated";
        }
    }
}
