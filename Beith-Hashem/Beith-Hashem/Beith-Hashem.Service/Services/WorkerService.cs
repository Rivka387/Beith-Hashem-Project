using Beith_Hashem.Core.Entities;
using Beith_Hashem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beith_Hashem.Service.Services
{
    public class WorkerService
    {

        //private readonly MemberRepository _memberRepository;
        //public MemberService(MemberRepository memberRepository)
        //{
        //    _memberRepository = memberRepository;

        //}

        //public List <Member> GetAll()
        //{
        //    return _memberRepository.GetList(); 
        //}


        readonly IMemberRepository _memberRepository;
        public MemberService(IMemberRepository membRepository)
        {
            _memberRepository = membRepository;
        }
        public List<Member> GetService()
        {
            return _memberRepository.GetAllMembers();
        }
        public Member GetByIdService(int id)
        {
            return _memberRepository.GetMemberById(id);
        }
        public bool AddMember(Member member)
        {
            //    if (!member.Id.CheckId())
            //        return false;
            return _memberRepository.AddMemberToList(member);
        }
        public bool DeleteByIdService(int id)
        {
            return _memberRepository.RemoveMemberById(id);
        }
        public bool UpdateMemberService(Member c, int id)
        {
            //if (!c.Identity.CheckId())
            //    return false;
            if (FindIndex(id) != -1)
                return _memberRepository.UpdateMember(c, id);
            return _memberRepository.AddMemberToList(c);
        }
        private int FindIndex(int id)
        {
            return GetService().FindIndex(c => c.Id == id);
        }
    }
}
