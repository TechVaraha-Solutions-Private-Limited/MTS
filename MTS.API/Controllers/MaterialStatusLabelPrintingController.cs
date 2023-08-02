using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MTS.Application.Contracts.Persistance;
using MTS.Application.Features.CommonDto;
using MTS.Domain;

namespace MTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialStatusLabelPrintingController : ControllerBase
    {
        private readonly IMaterialStatusLabelPrint _objRepository;
        private readonly IMapper _mapper;

        public MaterialStatusLabelPrintingController(IMaterialStatusLabelPrint objRepository,IMapper mapper)
        {
            this._objRepository = objRepository;
            this._mapper = mapper;
        }
        [HttpGet("GrnNo/{GRNNo}")]
        public async Task<IActionResult> CheckGRNData(string GRNNo)
        {
            //var appException = new AppException();
            try
            {
                var result = await _objRepository.GetGrnData(GRNNo);

                return Ok(result);
            }
            catch (Exception ex)
            {
                //return BadRequest(appException.SendExceptionMessage(ex));
                return BadRequest(ex);
            }
        }
    }
}
