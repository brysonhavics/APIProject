﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Data
{
    public class League
    {
        [Key]
        public int LeagueId { get; set; }
        public string Nation { get; set; }
        public int NumberOfTeams { get; set; }
        public string Name { get; set; }

    }
}
