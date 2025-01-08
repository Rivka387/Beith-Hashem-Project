namespace Beith_Hashem.Core.Entities
{
    public enum AttendanceFrequency { Daily = 1, Often = 2, Holidays = 4, Saturdays = 8 }
    public enum PaymentMethod { Cash, Check, Credit_card, Bank_transfer }
    public class Member
    {
      
        //private static int nextId = 1;
        public int Id { get; set; }
        public string FamilyName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
        public string Address { get; set; }
        public double DonatioAmount { get; set; }
        public int FamiltSize { get; set; }
        public AttendanceFrequency Status { get; set; }
        public double TotalDonationsAmount { get; set; }
        public PaymentMethod payment { get; set; }

        public Member(int id, string familyName, string phoneNumber, string emailAdress, string address, double donatioAmount, int familtSize, AttendanceFrequency status, double totalDonationsAmount, PaymentMethod payment)
        {

            FamilyName = familyName;
            PhoneNumber = phoneNumber;
            EmailAdress = emailAdress;
            Address = address;
            DonatioAmount = donatioAmount;
            FamiltSize = familtSize;
            Status = status;
            TotalDonationsAmount = totalDonationsAmount;
            this.payment = payment;
        }
        public Member()
        {
        }

    }
}
