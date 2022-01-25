using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Data;
using MVC.Models;

namespace MVC.Services
{
    public class MemberService : IMemberServices
    {
       public List<Member> GetMaleMembers(){
           return MemberData.Members.Where(m=>m.Gender == Enum.Gender.Male).ToList();
       } 
    }
}