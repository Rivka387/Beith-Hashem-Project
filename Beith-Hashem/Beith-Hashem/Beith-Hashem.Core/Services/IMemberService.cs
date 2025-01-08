using Beith_Hashem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beith_Hashem.Core.Services
{
    public interface IMemberService
    {
//V
        public List<Member> GetService();
        public Member GetByIdService(int id);
        public bool AddMember(Member member);
        public bool DeleteByIdService(int id);
        public bool UpdateMemberService(Member member, int id);
    }
}
