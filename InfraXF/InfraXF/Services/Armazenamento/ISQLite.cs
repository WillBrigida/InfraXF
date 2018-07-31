﻿using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraXF.Services.Armazenamento
{
    public interface ISQLite
    {
        string DirectoryDB { get; }
        ISQLitePlatform Platform { get; }
    }
}
