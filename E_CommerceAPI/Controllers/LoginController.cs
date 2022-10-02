using System.Security.Claims;
using E_CommerceAPI.Data_Access.Login_Data_Access;
using E_CommerceAPI.Models;
using Microsoft.AspNetCore.Mvc;
namespace E_CommerceAPI.Controllers
{

    public class LoginController : Controller
    {
        private IEFLoginDal _efLoginDal;

        public LoginController(IEFLoginDal loginDal)
        {
            _efLoginDal = loginDal;
        }
        [HttpPost("api/[Controller]/Add")]
        public IActionResult AddUser([FromBody] User user)
        {
            _efLoginDal.AddUser(user);
            return Ok(user);
        }
        [HttpPost("api/[Controller]/Verify")]
        public IActionResult VerifyUser([FromBody] User user)
        {
            var verified = _efLoginDal.VerifyUser(user);
            return verified != null ? Ok(verified) : BadRequest("Invalid username or password");
        }
        [HttpGet("api/[Controller]")]
        public IActionResult GetAllUsers()
        {
            var users = _efLoginDal.GetAllUsers();
            return Ok(users);
        }
        [HttpDelete("api/[Controller]/Delete")]

        public IActionResult DeleteUser([FromBody] User user)
        {
            _efLoginDal.Delete(user);
            return Ok(user);
        }
        [HttpPut("api/[Controller]/Update")]
        public IActionResult UpdateUser([FromBody] User user)
        {
            _efLoginDal.Update(user);
            return Ok(user);
        }
        [HttpPut("api/[Controller]/UpdateProfile")]
        public IActionResult UpdateUserProfile( [FromBody] UserProfile profile)
        {
            var updatedProfile = _efLoginDal.UpdateUserProfile(profile);
            return Ok(updatedProfile);
        }
    }
}
