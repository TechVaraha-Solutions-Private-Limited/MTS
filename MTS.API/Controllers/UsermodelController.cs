using MediatR;
using Microsoft.AspNetCore.Mvc;
using MTS.Application.Features.Usermaster.Queries.GetAllUsermaster;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MTS.API.Controllers
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
