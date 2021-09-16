using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Model
{
    public class PlayerListItem
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string Position { get; set; }
        public int PlayerId { get; set; }
        public int OverallScore { get; set; }
    }
}
