using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Model
{
    public class GameDetail
    {
        public int GameId { get; set; }
        public string HomeName { get; set; }
        public string AwayName { get; set; }
        public string Result { get; set; }
        public string Referee { get; set; }
    }
}
