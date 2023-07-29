using AutoMapper;
using MTS.Application.Features.DevicePrinter.Queries.GetPrinterID;
using MTS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.MappingProfile
{
    public class DevicePrinter :Profile
    {
        public DevicePrinter()
        {
            CreateMap<GetPrinterDto, TblDeviceNprinter>().ReverseMap();
        }
       
    }
}
