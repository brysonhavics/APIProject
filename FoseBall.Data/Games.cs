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
        [Key]
        public int GameId { get; set; }
        [Required]
        public int HomeId { get; set; }
        [Required]
        public int AwayId { get; set; }
        public string Result { get; set; }
        [Required]
        public string Referee { get; set; }
    }
}
