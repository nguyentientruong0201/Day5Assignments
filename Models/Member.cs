using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Enum;
namespace MVC.Models
{
    public class Member
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Gender {get; set;}
        public DateTime DateOfBirth {get; set;}
        public string PhoneNum {get; set;}
        public string BirthPlace {get; set;}
        public bool IsGraduated {get; set;}
        
    }
}