using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Models;

namespace MVC.Data
{
    public static class MemberData
    {
        public static List<Member> Members = new List<Member>() {
            new Member {
                FirstName = "Truong",
                LastName = "Nguyen",
                Gender = Gender.Male,
                DateOfBirth = new DateTime(2000,01,02),
                PhoneNum = "0332621587",
                BirthPlace = "TB",
                IsGraduated = false,

            },
            new Member {
                FirstName = "Truong",
                LastName = "Nguyen",
                Gender = Gender.Male,
                DateOfBirth = new DateTime(2000,01,02),
                PhoneNum = "0332621587",
                BirthPlace = "TB",
                IsGraduated = false,

            },
            new Member {
                FirstName = "Truong",
                LastName = "Nguyen",
                Gender = Gender.Male,
                DateOfBirth = new DateTime(2000,01,02),
                PhoneNum = "0332621587",
                BirthPlace = "TB",
                IsGraduated = false,

            }

        };
    }
}