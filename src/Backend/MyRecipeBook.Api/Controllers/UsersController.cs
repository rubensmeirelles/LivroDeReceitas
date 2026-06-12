using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Communication;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] RequestRegisterUserAccountJson request)
        {
            return Created();
        }  
    }
}
