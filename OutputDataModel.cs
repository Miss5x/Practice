﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    public class OutputDataModel
    {
        public string kod { get; set; }
        public string salt { get; set; }
        public string hash { get; set; }
    }
}
