using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Product.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        public IActionResult ActionResultInstance<TEntity>(ResponseDto<TEntity> response) where TEntity : class
        {

            return new ObjectResult(response)
            {
                StatusCode = response.status
            };
        }
    }
}
