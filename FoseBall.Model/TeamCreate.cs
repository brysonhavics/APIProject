using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Model
{
    public class TeamCreate
    {
        [Required]
        [MaxLength(40, ErrorMessage = "Please shorten your team name")]
        public string TeamName { get; set; }
        public int LeagueId { get; set; }
        public int Rank { get; set; }
    }
}
