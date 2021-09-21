using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Data
{
    public class GameListItem
    {
        public int GameId { get; set; }
        public string HomeName { get; set; }
        public string AwayName { get; set; }
        public string Referee { get; set; }
        [Display(Name = "Result")]
        public string Result { get; set; }
    }
}
