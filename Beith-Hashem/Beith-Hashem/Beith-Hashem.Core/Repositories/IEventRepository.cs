using Beith_Hashem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beith_Hashem.Core.Repositories
{
    public interface IEventRepository
    {
        public List<Event> GetAllEvent();
        public Event GetEventById(int id);
        public bool AddEventToList(Event even);
        public bool RemoveEventById(int id);
        public bool UpdateEvent(Event even, int id);
    }
}
