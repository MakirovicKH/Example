﻿using FinalMODEL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMODEL.Models
{
    public class SoftDeletable : BaseEntity
    {
        public int CreateBy { get; set; }
        public int? UpdateBy { get; set; }
        public int? DeleteBy { get; set; }
        public bool? IsDeleted { get; set; }

    }
}
