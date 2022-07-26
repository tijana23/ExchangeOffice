using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.Models
{
    public class OfficialRates
    {
        public int OfficialRatesId { get; set; }
        [DataType(DataType.Date)]
        public DateTime ValidityDate { get; set; }
        public int Currency { get; set; }
        public CLS_Currency CLS_Currency { get; set; }
        public float Rate { get; set; }
        public int IsActive { get; set; }
    }
}
