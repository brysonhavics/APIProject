using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Model
{
    public class PlayerDetail
    {
        public string Name { get; set; }
        public int Number { get; set; }
        [Display(Name = "Club Team")]
        public string TeamName { get; set; }
        [Display(Name = "International Team")]
        public string InternationalTeam { get; set; }
        public string Position { get; set; }
    }
}
