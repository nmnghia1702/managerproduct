using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void InsertMember(Member member) => MemberDAO.Instance.addNew(member);


        public void deleteMember(int id) => MemberDAO.Instance.Remove(id);


        public Member GetMemberByID(int id) => MemberDAO.Instance.GetMemberByID(id);


        public IEnumerable<Member> getMemberList() => MemberDAO.Instance.getMembers();


        public void updateMember(Member member) => MemberDAO.Instance.Update(member);

    }
}
