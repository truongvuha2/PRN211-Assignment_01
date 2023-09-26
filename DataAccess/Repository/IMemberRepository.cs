using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetMemberObjects();
        MemberObject GetMemberByID(int memberId);
        MemberObject GetMemberByEmail(string email);
        void InsertMemberObject(MemberObject memberObject);
        void UpdateMemberObject(MemberObject memberObject);
        void DeleteMemberObject(int memberId);
    }
}
