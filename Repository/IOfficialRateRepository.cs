using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.Repository
{
    public interface IOfficialRateRepository
    {
        List<OfficialRate> GetAll();
        OfficialRate GetOfficialRate(int id);
        OfficialRate InsertOfficialRate(OfficialRate officialRate);
        OfficialRate UpdateOfficialRate(int id,OfficialRate officialRate);
        OfficialRate DeleteOfficialRate(int id);

       
    }
}
