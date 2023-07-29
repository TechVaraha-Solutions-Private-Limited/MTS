using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MTS.Application.Features.Inward.Queries.GetInwarddetails;
using MTS.Application.Features.Menus.Queries.GetUserMenudetails;
using MTS.Application.Features.Usermaster.Queries.GetAllUsermaster;
using MTS.Domain;

namespace MTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InwardController : ControllerBase
    {
        private readonly IMediator _mediator;

        public InwardController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        [HttpGet("{GrnNo}")]
        public async Task<ActionResult<List<GetInwarddetailsDTO>>> GetInwardDetails(string GrnNo)
        {
            var query = new GetInwardDetailsQuery { GrnNo = GrnNo };
            var grndetails = await _mediator.Send(query);
            return grndetails;
        }
    }
}
