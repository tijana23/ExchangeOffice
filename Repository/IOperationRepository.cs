using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOffice.Repository
{
    public interface IOperationRepository
    {
        List<Operation> GetAllOperations();
        Operation GetById(int id);
        Operation InsertOperation(Operation operation);
        Operation UpdateOperation(Operation operation);
        Operation DeleteOperation(int id);

    }
}
