using Beith_Hashem.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Beith_Hashem.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Member> Members { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqlLocalDB;Database=my_db;Trusted_Connection=True;");
        }


        //public DataContext() {
        //    Members = new List<Member>();
        //    Members.Add(new Member { Id = 1, FamilyName = "Koen", EmailAdress = "name@gmail.com" });
        //}
    }
}