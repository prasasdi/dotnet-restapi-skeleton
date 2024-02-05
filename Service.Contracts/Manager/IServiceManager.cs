﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Manager
{
    public interface IServiceManager
    {
        IClassGroupService GroupClassService { get; }
        IClassMemberService GroupMemberService { get; }
    }
}