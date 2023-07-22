using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.Usermaster.Queries.GetAllUsermaster
{
    public record GetAllUsermasterQuery: IRequest<List<User>>;
    
}
