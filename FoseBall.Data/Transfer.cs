﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Data
{
    public class Transfer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int TeamId1 { get; set; }
        [Required]
        public int TeamId2 { get; set; }
        [Required]
        public double Fee { get; set; }

        [ForeignKey(nameof(Player))]
        public int PlayerId { get; set; }


        public virtual Team Team { get; set; }
        public virtual Player Player { get; set; }

    }
}
