using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatriceAPI.Repositories
{
    using DTO;
    using Models;
    public interface OperationRepository
    {
        public IEnumerable<Operation> FindAll();
        public Operation Save(Operation entity);
        public void Delete(int id);
        public Operation FindById(int id);
        public Operation Update(Operation entity);
    }
}
