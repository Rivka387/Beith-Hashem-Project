using beith_hashem.Core.Entities;
using Beith_Hashem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beith_Hashem.Core.Repositories
{
    public interface IDaveningRepository
    {
        public List<Davening> GetAllDavenes();
        public Member GetDavenById(int id);
        public bool AddDavenToList(Member member);
        public bool RemoveDavenById(int id);
        public bool UpdateDavening(Member member, int id);
    }
}
