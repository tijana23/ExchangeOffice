using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.Repository
{
    public interface ICLS_OperationTypeRepository
    {
        List<CLS_OperationType> GetAll();
        CLSOperationType GetById(int id);
        CLSOperationType InsertOperationType(CLS_OperationType operationType);
        CLSOperationType UpdateOperationType(CLS_OperationType operationType);
        CLSOperationType DeleteOperationType(CLS_OperationType operationType);
    }
}
