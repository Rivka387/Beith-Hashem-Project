using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beith_Hashem.Core.Entities
{
    public class Event
    {

        public enum TargetAudience { girls = 1, boys = 2, children = 4, YeshivaGdolaGuys = 8, YeshivaKtanaGuy = 16, SeminarGirls = 32, women = 64, men = 128 }
    
          
            public int Id { get; set; }
            public string Name { get; set; }
            public DateOnly Date { get; set; }
            public TimeOnly TimeStart { get; set; }
            public TimeOnly TimeEnd { get; set; }
            public string place { get; set; }
            public TargetAudience targetAudience { get; set; }
            public int MaxCardsAmount { get; set; }
            public double price { get; set; }

            public Event(int id, string name, DateOnly date, TimeOnly timeStart, TimeOnly timeEnd, string place, TargetAudience targetAudience, int maxCardsAmount, double price)
            {
                Id = id;
                Name = name;
                Date = date;
                TimeStart = timeStart;
                TimeEnd = timeEnd;
                this.place = place;
                this.targetAudience = targetAudience;
                MaxCardsAmount = maxCardsAmount;
                this.price = price;
            }
            public Event()
            {
            }

    }
}
