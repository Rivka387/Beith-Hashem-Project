using beith_hashem.Core.Entities;
using Beith_Hashem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beith_Hashem.Core.Services
{
    public interface IDaveningService
    {

        public List<Davening> GetService();
        public Davening GetByIdService(int id);
        public bool AddDavening(Davening davening);
        public bool DeleteDaveningByIdServices(int id);
        public bool UpdateDaveningService(Davening daveningr, int id);
    }
}
