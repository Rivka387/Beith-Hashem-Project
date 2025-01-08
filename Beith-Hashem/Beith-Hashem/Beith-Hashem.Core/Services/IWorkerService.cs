using beith_hashem.Core.Entities;
using Beith_Hashem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beith_Hashem.Core.Services
{
    public interface IWorkerService
    {
        public List<Worker> GetService();
        public Worker GetByIdService(int id);
        public bool AddWorker(Worker worker);
        public bool DeleteWorkerByIdService(int id);
        public bool UpdateWorkerService(Worker worker, int id);
    }
}
