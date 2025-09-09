using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        private IMediator? _mediator;

        // "??=" if the thing to the left is null, then set it to be whatever is to the right of the "="
        //"??" check if the thing to the left is null
        protected IMediator Mediator =>
            _mediator ??=
                HttpContext.RequestServices.GetService<IMediator>()
                ?? throw new InvalidOperationException("IMediator service is unavailable");
    }
}
