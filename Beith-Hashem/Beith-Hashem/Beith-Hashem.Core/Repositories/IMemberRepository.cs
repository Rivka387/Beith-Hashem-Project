using Beith_Hashem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beith_Hashem.Core.Repositories
{
    public interface IMemberRepository 
    {
        //V
        public List<Member> GetAllMembers();
        public Member GetMemberById(int id);
        public bool AddMemberToList(Member member);
        public bool RemoveMemberById(int id);
        public bool UpdateMember(Member member, int id);

    }
}
