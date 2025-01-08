using Beith_Hashem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beith_Hashem.Core.Repositories
{
    public interface IWorkerRepository
    {
        public List<Member> GetAlWorkers();
        public Member GetWorkerById(int id);
        public bool AddWorkerToList(Member member);
        public bool RemoveWorkerById(int id);
        public bool UpdateWorker(Member member, int id);
    }
}
