using AutoMapper;
using MTS.Application.Features.Usermaster.Queries.GetAllUsermaster;
using MTS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.MappingProfile
{
    public class UserMasterProfile :Profile
    {
        public UserMasterProfile()
        {
            CreateMap<GetAllUsermasterDto, TblUsermaster>().ReverseMap();
            
        }
    }
}
