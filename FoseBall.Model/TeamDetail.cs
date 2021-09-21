using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Model
{
    public class TeamDetail
    {
        [Required]
        public string TeamName { get; set; }
        public int LeagueId { get; set; }
        public int Rank { get; set; }
        public int PowerRanking { get; set; }
        public int Roster { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
    }
}
