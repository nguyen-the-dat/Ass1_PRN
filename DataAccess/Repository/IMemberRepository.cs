using As01.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetAllMembers();
        MemberObject GetMemberById(int memberId);

        void Update(MemberObject member);

        void Delete(MemberObject member);

        void AddNew(MemberObject member);

        List<string> GetCities(string country);

        List<string> GetCities();

        List<string> GetCountry();

        MemberObject CheckMember(string name, string pass);
       List<MemberObject> getMembersByName(string name);
        List<MemberObject> getMembersByCountry(string country, string name);
        List<MemberObject> getMembersByCity(string city, string name);
    }
}
