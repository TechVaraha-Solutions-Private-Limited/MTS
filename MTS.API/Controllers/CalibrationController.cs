using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MTS.Application.Features.Calibration;
using MTS.Application.Features.Calibration.Queries.GetCalibrationData;
using MTS.Application.Features.Inward.Queries.GetInwarddetails;
using MTS.Domain;

namespace MTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalibrationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CalibrationController(IMediator mediator)
        {
            this._mediator = mediator;
        }
       
        [HttpGet("new/{weighid}")]
        public async Task<ActionResult<List<GetInwarddetailsDTO>>> GetcalibrationDatas(string weighid)
        {

            var query = new GetCalibrationDataQuery { WeighingID = weighid };
            var grndetails = await _mediator.Send(query);
            return Ok(grndetails);
        }

    }

}
