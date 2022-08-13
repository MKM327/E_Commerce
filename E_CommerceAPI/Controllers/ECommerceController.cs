using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceAPI.Controllers
{
    public class ECommerceController : Controller
    {
        [HttpGet("api/[Controller]")]
        public string Get()
        {
            return "Hello world";
        }
    }
}
