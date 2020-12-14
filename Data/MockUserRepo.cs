using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using users.Models;

namespace users.Data
{
    public class MockUserRepo : IUserRepo
    {

        public IEnumerable<User> GetAllUsers()
        {
            var users = new List<User>
            {
                new User{Id = 1, Fullname = "Awonugba Isaac", Address = "Flat 14 Elbourne House" },
                new User{Id = 2, Fullname = "Awonugba Tolu", Address = "Flat 14 Elbourne House" }
            };
            return users;
        }

        public User getUserById(int Id)
        {
            return new User{Id = 1, Fullname = "Awonugba Isaac", Address = "Flat 14 Elbourne House"};
        }
    }
}
