using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Model
{
    public class TransferDetail
    {
        [Required]
        public double Fee { get; set; }
        [Display(Name = "Old Team")]
        public string OldTeam { get; set; }
        [Display(Name = "New Team")]
        public string NewTeam { get; set; }
        [Display(Name = "Player")]
        public string Player { get; set; }
    }
}
