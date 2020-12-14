using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using users.Models;
using users.Data;
namespace users.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly MockUserRepo _repository = new MockUserRepo();

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            var useritems = _repository.GetAllUsers();

            return Ok(useritems);
        }

        [HttpGet("{id}")]
        public ActionResult <User> GetUserById(int Id)
        {
            var useritem = _repository.getUserById(Id);

            return Ok(useritem);
        }
    }
}