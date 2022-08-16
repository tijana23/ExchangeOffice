using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.Repository
{
    public interface ICLS_CurrencyRepository
    {
        List<CLS_Currency> GetAll();
        CLS_Currency GetById(int id);
        CLS_Currency InsertCLS_Currency(CLS_Currency currency);
        CLS_Currency UpdateCLS_Currency(CLS_Currency currency);
        CLS_Currency DeleteCLS_Currency(int id);
    }
}
