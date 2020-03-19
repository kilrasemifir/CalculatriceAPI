using CalculatriceAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatriceAPI.Repositories.Impl
{
    using Models;
    public class OperationFakeRepository : OperationRepository
    {
        private List<Operation> enities = new List<Operation>();
        public void Delete(int id)
        {
            this.enities[id] = null;
        }

        public IEnumerable<Operation> FindAll()
        {
            return this.enities.Where(e => e != null);
        }

        public Operation FindById(int id)
        {
            return this.enities[id];
        }

        public Operation Save(Operation entity)
        {
            entity.Id = this.enities.Count();
            this.enities.Add(entity);
            return entity;
        }

        public Operation Update(Operation entity)
        {
            this.enities[entity.Id] = entity;
            return entity;
        }

    }
}
