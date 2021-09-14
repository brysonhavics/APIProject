using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace FoseBall.Model
{
    public class LeagueListItem
    {
        public int LeagueId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Nation { get; set; }        
        public int NumberOfTeams { get; set; }
    }
}
