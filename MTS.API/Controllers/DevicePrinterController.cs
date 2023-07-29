using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MTS.Application.Features.DevicePrinter.Queries.GetPrinterID;
using MTS.Application.Features.Usermaster.Queries.GetAllUsermaster;

namespace MTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevicePrinterController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DevicePrinterController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        [HttpGet]
        public async Task<List<GetPrinterDto>> GetPrinter()
        {
            var userMasters = await _mediator.Send(new GetPrinterIdQuery());
            return userMasters;
        }
    }
}
