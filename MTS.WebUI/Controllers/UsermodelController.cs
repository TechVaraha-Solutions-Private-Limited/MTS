using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MTS.Application.Features.Usermaster.Queries.GetAllUsermaster;

namespace MTS.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsermodelController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsermodelController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<List<GetAllUsermasterDto>> Get()
        {
            var userMasters = await _mediator.Send(new GetAllUsermasterQuery());
            return userMasters;
        }
    }
}
