﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Settings
{
    public class JWT
    {

        public string key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string DurationInMinutes { get; set; }
        
    }
}
