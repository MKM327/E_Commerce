using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAPI;

namespace E_CommerceAPI.Controllers
{
    public class ECommerceController : Controller
    {
        private ECommerceDAL _eCommerceDal;
        [HttpGet("api/[Controller]")]
        public string Get()
        {
            
        }
    }
}
