﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BackEnd.Models.Plug;

namespace BackEnd.Models.Dto
{
    public class PlugDtoIn
    {
        public string Mac { get; set; }
        public string Nickname { get; set; }
        public Priorities Priority { get; set; }
        public int IconNumber { get; set; }
    }
}
