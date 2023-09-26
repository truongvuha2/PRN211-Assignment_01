using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess.Repository;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public MemberObject GetMemberByID(int memberId) => MemberDAO.Instance.GetMemberByID(memberId);
        public MemberObject GetMemberByEmail(string email) => MemberDAO.Instance.GetMemberByEmail(email);
        public IEnumerable<MemberObject> GetMemberObjects() => MemberDAO.Instance.GetMemberList;
        public void InsertMemberObject(MemberObject memberObject) => MemberDAO.Instance.AddNew(memberObject);
        public void DeleteMemberObject(int memberId) => MemberDAO.Instance.Remove(memberId);
        public void UpdateMemberObject(MemberObject memberObject) => MemberDAO.Instance.Update(memberObject);
    }
}
