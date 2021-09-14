using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace FoseBall.Model
{
    public class LeagueCreate
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Nation { get; set; }
        [Required]
        public int NumberOfTeams { get; set; }
    }
}
