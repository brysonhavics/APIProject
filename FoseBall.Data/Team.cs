using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Data
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        [Required]
        public string TeamName { get; set; }
        public int LeagueId { get; set; }
        public int Rank { get; set; }
        public int PowerRating
        {
            get
            {
                int num = 0;
                foreach (var rating in Players)
                {
                    num = +rating.OverallScore;
                }

                return (Players.Count() > 0) ? num/Players.Count(): 0;
            }
            set { }
        } 
        public virtual League League { get; set; }
        public virtual List<Player> Players { get; set; } = new List<Player>();
    }
}
