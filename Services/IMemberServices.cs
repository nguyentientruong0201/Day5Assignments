using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Models;

namespace MVC.Services
{
    public interface IMemberServices
    {
        List<Member> GetMaleMembers();
    }
}