﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IApplicationService.AccountService.Dtos.Input
{
    public class GetAccountUserNameByIdsDto
    {
        public List<Guid> Ids { get; set; }
    }
}
