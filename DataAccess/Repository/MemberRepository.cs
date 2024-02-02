using As01.BusinessObject;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void AddNew(MemberObject member) => MemberDAO.Instance.AddNew(member);

        public MemberObject CheckMember(string name, string pass) => MemberDAO.Instance.checkMem(name, pass);
        public void Delete(MemberObject member) =>MemberDAO.Instance.Delete(member);

        public IEnumerable<MemberObject> GetAllMembers() => MemberDAO.Instance.GetMemberList;

        public List<string> GetCities(string country) => MemberDAO.Instance.getCities(country);

        public List<string> GetCities() => MemberDAO.Instance.getCities();

        public List<string> GetCountry() => MemberDAO.Instance.getCountry();

        public MemberObject GetMemberById(int memberId) =>MemberDAO.Instance.getMemberById(memberId);

        public List<MemberObject> getMembersByCity(string city, string name) => MemberDAO.Instance.getMembersByCity(city, name);

        public List<MemberObject> getMembersByCountry(string country , string name) => MemberDAO.Instance.getMembersByCountry(country ,name);

        public List<MemberObject> getMembersByName(string name) => MemberDAO.Instance.getMembersByName(name);

        public void Update(MemberObject member)=>MemberDAO.Instance.Update(member);

        
    }
}
