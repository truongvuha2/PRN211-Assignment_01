using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObject;

namespace DataAccess
{
    public class MemberDAO
    {
        // Initialize member list
        private static List<MemberObject> MemberList = new List<MemberObject>
        {
            new MemberObject { MemberID = 1, MemberName = "Truong Vu", Email = "vut@fpt.edu.vn", Password = "11223344", City = "Da Nang", Country = "VietNam" },
            new MemberObject { MemberID = 2, MemberName = "Minh Khang", Email = "khangm@fpt.edu.vn", Password = "123456", City = "Can Tho", Country = "US" },
            new MemberObject { MemberID = 3, MemberName = "Khoa Do", Email = "khoad@fpt.edu.vn", Password = "123456", City = "Bac Lieu", Country = "VietNam"},
            new MemberObject { MemberID = 4, MemberName = "John Doe", Email = "john@fstore.com", Password = "987654321", City = "New York", Country = "US" },
            new MemberObject { MemberID = 5, MemberName = "Alice Smith", Email = "alice@fstore.com", Password = "44332211", City = "London", Country = "UK" },
            new MemberObject { MemberID = 6, MemberName = "Bob Johnson", Email = "bob@fstore.com", Password = "123123", City = "Toronto", Country = "Canada" },
            new MemberObject { MemberID = 7, MemberName = "Emily Brown", Email = "emily@fstore.com", Password = "000000", City = "Sydney", Country = "Australia" }
        };

        //-------------------------------------------------------
        // Using Singleton Pattern

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        private MemberDAO() { }

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        //---------------------------------------------------------------

        public List<MemberObject> GetMemberList => MemberList;

        //-------------------------------------------------------------
        public MemberObject GetMemberByID(int memberID)
        {
            // Using LINQ to Object
            MemberObject memberObject = MemberList.SingleOrDefault(mem => mem.MemberID == memberID);
            return memberObject;
        }
        public MemberObject GetMemberByEmail(string email)
        {
            // Using LINQ to Object to find a member by email
            MemberObject memberObject = MemberList.SingleOrDefault(mem => mem.Email == email);
            return memberObject;
        }


        //----------------------------------------------------------
        // Add a new member
        public void AddNew(MemberObject memberObject)
        {
            MemberObject existingMember = GetMemberByID(memberObject.MemberID);
            if (existingMember == null)
            {
                MemberList.Add(memberObject);
            }
            else
            {
                throw new Exception("Member already exists.");
            }
        }

        public void Update(MemberObject memberObject)
        {
            MemberObject existingMember = GetMemberByID(memberObject.MemberID);
            if (existingMember != null)
            {
                var index = MemberList.IndexOf(existingMember);
                MemberList[index] = memberObject;
            }
            else
            {
                throw new Exception("Member does not exist.");
            }
        }

        //---------------------------------------------------------
        // Remove a member
        public void Remove(int memberID)
        {
            MemberObject existingMember = GetMemberByID(memberID);
            if (existingMember != null)
            {
                MemberList.Remove(existingMember);
            }
            else
            {
                throw new Exception("Member does not exist.");
            }
        }
    }
}
