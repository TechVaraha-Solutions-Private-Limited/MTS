using AutoMapper;
using MTS.Application.Features.Inward.Queries.GetInwarddetails;
using MTS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.MappingProfile
{
    public class InwardProfile : Profile
    {
        public InwardProfile()
        {
            CreateMap<GetInwarddetailsDTO, TblQuarantine>().ReverseMap();
        }
    }
}
