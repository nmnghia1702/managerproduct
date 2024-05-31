using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> getMemberList();

        Member GetMemberByID(int id);
        void InsertMember(Member member);
        void updateMember(Member member);
        void deleteMember(int id);


    }
}
