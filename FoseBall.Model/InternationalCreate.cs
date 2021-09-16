﻿using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Model
{
    public class InternationalCreate
    {
        [Required]
        public string Coach { get; set; }
        [Required]
        public int Ranking { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
