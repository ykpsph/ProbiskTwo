﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PT_Models
{
    public class ApplicationType
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
