using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Data
{
   public class Games
    {
        [Required]
        public int Wins { get; set; }
        [Required]
        public int Losses { get; set; }
        [Required]
        public int draw { get; set; }
    }
}
