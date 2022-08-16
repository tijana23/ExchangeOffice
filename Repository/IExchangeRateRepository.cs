using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.Repository
{
    public interface IExchangeRateRepository
    {
        List<ExchangeRate> GetAll();
        ExchangeRate Get(int id);
        ExchangeRate GetById(int id);
        ExchangeRate UpdateExchangeRate(int id, ExchangeRate ExchangeRate);
        ExchangeRate DeleteExchangeRate(int id);
        ExchangeRate InsertExchangeRate(ExchangeRate ExchangeRate);
    }
}
