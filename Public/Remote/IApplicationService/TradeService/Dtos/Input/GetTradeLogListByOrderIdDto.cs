﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IApplicationService.TradeService.Dtos.Input
{
    public class GetTradeLogListByOrderIdDto
    {
        public Guid OrderId { get; set; }
    }
}
