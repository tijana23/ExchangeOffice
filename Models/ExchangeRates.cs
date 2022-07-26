using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.Models
{
    public class ExchangeRates
    {
        public int ExchangeRatesId { get; set; }
        [DataType(DataType.Date)]
        public DateTime ValidityDate { get; set; }
        public int CurrencyFrom { get; set; }
        public int CurrencyTo { get; set; }
        [ForeignKey("CLS_CurrencyFrom")]
        public CLS_Currency CLS_CurrencyFrom { get; set; }
        [ForeignKey("CLS_CurrencyTo")]
        public CLS_Currency CLS_CurrencyTo { get; set; }
        public float Rate { get; set; }
        public int IsActive { get; set; }

    }
}
