﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evpro.Domain.Entities;
using Evpro.Service.Pattern;

namespace Evpro.Service
{
   public interface IUserService : IMyServiceGeneric<user>
    {
        int CountUser();
        int CountOrgnizer();
    }
}
