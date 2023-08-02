using AutoMapper;
using MTS.Application.Features.CommonDto;
using MTS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.MappingProfile
{
    public class RMPM:Profile
    {
        public RMPM()
        {
            CreateMap<Quarantines, QuarantineDTO>().ReverseMap();
            CreateMap<ITEMMASTER, ITEMMASTERDTO>().ReverseMap();
         
            CreateMap<DeviceNPrinter, DeviceNPrinterDTO>().ReverseMap();
         
            CreateMap<Log, LogsDTO>().ReverseMap();
        

        }
    }
}
