using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Model
{
    public class TeamListItem
    {
        public int TeamId { get; set; }
        [Required]
        public string TeamName { get; set; }
        public int Rank { get; set; }
        public int PowerRating { get; set; }
        public int Roster { get; set; }
    }
}
