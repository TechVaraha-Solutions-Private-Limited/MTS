using MediatR;
using Microsoft.AspNetCore.Mvc;
using MTS.Application.Features.Menus.Queries.GetUserMenudetails;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMenuController : ControllerBase
    {

        private readonly IMediator _mediator;

        public UserMenuController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetMenuList(string id)
        {
            var query = new GetUserMenuQuery { Username = id };
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
