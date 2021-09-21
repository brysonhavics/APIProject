using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Data
{
   public class Game
    {
        [Key]
        public int GameId { get; set; }
        public int HomeId { get; set; }

        public int AwayId { get; set; }
        public string HomeName { get; set; }
        public string AwayName { get; set; }
        public string Result { get; set; }
        public string Referee { get; set; }
        public virtual Team Team { get; set; }
    }
}
