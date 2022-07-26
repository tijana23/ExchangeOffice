using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.Models
{
    public class CLS_Currency
    {
        public int CurrencyId { get; set; }
        [MaxLength(50)]
        public string Code { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int IsActive { get; set; }
        public ICollection<OfficialRates> Officialrates { get; set; }
        [InverseProperty("ExchangeRatesFrom")]
        public ICollection<ExchangeRates> ExchangeRatesFrom { get; set; }
        [InverseProperty("ExchangeRatesTo")]
        public ICollection<ExchangeRates> ExchangeRatesTo { get; set; }
        [InverseProperty("OperationsFrom")]
        public ICollection<Operations> OperationsFrom { get; set; }
        [InverseProperty("OperationsTo")]
        public ICollection<Operations> OperationsTo { get; set; }

    }
}
