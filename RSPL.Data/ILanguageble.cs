﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPL.Data
{
    interface ILanguageble
    {
        byte Persent { get; set; }
        Year Year  { get; set; }
        Region Region { get; set; }
    }
}
