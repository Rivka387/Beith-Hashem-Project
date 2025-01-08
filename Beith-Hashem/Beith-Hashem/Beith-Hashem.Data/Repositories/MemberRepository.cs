using Beith_Hashem.Core.Entities;
using Beith_Hashem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Beith_Hashem.Data.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        readonly DataContext _dataContext;

        public MemberRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Member> GetAllMembers()
        {
            if (_dataContext!=null)
                return _dataContext.Members.ToList();
            else return new List<Member>();
        }
        public Member GetMemberById(int id)
        {
            return _dataContext.Members.FirstOrDefault(c => c.Id == id);
        }
        public bool AddMemberToList(Member customer)
        {
            if (!_dataContext.Members.Contains(customer))
            {
                _dataContext.Members.Add(customer);
                return true;
            }
            else return false;
        }
        public bool RemoveMemberById(int id)
        {
            var member = _dataContext.Members.FirstOrDefault(c => c.Id == id);
            if (member == null)
            {
                return false;
            }
            _dataContext.Members.Remove(member);
            return true;
        }
        public bool UpdateMember(Member member, int id)
        {
            var result = _dataContext.Members.ToList().FindIndex(c => c.Id == member.Id);
            if (result == -1)
            {
                return false;
            }
            //FamilyName = familyName;
            //PhoneNumber = phoneNumber;
            //EmailAdress = emailAdress;
            //Address = address;
            //DonatioAmount = donatioAmount;
            //FamiltSize = familtSize;
            //Status = status;
            //TotalDonationsAmount = totalDonationsAmount;
            //this.payment = payment;

            var existingMember = _dataContext.Members.FirstOrDefault(c => c.Id == id);
            if (existingMember == null)
            {
                return false;
            }
            //List<Member> lst = _dataContext.Members.ToList();



            existingMember.FamilyName = member.FamilyName ?? existingMember.FamilyName; // Update only if not null
            existingMember.PhoneNumber = member.PhoneNumber ?? existingMember.PhoneNumber;
            existingMember.EmailAdress = member.EmailAdress ?? existingMember.EmailAdress;
            existingMember.Address = member.Address ?? existingMember.Address;
            existingMember.DonatioAmount = member.DonatioAmount;
            existingMember.FamiltSize = member.FamiltSize;
            existingMember.Status = member.Status;
            existingMember.TotalDonationsAmount = member.TotalDonationsAmount;
            existingMember.payment = member.payment;


            return true;
        }
    }
}