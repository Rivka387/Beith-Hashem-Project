namespace beith_hashem.Core.Entities
{

    public class Worker
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; } 
        public string roleDescription { get; set; }
        public int Seniority { get; set; }
        public double HourlyWage { get; set; }
        public int WorkingHours { get; set; }
        public string Native { get; set; }

        public Worker(int id, string name, string identityNumber, string phoneNumber, string emailAdress, string roleDescription, int seniority, double hourlyWage, int workingHours, string native)
        {
            Id = id;
            Name = name;
            IdentityNumber = identityNumber;
            PhoneNumber = phoneNumber;
            EmailAdress = emailAdress;
            this.roleDescription = roleDescription;
            Seniority = seniority;
            HourlyWage = hourlyWage;
            WorkingHours = workingHours;
            Native = native;
        }

        public Worker()
        {
        }
    }

}
