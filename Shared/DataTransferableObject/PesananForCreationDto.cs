﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferableObject
{
    public record PesananForCreationDto(char Tipe, char Ukuran, int Jumlah, Guid IdProduk);
}
