﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferableObject
{
    public record KomentarDto
    {
        public Guid Id { get; init; }
        public string IsiKomentar { get; init; }
    }
}
