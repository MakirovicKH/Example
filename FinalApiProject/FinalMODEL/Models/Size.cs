﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMODEL.Models
{
    public class Size : SoftDeletable
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
