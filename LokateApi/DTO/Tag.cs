﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LokateApi.DTO
{
    public class Tag
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
    }
}
