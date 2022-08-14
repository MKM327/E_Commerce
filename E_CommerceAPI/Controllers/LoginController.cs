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
            return verified ? Ok(user) : BadRequest("Invalid username or password");
        }
    }
}
