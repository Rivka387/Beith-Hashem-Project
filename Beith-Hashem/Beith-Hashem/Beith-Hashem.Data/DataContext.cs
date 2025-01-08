using Beith_Hashem.Core.Entities;

namespace Beith_Hashem.Data
{
    public class DataContext
    {
        public List<Member> Members { get; set; }
        public DataContext() {
            Members = new List<Member>();
            Members.Add(new Member { Id = 1, FamilyName = "Koen", EmailAdress = "name@gmail.com" });
        }
    }
}