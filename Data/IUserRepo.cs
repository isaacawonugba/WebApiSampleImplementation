using System.Collections.Generic;
using users.Models;

namespace users.Data
{
    public interface IUserRepo
    {
        IEnumerable<User> GetAllUsers();
        User getUserById(int Id);
    }
}