using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class MemberDAO
    {

        private static MemberDAO instance = null;

        private static readonly object instanceLock = new object();

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

        public IEnumerable<Member> getMembers()
        {
            var members = new List<Member>();
            try
            {
                using var context = new Ass02Context();
                members = context.Members.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;
        }

        public Member GetMemberByID(int memberID)
        {
            Member members = null;
            try
            {
                using var context = new Ass02Context();
                members = context.Members.SingleOrDefault(c => c.MemberId == memberID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;
        }

        public Member GetMemberLogin(string email, string password)
        {
            Member members = null;
            try
            {
                using var context = new Ass02Context();
                members = context.Members.SingleOrDefault(c => c.Email == email && c.Password == password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;
        }

        public void addNew(Member member)
        {
            try
            {
                Member _member = GetMemberByID(member.MemberId);
                if (_member == null)
                {
                    using var context = new Ass02Context();
                    context.Members.Add(member);
                    context.SaveChanges();
                }
                else throw new Exception("The mmeber is already exist!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Member member)
        {
            try
            {
                Member _member = GetMemberByID(member.MemberId);
                if (_member != null)
                {
                    using var context = new Ass02Context();
                    context.Members.Update(member);
                    context.SaveChanges();
                }
                else throw new Exception("The member does not already exist!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int memberID)
        {
            try
            {
                Member member = GetMemberByID(memberID);
                var orderS = OrderDAO.Instance.getOrdersByMemberID(memberID);
                if (member != null)
                {
                    using var context = new Ass02Context();
                    context.Members.Remove(member);
                    foreach (var x in orderS)
                    {
                        context.Orders.Remove(x);
                    }
                    
                    context.SaveChanges();
                }
                else throw new Exception("The member does not already exist!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public Member getAdminAccount()
        {
            Member Default = null;
            using (StreamReader r = new StreamReader("appsettings.json"))
            {
                string json = r.ReadToEnd();
                IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json")
                                        .Build();
                string email = config["account:defaultAccount:email"];
                string password = config["account:defaultAccount:password"];
                Default = new Member
                {
                    Email = email,
                    CompanyName = "FPT",
                    City = "HN",
                    Country = "VN",
                    Password = password
                };
            }

            return Default;
        }
    }
}

