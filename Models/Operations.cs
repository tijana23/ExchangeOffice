using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.Models
{
    public class Operations
    {
        public int OperationId { get; set; }
        public int OperatOperationTypeId { get; set; }
        public CLS_OperationType OperationType { get; set; }
        public int UserId { get; set; }
        public Users Users { get; set; }
        [DataType(DataType.Date)]
        public DateTime OperationDate { get; set; }
        public int CurrencyFrom { get; set; }
        public int CurrencyTo { get; set; }
        [ForeignKey("CLS_CurrencyFrom")]
        public CLS_Currency CLS_CurrencyFrom { get; set; }
        [ForeignKey("CLS_CurrencyTo")]
        public CLS_Currency CLS_CurrencyTo { get; set; }
        public int Amount { get; set; }
    }
}
