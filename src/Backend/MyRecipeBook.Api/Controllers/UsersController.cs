using Mapster;
using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Application;
using MyRecipeBook.Communication;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register(
            [FromBody] RequestRegisterUserAccountJson request,
            [FromServices] IRegisterUserAccountUseCase useCase)
        {
            useCase.Execute(request);
            return Created();
        }  
    }
}
