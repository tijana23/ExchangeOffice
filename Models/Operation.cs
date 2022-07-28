namespace ExchangeOffice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Operation
    {
        public int OperationId { get; set; }

        public int? OperationTypeId { get; set; }

        public int? UserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OperationDate { get; set; }

        public int? Amount { get; set; }

        public int? CurrencyFrom { get; set; }

        public int? CurrencyTo { get; set; }

        public virtual CLS_Currency CLS_Currency { get; set; }

        public virtual CLS_Currency CLS_Currency1 { get; set; }

        public virtual CLS_OperationType CLS_OperationType { get; set; }

        public virtual User User { get; set; }
    }
}
