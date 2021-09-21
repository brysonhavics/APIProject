using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Model
{
    public class GameCreate
    {
        public int HomeId { get; set; }
        public int AwayId { get; set; }
        public string Referee { get; set; }
    }
}
