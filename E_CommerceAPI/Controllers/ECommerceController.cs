using E_CommerceAPI.Models;
using Microsoft.AspNetCore.Mvc;
using TestAPI;
using TestAPI.Models;

namespace E_CommerceAPI.Controllers
{
    public class ECommerceController : Controller
    {
        private IECommerceDal _ECommerceDal;

        public ECommerceController(IECommerceDal eCommerceDal)
        {
            _ECommerceDal = eCommerceDal;
        }

        [HttpGet("api/[Controller]")]
        public IActionResult Get()
        {
            var list = _ECommerceDal.GetList();
            return Ok(list);
        }

        [HttpGet("api/[Controller]/{id}")]
        public IActionResult GetWithId(int id)
        {
            var product = _ECommerceDal.Get(product => product.Id == id);
            return product != null ? Ok(product) : BadRequest();
        }

        [HttpPost("api/[Controller]/Add")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            var addedProduct = _ECommerceDal.Add(product);
            
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            return addedProduct == null ? BadRequest("There are no users with this id"): Ok(addedProduct);
        }

        [HttpPut("api/[Controller]/Update")]

        public IActionResult UpdateProduct([FromBody] Product product)
        {
            var updatedProduct = _ECommerceDal.Update(product);
            return Ok(updatedProduct);
        }

        [HttpDelete("api/[Controller]/Delete")]
        public IActionResult DeleteProduct([FromBody] Product product)
        {
            var deletedProduct = _ECommerceDal.Delete(product);
            return Ok(deletedProduct);
        }

    }
}
