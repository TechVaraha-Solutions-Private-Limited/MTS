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
        [HttpGet("CheckGRNData")]
        public async Task<IActionResult> CheckGRNData([FromQuery] QuarantineDTO quarantineDTO)
        {
            //var appException = new AppException();
            try
            {
                var result = await _objRepository.CheckGRNData
                       (_mapper.Map<Quarantines>(quarantineDTO));

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
