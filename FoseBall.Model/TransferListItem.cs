using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Model
{
    public class TransferListItem
    {
        [Required]
        public double Fee { get; set; }
        [Display(Name = "Old Team")]
        [Required]
        public int OldTeam { get; set; }
        [Display(Name = "New Team")]
        [Required]
        public int NewTeam { get; set; }
        [Display(Name = "Player")]
        [Required]
        public int PlayerId { get; set; }
    }
}
