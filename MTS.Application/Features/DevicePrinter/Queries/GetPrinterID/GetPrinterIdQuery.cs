﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS.Application.Features.DevicePrinter.Queries.GetPrinterID
{
    public class GetPrinterIdQuery :IRequest<List<GetPrinterDto>>
    {
    }
}
