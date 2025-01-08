using Beith_Hashem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beith_Hashem.Core.Services
{
    public interface IEventService
    {

        public List<Event> GetService();
        public Event GetByIdService(int id);
        public bool AddEvent(Event even);
        public bool DeleteEventByIdService(int id);
        public bool UpdateEventService(Event even, int id);
    }
}
